namespace SMSFW
{
    partial class SendMsg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbReceiver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btSend = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btCancel = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人";
            // 
            // tbReceiver
            // 
            this.tbReceiver.Location = new System.Drawing.Point(71, 10);
            this.tbReceiver.Name = "tbReceiver";
            this.tbReceiver.Size = new System.Drawing.Size(371, 21);
            this.tbReceiver.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "信息内容";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(71, 43);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(371, 185);
            this.tbContent.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSend.BorderColor = System.Drawing.Color.Empty;
            this.btSend.BorderSize = 0;
            this.btSend.FlatAppearance.BorderSize = 0;
            this.btSend.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btSend.Location = new System.Drawing.Point(341, 234);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(101, 35);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "发送";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btCancel.BorderColor = System.Drawing.Color.Empty;
            this.btCancel.BorderSize = 0;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btCancel.Location = new System.Drawing.Point(234, 234);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 35);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // SendMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 277);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReceiver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMsg";
            this.Text = "发送信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContent;
        private ApeFree.ApeForms.Core.Controls.SimpleButton btSend;
        private ApeFree.ApeForms.Core.Controls.SimpleButton btCancel;
    }
}