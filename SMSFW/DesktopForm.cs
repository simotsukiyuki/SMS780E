using ApeFree.ApeForms.Forms.Notifications;
using SMS780E.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS780E
{
    public partial class DesktopForm : Form
    {
        public Daemon daemon;
        DateTime lastMsgReceived;

        public DesktopForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            BindDataSource();
            tss_state.Text = "系统就绪，待机....";
            lastMsgReceived = DateTime.MinValue;

            tsmNewMsgEnabled.Checked = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daemon.Exit();
        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!daemon.confirmClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void NewMsgNotify(Msg msg)
        {
            if (tsmNewMsgEnabled.Checked == true)
            {
                SendNotify(
                    "新信息来自" + msg.from,
                    msg.msgContent + "\n接收日期：" + msg.recvTime.ToString()
                    );
                //Notification.Builder.ShowTextNotification(s =>
                //{
                //    // 标题
                //    s.Title = "新信息来自" + msg.from;
                //    // 消息内容
                //    s.Message = msg.msgContent + "\n接收日期：" + msg.recvTime.ToString();
                //    // 通知栏停留时长(毫秒)
                //    s.RetentionTime = 15000;
                //    //提示色
                //    s.ReminderColor = Color.LightSkyBlue;

                //});
            }
        }

        public void OnNewMsgReceived(Msg msg)
        {
            BindDataSource();
            NewMsgNotify(msg);

            tss_state.Text = "新消息已接收。待机....";
            lastMsgReceived = DateTime.Now;
        }

        public void SendNotify(string title, string content)
        {
            Notification.Builder.ShowTextNotification(s =>
            {
                // 标题
                s.Title = title;
                // 消息内容
                s.Message = content;
                // 通知栏停留时长(毫秒)
                s.RetentionTime = 15000;
                //提示色
                s.ReminderColor = Color.LightSkyBlue;

            });
        }

        public void OnNewMsgReceived()
        {
            BindDataSource();

            tss_state.Text = "新消息已接收。待机....";
            lastMsgReceived = DateTime.Now;
        }


        public void OnComConnectionError()
        {
            tss_state.Text = "与串口的连接中断，正在尝试重连....";
        }

        public void OnComReconnected()
        {
            tss_state.Text = "重连成功。待机....";
        }

        private void BindDataSource()
        {
            dataGridView1.DataSource = daemon.msgMgr.GetMsgDataTable();
        }

        private void BindDataSource(string keywords)
        {
            dataGridView1.DataSource = daemon.msgMgr.SearchMsg(keywords);
        }

        private void timerLastMsgCounter_Tick(object sender, EventArgs e)
        {
            if (lastMsgReceived == DateTime.MinValue)
            {
                tss_lastNewMsg.Text = "上一条短信接收于很久以前……";
            }
            else
            {
                var ts = DateTime.Now - lastMsgReceived;
                tss_state.Text = "系统就绪，待机....";
                tss_lastNewMsg.Text = string.Format("上一条信息接收于{0}天{1}小时{2}分钟前", ts.Days, ts.Hours, ts.Minutes);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            try
            {
                string id = dataGridView1["id", index].Value.ToString();

                SMS780E.Storage.Msg msg = daemon.LoadMsgContent(id);
                if (msg == null)
                {
                    MessageBox.Show("读取失败");
                    return;
                }
                MsgReader msgReaderForm = new MsgReader(msg);

                msgReaderForm.ShowDialog();

                BindDataSource();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void tbSearchGo_Click(object sender, EventArgs e)
        {
            BindDataSource(tbSearch.Text);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void btSendMsg_Click(object sender, EventArgs e)
        {
            SendMsg sm = new SendMsg(daemon);
            sm.ShowDialog();
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            daemon.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tsmNewMsgEnabled.Checked)
            {
                tsmNewMsgEnabled.Checked = false;

            }
            else
            {
                tsmNewMsgEnabled.Checked = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MailCfg mailCfg = new MailCfg();
            mailCfg.ShowDialog();
        }

        private void 许可证信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Licences licences = new Licences();
            licences.ShowDialog();
        }

        private void 关于SMS780EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = @"SMS780E短信收发工具 适配合宙Air780E(G)系列LTE Cat.1模块
© 2023 SHIYUKI Software

项目主页：https://github.com/simotsukiyuki/SMS780E
设计开发：霜月雪SimotsukiYuki
官方网站：https://www.shiyuki.com

Version:" + Application.ProductVersion.ToString();
            MessageBox.Show(about, "关于SMS780E");
        }

        private void 清除自动登录信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("将清除自动登录信息。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Properties.Settings.Default.IsSavingLoginCfg = false;
                Properties.Settings.Default.IsAutoLogin = false;
                Properties.Settings.Default.Save();

                MessageBox.Show("已清除自动登录信息，下次登录请重新配置串口信息。", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
