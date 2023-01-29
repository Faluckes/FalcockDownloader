namespace FalcockDownloader.Forms
{
    partial class MP4Download
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
            this.pnlUrl = new System.Windows.Forms.Panel();
            this.lblStatusDownload = new System.Windows.Forms.Label();
            this.picEnter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.youtubePlayer = new System.Windows.Forms.WebBrowser();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.pnlUrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnter)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUrl
            // 
            this.pnlUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.pnlUrl.Controls.Add(this.lblPorcent);
            this.pnlUrl.Controls.Add(this.loadBar);
            this.pnlUrl.Controls.Add(this.lblStatusDownload);
            this.pnlUrl.Controls.Add(this.picEnter);
            this.pnlUrl.Controls.Add(this.label1);
            this.pnlUrl.Controls.Add(this.btnDownload);
            this.pnlUrl.Controls.Add(this.txtBoxURL);
            this.pnlUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUrl.Location = new System.Drawing.Point(0, 0);
            this.pnlUrl.Name = "pnlUrl";
            this.pnlUrl.Size = new System.Drawing.Size(704, 145);
            this.pnlUrl.TabIndex = 0;
            // 
            // lblStatusDownload
            // 
            this.lblStatusDownload.AutoSize = true;
            this.lblStatusDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDownload.ForeColor = System.Drawing.Color.White;
            this.lblStatusDownload.Location = new System.Drawing.Point(3, 87);
            this.lblStatusDownload.Name = "lblStatusDownload";
            this.lblStatusDownload.Size = new System.Drawing.Size(87, 20);
            this.lblStatusDownload.TabIndex = 5;
            this.lblStatusDownload.Text = "Baixando...";
            // 
            // picEnter
            // 
            this.picEnter.Image = global::FalcockDownloader.Properties.Resources.EnterIncon;
            this.picEnter.Location = new System.Drawing.Point(624, 30);
            this.picEnter.Name = "picEnter";
            this.picEnter.Size = new System.Drawing.Size(55, 36);
            this.picEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEnter.TabIndex = 4;
            this.picEnter.TabStop = false;
            this.picEnter.Click += new System.EventHandler(this.picEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(300, 83);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(106, 31);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxURL.Location = new System.Drawing.Point(91, 38);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(527, 19);
            this.txtBoxURL.TabIndex = 0;
            this.txtBoxURL.TextChanged += new System.EventHandler(this.txtBoxURL_TextChanged);
            this.txtBoxURL.Enter += new System.EventHandler(this.txtBoxURL_Enter);
            this.txtBoxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxURL_KeyDown);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pnlBottom.Controls.Add(this.youtubePlayer);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 145);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(704, 316);
            this.pnlBottom.TabIndex = 1;
            // 
            // youtubePlayer
            // 
            this.youtubePlayer.Location = new System.Drawing.Point(91, 6);
            this.youtubePlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.youtubePlayer.Name = "youtubePlayer";
            this.youtubePlayer.ScrollBarsEnabled = false;
            this.youtubePlayer.Size = new System.Drawing.Size(527, 298);
            this.youtubePlayer.TabIndex = 5;
            this.youtubePlayer.Visible = false;
            // 
            // loadBar
            // 
            this.loadBar.Location = new System.Drawing.Point(12, 126);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(680, 13);
            this.loadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadBar.TabIndex = 6;
            // 
            // lblPorcent
            // 
            this.lblPorcent.AutoSize = true;
            this.lblPorcent.ForeColor = System.Drawing.Color.White;
            this.lblPorcent.Location = new System.Drawing.Point(12, 110);
            this.lblPorcent.Name = "lblPorcent";
            this.lblPorcent.Size = new System.Drawing.Size(0, 13);
            this.lblPorcent.TabIndex = 7;
            // 
            // MP4Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlUrl);
            this.Name = "MP4Download";
            this.Text = "Download MP4";
            this.Load += new System.EventHandler(this.MP4Download_Load);
            this.pnlUrl.ResumeLayout(false);
            this.pnlUrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnter)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUrl;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.WebBrowser youtubePlayer;
        private System.Windows.Forms.PictureBox picEnter;
        private System.Windows.Forms.Label lblStatusDownload;
        private System.Windows.Forms.ProgressBar loadBar;
        private System.Windows.Forms.Label lblPorcent;
    }
}