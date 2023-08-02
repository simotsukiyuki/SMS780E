namespace SMSFW
{
    partial class Daemon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daemon));
            this.reconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // reconnectTimer
            // 
            this.reconnectTimer.Interval = 15000;
            this.reconnectTimer.Tick += new System.EventHandler(this.reconnectTimer_Tick);
            // 
            // Daemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Daemon";
            this.Text = "Daemon";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Daemon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer reconnectTimer;
    }
}