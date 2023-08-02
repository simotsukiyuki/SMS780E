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

namespace SMSFW
{
    public partial class MsgReader : Form
    {
        Msg entity;
        public MsgReader(Msg msgEntity)
        {
            InitializeComponent();
            entity = msgEntity;
        }

        private void MsgReader_Load(object sender, EventArgs e)
        {
            tbFrom.Text = entity.from;
            tbTime.Text = entity.recvTime.ToString();
            tbContent.Text = entity.msgContent;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
