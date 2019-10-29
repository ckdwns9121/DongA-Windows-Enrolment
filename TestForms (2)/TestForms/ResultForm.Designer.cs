namespace 동아대수강신청도우미
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.webSugang2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webSugang2
            // 
            this.webSugang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSugang2.Location = new System.Drawing.Point(0, 0);
            this.webSugang2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSugang2.Name = "webSugang2";
            this.webSugang2.Size = new System.Drawing.Size(505, 20);
            this.webSugang2.TabIndex = 0;
            this.webSugang2.Url = new System.Uri("http://sugang.donga.ac.kr/SUGANGPRT.aspx", System.UriKind.Absolute);
            this.webSugang2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 0);
            this.Controls.Add(this.webSugang2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.Text = "수강신청 결과조회";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webSugang2;
    }
}