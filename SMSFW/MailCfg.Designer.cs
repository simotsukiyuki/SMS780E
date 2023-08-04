namespace SMS780E
{
    partial class MailCfg
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
            this.smtp = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNotSSL = new System.Windows.Forms.RadioButton();
            this.rbSSL = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.receiverName = new System.Windows.Forms.TextBox();
            this.receiverMail = new System.Windows.Forms.TextBox();
            this.senderName = new System.Windows.Forms.TextBox();
            this.senderMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSave = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btCancel = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btSendTest = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP服务器";
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(87, 20);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(232, 21);
            this.smtp.TabIndex = 1;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(372, 20);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(64, 21);
            this.port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "SSL加密";
            // 
            // rbNotSSL
            // 
            this.rbNotSSL.AutoSize = true;
            this.rbNotSSL.Checked = true;
            this.rbNotSSL.Location = new System.Drawing.Point(87, 50);
            this.rbNotSSL.Name = "rbNotSSL";
            this.rbNotSSL.Size = new System.Drawing.Size(77, 16);
            this.rbNotSSL.TabIndex = 5;
            this.rbNotSSL.TabStop = true;
            this.rbNotSSL.Text = "不使用SSL";
            this.rbNotSSL.UseVisualStyleBackColor = true;
            // 
            // rbSSL
            // 
            this.rbSSL.AutoSize = true;
            this.rbSSL.Location = new System.Drawing.Point(170, 50);
            this.rbSSL.Name = "rbSSL";
            this.rbSSL.Size = new System.Drawing.Size(65, 16);
            this.rbSSL.TabIndex = 6;
            this.rbSSL.Text = "使用SSL";
            this.rbSSL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "账户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "密码";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(87, 20);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(349, 21);
            this.account.TabIndex = 9;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(87, 47);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(349, 21);
            this.password.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smtp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbSSL);
            this.groupBox1.Controls.Add(this.rbNotSSL);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP服务设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.account);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 84);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "登录选项";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.receiverName);
            this.groupBox3.Controls.Add(this.receiverMail);
            this.groupBox3.Controls.Add(this.senderName);
            this.groupBox3.Controls.Add(this.senderMail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 138);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发件设定";
            // 
            // receiverName
            // 
            this.receiverName.Location = new System.Drawing.Point(87, 99);
            this.receiverName.Name = "receiverName";
            this.receiverName.Size = new System.Drawing.Size(349, 21);
            this.receiverName.TabIndex = 18;
            // 
            // receiverMail
            // 
            this.receiverMail.Location = new System.Drawing.Point(87, 72);
            this.receiverMail.Name = "receiverMail";
            this.receiverMail.Size = new System.Drawing.Size(349, 21);
            this.receiverMail.TabIndex = 17;
            // 
            // senderName
            // 
            this.senderName.Location = new System.Drawing.Point(87, 45);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(349, 21);
            this.senderName.TabIndex = 16;
            // 
            // senderMail
            // 
            this.senderMail.Location = new System.Drawing.Point(87, 18);
            this.senderMail.Name = "senderMail";
            this.senderMail.Size = new System.Drawing.Size(349, 21);
            this.senderMail.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "收件人姓名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "发件人姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "收件人邮箱";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "发件人邮箱";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSave.BorderColor = System.Drawing.Color.Empty;
            this.btSave.BorderSize = 0;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btSave.Location = new System.Drawing.Point(12, 351);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 35);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.btCancel.Location = new System.Drawing.Point(123, 351);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 35);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSendTest
            // 
            this.btSendTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btSendTest.BorderColor = System.Drawing.Color.Empty;
            this.btSendTest.BorderSize = 0;
            this.btSendTest.FlatAppearance.BorderSize = 0;
            this.btSendTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btSendTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btSendTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btSendTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendTest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btSendTest.Location = new System.Drawing.Point(349, 351);
            this.btSendTest.Name = "btSendTest";
            this.btSendTest.Size = new System.Drawing.Size(105, 35);
            this.btSendTest.TabIndex = 16;
            this.btSendTest.Text = "发送测试邮件";
            this.btSendTest.UseVisualStyleBackColor = false;
            this.btSendTest.Click += new System.EventHandler(this.btSendTest_Click);
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(12, 12);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(156, 16);
            this.cbEnabled.TabIndex = 17;
            this.cbEnabled.Text = "启用新短信转发邮件功能";
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // MailCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 399);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.btSendTest);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MailCfg";
            this.Text = "邮件转发设置";
            this.Load += new System.EventHandler(this.MailCfg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNotSSL;
        private System.Windows.Forms.RadioButton rbSSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox senderMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox receiverName;
        private System.Windows.Forms.TextBox receiverMail;
        private System.Windows.Forms.TextBox senderName;
        private ApeFree.ApeForms.Core.Controls.SimpleButton btSave;
        private ApeFree.ApeForms.Core.Controls.SimpleButton btCancel;
        private ApeFree.ApeForms.Core.Controls.SimpleButton btSendTest;
        private System.Windows.Forms.CheckBox cbEnabled;
    }
}