namespace SMS780E
{
    partial class MsgReader
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发件人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "接收时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "信息内容";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(64, 14);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.ReadOnly = true;
            this.tbFrom.Size = new System.Drawing.Size(249, 21);
            this.tbFrom.TabIndex = 3;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(64, 36);
            this.tbTime.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(249, 21);
            this.tbTime.TabIndex = 4;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(64, 60);
            this.tbContent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.Size = new System.Drawing.Size(249, 100);
            this.tbContent.TabIndex = 5;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(255, 165);
            this.btClose.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(55, 21);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "关闭";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // MsgReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 197);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgReader";
            this.Text = "查看消息详细信息";
            this.Load += new System.EventHandler(this.MsgReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btClose;
    }
}