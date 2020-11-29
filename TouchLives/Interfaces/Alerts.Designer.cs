namespace TouchLives.Interfaces
{
    partial class Alerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerts));
            this.LabelUID = new System.Windows.Forms.Label();
            this.LabelAID = new System.Windows.Forms.Label();
            this.Pan_WinBar = new System.Windows.Forms.Panel();
            this.LabelTL = new System.Windows.Forms.Label();
            this.Icon_Maximize = new System.Windows.Forms.PictureBox();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Icon_Close = new System.Windows.Forms.PictureBox();
            this.Icon_Title = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pan_WinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUID
            // 
            this.LabelUID.AutoSize = true;
            this.LabelUID.Location = new System.Drawing.Point(12, 45);
            this.LabelUID.Name = "LabelUID";
            this.LabelUID.Size = new System.Drawing.Size(29, 13);
            this.LabelUID.TabIndex = 2;
            this.LabelUID.Text = "UID:";
            // 
            // LabelAID
            // 
            this.LabelAID.AutoSize = true;
            this.LabelAID.Location = new System.Drawing.Point(13, 73);
            this.LabelAID.Name = "LabelAID";
            this.LabelAID.Size = new System.Drawing.Size(28, 13);
            this.LabelAID.TabIndex = 3;
            this.LabelAID.Text = "AID:";
            // 
            // Pan_WinBar
            // 
            this.Pan_WinBar.BackColor = System.Drawing.Color.Black;
            this.Pan_WinBar.Controls.Add(this.LabelTL);
            this.Pan_WinBar.Controls.Add(this.Icon_Maximize);
            this.Pan_WinBar.Controls.Add(this.Icon_Minimize);
            this.Pan_WinBar.Controls.Add(this.Icon_Close);
            this.Pan_WinBar.Controls.Add(this.Icon_Title);
            this.Pan_WinBar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pan_WinBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_WinBar.Location = new System.Drawing.Point(0, 0);
            this.Pan_WinBar.Name = "Pan_WinBar";
            this.Pan_WinBar.Size = new System.Drawing.Size(902, 35);
            this.Pan_WinBar.TabIndex = 6;
            this.Pan_WinBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinBar_MouseDown);
            this.Pan_WinBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinBar_MouseMove);
            this.Pan_WinBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WinBar_MouseUp);
            // 
            // LabelTL
            // 
            this.LabelTL.AutoSize = true;
            this.LabelTL.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTL.ForeColor = System.Drawing.Color.White;
            this.LabelTL.Location = new System.Drawing.Point(33, 7);
            this.LabelTL.Name = "LabelTL";
            this.LabelTL.Size = new System.Drawing.Size(110, 23);
            this.LabelTL.TabIndex = 13;
            this.LabelTL.Text = "Touch Lives";
            // 
            // Icon_Maximize
            // 
            this.Icon_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Icon_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Maximize.Image")));
            this.Icon_Maximize.Location = new System.Drawing.Point(841, 4);
            this.Icon_Maximize.Name = "Icon_Maximize";
            this.Icon_Maximize.Size = new System.Drawing.Size(26, 26);
            this.Icon_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Maximize.TabIndex = 3;
            this.Icon_Maximize.TabStop = false;
            this.Icon_Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Icon_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Minimize.Image")));
            this.Icon_Minimize.Location = new System.Drawing.Point(809, 4);
            this.Icon_Minimize.Name = "Icon_Minimize";
            this.Icon_Minimize.Size = new System.Drawing.Size(26, 26);
            this.Icon_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Minimize.TabIndex = 2;
            this.Icon_Minimize.TabStop = false;
            this.Icon_Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Icon_Close
            // 
            this.Icon_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Close.BackColor = System.Drawing.Color.DarkRed;
            this.Icon_Close.Image = global::TouchLives.Properties.Resources.Close;
            this.Icon_Close.Location = new System.Drawing.Point(873, 4);
            this.Icon_Close.Name = "Icon_Close";
            this.Icon_Close.Size = new System.Drawing.Size(26, 26);
            this.Icon_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Close.TabIndex = 1;
            this.Icon_Close.TabStop = false;
            this.Icon_Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Icon_Title
            // 
            this.Icon_Title.BackColor = System.Drawing.Color.Red;
            this.Icon_Title.Location = new System.Drawing.Point(4, 4);
            this.Icon_Title.Name = "Icon_Title";
            this.Icon_Title.Size = new System.Drawing.Size(26, 26);
            this.Icon_Title.TabIndex = 0;
            this.Icon_Title.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(579, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Alerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pan_WinBar);
            this.Controls.Add(this.LabelAID);
            this.Controls.Add(this.LabelUID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alerts";
            this.Text = "Alerts";
            this.Load += new System.EventHandler(this.Alerts_Load);
            this.Pan_WinBar.ResumeLayout(false);
            this.Pan_WinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelUID;
        private System.Windows.Forms.Label LabelAID;
        private System.Windows.Forms.Panel Pan_WinBar;
        private System.Windows.Forms.Label LabelTL;
        private System.Windows.Forms.PictureBox Icon_Maximize;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Icon_Close;
        private System.Windows.Forms.PictureBox Icon_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}