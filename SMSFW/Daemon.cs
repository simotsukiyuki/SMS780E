using SerialPortHelperLib;
using SMS780E.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMSFW
{
    public partial class Daemon : Form
    {

        ConfigComType cfgCom;
        SerialPortHelper sp;
        public MsgSQLManager msgMgr;

        BootForm mainForm;
        DesktopForm desktopForm;

        public bool confirmClosing = false;
        string portName;
        int baudRate, dataBits;
        string stopBits;
        int restartCount = 0;

        public Daemon()
        {
            InitializeComponent();
        }

        private void Daemon_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            msgMgr = new MsgSQLManager();

            mainForm = new BootForm();
            mainForm.daemon = this;


            this.Hide();

            mainForm.Show();
        }

        internal bool StartCom(string portName, int baudRate, int dataBits, string stopBits, out string information)
        {
            if (portName == "COM")
            {
                information = "请填写端口号";
                return false;
            }
            try
            {
                cfgCom = new ConfigComType();
                cfgCom.PortName = portName;
                cfgCom.BaudRate = baudRate;
                cfgCom.DataBits = dataBits;
                switch (stopBits)
                {
                    case "2":
                        cfgCom.StopBits = StopBits.Two;
                        break;
                    case "1.5":
                        cfgCom.StopBits = StopBits.OnePointFive;
                        break;
                    default:
                        cfgCom.StopBits = StopBits.One;
                        break;
                }
                cfgCom.Parity = Parity.None;

                sp = new SerialPortHelper(cfgCom);
                sp.SerialReceviedLengthMax = 8192;

                sp.BindSerialPortDataReceivedProcessEvent(new SerialPortHelper.DelegateSerialPortDataReceivedProcessEvent(SerialPortDataReceivedProcess));
                sp.BindSerialPortErrorEvent(new SerialPortHelper.DelegateSerialPortErrorEvent(SerialPortErrorEvent));
                sp.OpenCom(out string err);
                if (err != "null")
                {
                    information = err;
                    return false;
                }

                information = "success";

                this.portName = portName;
                this.baudRate = baudRate;
                this.dataBits = dataBits;
                this.stopBits = stopBits;



                return true;
            }
            catch (Exception ex)
            {
                information = ex.ToString();
                return false;
            }
        }

        private void SerialPortErrorEvent(object sender, enumSerialError enumError, string strError)
        {

            switch (enumError)
            {
                case enumSerialError.LinkError:
                    desktopForm.OnComConnectionError();
                    this.Invoke(new MethodInvoker(delegate { reconnectTimer.Enabled = true; reconnectTimer.Start(); }));
                    break;
                default://忽略其他错误
                    break;

            }
        }

        private void SerialPortDataReceivedProcess(object sender, byte[] arrData)
        {
            this.Invoke(new Action(() =>
            {
                //串口数据处理
                string msg = Encoding.UTF8.GetString(arrData);
                msg = msg.Replace("\n", " ");
                msg = msg.Replace("\"", "”");
                msg = msg.Replace("@$", "{\"");
                msg = msg.Replace("$:$", "\":\"");
                msg = msg.Replace("$,$", "\",\"");
                msg = msg.Replace("$@", "\"}");
                //MessageBox.Show(msg);
                //Clipboard.SetText(msg);
                NewMsg(msg);
            }));
        }

        public void NewMsg(string msgJson)
        {
            Msg newMsg = MsgTools.ParseJsonToMsg(msgJson);

            msgMgr.InsertNewMsgToDb(newMsg);

            desktopForm.OnNewMsgReceived(newMsg);
        }

        public Msg LoadMsgContent(string msgID)
        {
            msgMgr.SetMsgReadedState(msgID);
            return msgMgr.GetMsg(msgID);
        }

        public void NewDesktopForm()
        {
            desktopForm = new DesktopForm();
            desktopForm.daemon = this;
        }

        public void ShowDesktopForm()
        {
            desktopForm.WindowState = FormWindowState.Maximized;
            desktopForm.Enabled = true;
            desktopForm.Show();
        }

        public void DirectExit()
        {
            Application.Exit();
        }

        internal void Exit()
        {
            DialogResult dr = MessageBox.Show("退出程序将无法接收到短信。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                confirmClosing = true;
                DirectExit();
            }
        }

        private void ErrorExit()
        {
            confirmClosing = true;
            MessageBox.Show("发生通讯错误且尝试重连失败，系统即将退出。请检查串口连接。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DirectExit();
        }

        private void reconnectTimer_Tick(object sender, EventArgs e)
        {
            bool restartResult = StartCom(portName, baudRate, dataBits, stopBits, out _);
            if (restartResult)
            {
                desktopForm.OnComReconnected();
                reconnectTimer.Stop();
                reconnectTimer.Enabled = false;
                restartCount = 0;
                return;
            }
            else
            {
                restartCount++;
            }
            if (restartCount > 15)
            {
                reconnectTimer.Stop();
                reconnectTimer.Enabled = false;
                ErrorExit();
            }
        }
    }
}
