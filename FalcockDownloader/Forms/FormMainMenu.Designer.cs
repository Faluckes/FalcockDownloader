namespace FalcockDownloader
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.PanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMP4Converter = new System.Windows.Forms.Button();
            this.btnMp3Converter = new System.Windows.Forms.Button();
            this.btnAbaout = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Controls.Add(this.btnMP4Converter);
            this.PanelMenu.Controls.Add(this.btnMp3Converter);
            this.PanelMenu.Controls.Add(this.btnAbaout);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(217, 600);
            this.PanelMenu.TabIndex = 2;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 80);
            this.PanelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faluckes Developer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMP4Converter
            // 
            this.btnMP4Converter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnMP4Converter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMP4Converter.FlatAppearance.BorderSize = 0;
            this.btnMP4Converter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMP4Converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMP4Converter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMP4Converter.Image = global::FalcockDownloader.Properties.Resources.Mp4ImagerReal;
            this.btnMP4Converter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMP4Converter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMP4Converter.Location = new System.Drawing.Point(3, 83);
            this.btnMP4Converter.Name = "btnMP4Converter";
            this.btnMP4Converter.Size = new System.Drawing.Size(216, 50);
            this.btnMP4Converter.TabIndex = 1;
            this.btnMP4Converter.Text = "   Mp4 Download";
            this.btnMP4Converter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMP4Converter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMP4Converter.UseVisualStyleBackColor = false;
            this.btnMP4Converter.Click += new System.EventHandler(this.btnMP4Converter_Click);
            // 
            // btnMp3Converter
            // 
            this.btnMp3Converter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnMp3Converter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMp3Converter.FlatAppearance.BorderSize = 0;
            this.btnMp3Converter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMp3Converter.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btnMp3Converter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMp3Converter.Image = global::FalcockDownloader.Properties.Resources.Mp3ImageReal;
            this.btnMp3Converter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMp3Converter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMp3Converter.Location = new System.Drawing.Point(3, 139);
            this.btnMp3Converter.Name = "btnMp3Converter";
            this.btnMp3Converter.Size = new System.Drawing.Size(216, 50);
            this.btnMp3Converter.TabIndex = 2;
            this.btnMp3Converter.Text = "   Mp3 Download";
            this.btnMp3Converter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMp3Converter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMp3Converter.UseVisualStyleBackColor = false;
            this.btnMp3Converter.Click += new System.EventHandler(this.btnMp3Converter_Click);
            // 
            // btnAbaout
            // 
            this.btnAbaout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnAbaout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbaout.FlatAppearance.BorderSize = 0;
            this.btnAbaout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbaout.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.btnAbaout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbaout.Image = global::FalcockDownloader.Properties.Resources.AboutRealImage;
            this.btnAbaout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbaout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAbaout.Location = new System.Drawing.Point(3, 195);
            this.btnAbaout.Name = "btnAbaout";
            this.btnAbaout.Size = new System.Drawing.Size(216, 50);
            this.btnAbaout.TabIndex = 3;
            this.btnAbaout.Text = "   About";
            this.btnAbaout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbaout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbaout.UseVisualStyleBackColor = false;
            this.btnAbaout.Click += new System.EventHandler(this.btnAbaout_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.picExit);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(217, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(836, 27);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FalcockDownloader.Properties.Resources.MinimizeReal;
            this.pictureBox1.Location = new System.Drawing.Point(788, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Image = global::FalcockDownloader.Properties.Resources.cross_out__2_;
            this.picExit.Location = new System.Drawing.Point(810, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(26, 20);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Image = global::FalcockDownloader.Properties.Resources.cross_out__2_;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(217, 27);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(836, 573);
            this.panelDesktop.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1053, 600);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faluckes Downloader";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button btnMP4Converter;
        private System.Windows.Forms.Button btnMp3Converter;
        private System.Windows.Forms.Button btnAbaout;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

