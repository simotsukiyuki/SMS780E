namespace SMSFW
{
    partial class BootForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BootForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_com = new System.Windows.Forms.TextBox();
            this.t_data = new System.Windows.Forms.TextBox();
            this.t_br = new System.Windows.Forms.ComboBox();
            this.t_stop = new System.Windows.Forms.ComboBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "本软件需要搭配合宙Air780E模块及对应固件才能使用。\r\n请先配置以下内容，建议配合LutaOS集成开发环境使用。\r\n错误的配置将会导致软件无法正常接收信息。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户串口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "串口波特率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "停止位";
            // 
            // t_com
            // 
            this.t_com.Location = new System.Drawing.Point(221, 190);
            this.t_com.Name = "t_com";
            this.t_com.Size = new System.Drawing.Size(213, 49);
            this.t_com.TabIndex = 6;
            this.t_com.Text = "COM";
            // 
            // t_data
            // 
            this.t_data.Location = new System.Drawing.Point(221, 295);
            this.t_data.Name = "t_data";
            this.t_data.Size = new System.Drawing.Size(213, 49);
            this.t_data.TabIndex = 7;
            this.t_data.Text = "8";
            // 
            // t_br
            // 
            this.t_br.FormattingEnabled = true;
            this.t_br.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "25600",
            "38400",
            "57600",
            "115200",
            "921600"});
            this.t_br.Location = new System.Drawing.Point(221, 245);
            this.t_br.Name = "t_br";
            this.t_br.Size = new System.Drawing.Size(213, 44);
            this.t_br.TabIndex = 8;
            this.t_br.Text = "115200";
            // 
            // t_stop
            // 
            this.t_stop.FormattingEnabled = true;
            this.t_stop.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.t_stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.t_stop.Location = new System.Drawing.Point(221, 351);
            this.t_stop.MaxDropDownItems = 3;
            this.t_stop.Name = "t_stop";
            this.t_stop.Size = new System.Drawing.Size(213, 44);
            this.t_stop.TabIndex = 9;
            this.t_stop.Text = "1";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(734, 341);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(190, 64);
            this.btStart.TabIndex = 10;
            this.btStart.Text = "开启串口";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(734, 270);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(190, 64);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "退出";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbSave
            // 
            this.cbSave.AutoSize = true;
            this.cbSave.Location = new System.Drawing.Point(469, 190);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(277, 41);
            this.cbSave.TabIndex = 12;
            this.cbSave.Text = "保存配置信息";
            this.cbSave.UseVisualStyleBackColor = true;
            // 
            // BootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 434);
            this.Controls.Add(this.cbSave);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.t_stop);
            this.Controls.Add(this.t_br);
            this.Controls.Add(this.t_data);
            this.Controls.Add(this.t_com);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BootForm";
            this.Text = "启动选项";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BootForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_com;
        private System.Windows.Forms.TextBox t_data;
        private System.Windows.Forms.ComboBox t_br;
        private System.Windows.Forms.ComboBox t_stop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.CheckBox cbSave;
    }
}

