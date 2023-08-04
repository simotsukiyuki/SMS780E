using SMS780E.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS780E
{
    public partial class MailCfg : Form
    {
        public MailCfg()
        {
            InitializeComponent();
        }
        private void SaveCfg()
        {
            Properties.Settings.Default.EmailSmtp = smtp.Text;
            Properties.Settings.Default.EmailPort = port.Text;
            Properties.Settings.Default.EmailSsl = rbSSL.Checked;
            Properties.Settings.Default.EmailAccount = account.Text;
            Properties.Settings.Default.EmailPassword = password.Text;
            Properties.Settings.Default.EmailSenderMail = senderMail.Text;
            Properties.Settings.Default.EmailSenderName = senderName.Text;
            Properties.Settings.Default.EmailReceiverMail = receiverMail.Text;
            Properties.Settings.Default.EmailReceiverName = receiverName.Text;

            Properties.Settings.Default.EmailEnabled = cbEnabled.Checked;

            Properties.Settings.Default.Save();
        }

        private void LoadCfg()
        {
            smtp.Text = Properties.Settings.Default.EmailSmtp;
            port.Text = Properties.Settings.Default.EmailPort;
            rbSSL.Checked = Properties.Settings.Default.EmailSsl;
            account.Text = Properties.Settings.Default.EmailAccount;
            password.Text = Properties.Settings.Default.EmailPassword;
            senderMail.Text = Properties.Settings.Default.EmailSenderMail;
            senderName.Text = Properties.Settings.Default.EmailSenderName;
            receiverMail.Text = Properties.Settings.Default.EmailReceiverMail;
            receiverName.Text = Properties.Settings.Default.EmailReceiverName;

            cbEnabled.Checked = Properties.Settings.Default.EmailEnabled;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveCfg();
            this.Close();
        }


        private void btSendTest_Click(object sender, EventArgs e)
        {
            try
            {

                SaveCfg();

                SmtpConfig cfg = new SmtpConfig();
                cfg.host = Properties.Settings.Default.EmailSmtp;
                cfg.port = int.Parse(Properties.Settings.Default.EmailPort);
                cfg.useSsl = Properties.Settings.Default.EmailSsl;
                cfg.username = Properties.Settings.Default.EmailAccount;
                cfg.password = Properties.Settings.Default.EmailPassword;

                MailEntity entity = new MailEntity();
                entity.fromMailAddress = Properties.Settings.Default.EmailSenderMail;
                entity.fromName = Properties.Settings.Default.EmailSenderName;
                entity.toMailAddress = Properties.Settings.Default.EmailReceiverMail;
                entity.toName = Properties.Settings.Default.EmailReceiverName;

                entity.subject = "测试邮件：来自SMS780E短信接收工具";
                entity.body =
                    @"恭喜！当您正确收到这份电子邮件的时候，说明您已经正确配置好了SMS780E短信接收工具的邮件转发功能。
建议您为设置的邮箱发送地址添加白名单以避免邮件系统将转发邮件作为垃圾邮件处理。
邮件发送时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                SMS780E.Email.SendEmail send = new SendEmail(cfg);
                send.Send(entity);

                MessageBox.Show("已发送邮件，请查看您的邮箱。", "发送成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "测试失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MailCfg_Load(object sender, EventArgs e)
        {
            LoadCfg();
        }
    }
}




