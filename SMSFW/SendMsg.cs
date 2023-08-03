using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSFW
{
    public partial class SendMsg : Form
    {
        Daemon daemon;
        public SendMsg(Daemon daemon)
        {
            InitializeComponent();
            this.daemon = daemon;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            daemon.SendMsg(tbReceiver.Text, tbContent.Text);
            MessageBox.Show("已发送");
            this.Close();
        }
    }
}
