namespace 동아대수강신청도우미
{
    partial class ServerTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerTime));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webServerCheck = new System.Windows.Forms.WebBrowser();
            this.serverLogbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webServerCheck
            // 
            this.webServerCheck.Location = new System.Drawing.Point(402, 12);
            this.webServerCheck.MinimumSize = new System.Drawing.Size(20, 20);
            this.webServerCheck.Name = "webServerCheck";
            this.webServerCheck.Size = new System.Drawing.Size(20, 20);
            this.webServerCheck.TabIndex = 1;
            // 
            // serverLogbox
            // 
            this.serverLogbox.BackColor = System.Drawing.SystemColors.Control;
            this.serverLogbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.serverLogbox.FormattingEnabled = true;
            this.serverLogbox.ItemHeight = 18;
            this.serverLogbox.Location = new System.Drawing.Point(11, 12);
            this.serverLogbox.Name = "serverLogbox";
            this.serverLogbox.Size = new System.Drawing.Size(362, 526);
            this.serverLogbox.TabIndex = 0;
            // 
            // ServerTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 552);
            this.Controls.Add(this.serverLogbox);
            this.Controls.Add(this.webServerCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerTime";
            this.RightToLeftLayout = true;
            this.Text = "서버로그";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webServerCheck;
        private System.Windows.Forms.ListBox serverLogbox;
    }
}