namespace TouchLives.Interfaces
{
    partial class ImgAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImgAlert));
            this.Pan_WinBar = new System.Windows.Forms.Panel();
            this.Icon_Maximize = new System.Windows.Forms.PictureBox();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Icon_Close = new System.Windows.Forms.PictureBox();
            this.LabelImage = new System.Windows.Forms.Label();
            this.PBoxImage = new System.Windows.Forms.PictureBox();
            this.Pan_Image = new System.Windows.Forms.Panel();
            this.Pan_WinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).BeginInit();
            this.Pan_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_WinBar
            // 
            this.Pan_WinBar.BackColor = System.Drawing.Color.Black;
            this.Pan_WinBar.Controls.Add(this.Icon_Maximize);
            this.Pan_WinBar.Controls.Add(this.Icon_Minimize);
            this.Pan_WinBar.Controls.Add(this.Icon_Close);
            this.Pan_WinBar.Controls.Add(this.LabelImage);
            this.Pan_WinBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pan_WinBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_WinBar.Location = new System.Drawing.Point(0, 0);
            this.Pan_WinBar.Name = "Pan_WinBar";
            this.Pan_WinBar.Size = new System.Drawing.Size(800, 35);
            this.Pan_WinBar.TabIndex = 16;
            this.Pan_WinBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pan_WinBar_MouseDown);
            this.Pan_WinBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pan_WinBar_MouseMove);
            this.Pan_WinBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pan_WinBar_MouseUp);
            // 
            // Icon_Maximize
            // 
            this.Icon_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Icon_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Maximize.Image")));
            this.Icon_Maximize.Location = new System.Drawing.Point(739, 4);
            this.Icon_Maximize.Name = "Icon_Maximize";
            this.Icon_Maximize.Size = new System.Drawing.Size(26, 26);
            this.Icon_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Maximize.TabIndex = 16;
            this.Icon_Maximize.TabStop = false;
            this.Icon_Maximize.Click += new System.EventHandler(this.Icon_Maximize_Click);
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Icon_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Minimize.Image")));
            this.Icon_Minimize.Location = new System.Drawing.Point(707, 4);
            this.Icon_Minimize.Name = "Icon_Minimize";
            this.Icon_Minimize.Size = new System.Drawing.Size(26, 26);
            this.Icon_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Minimize.TabIndex = 15;
            this.Icon_Minimize.TabStop = false;
            this.Icon_Minimize.Click += new System.EventHandler(this.Icon_Minimize_Click);
            // 
            // Icon_Close
            // 
            this.Icon_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Close.BackColor = System.Drawing.Color.DarkRed;
            this.Icon_Close.Image = global::TouchLives.Properties.Resources.Close;
            this.Icon_Close.Location = new System.Drawing.Point(771, 4);
            this.Icon_Close.Name = "Icon_Close";
            this.Icon_Close.Size = new System.Drawing.Size(26, 26);
            this.Icon_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Close.TabIndex = 14;
            this.Icon_Close.TabStop = false;
            this.Icon_Close.Click += new System.EventHandler(this.Icon_Close_Click);
            // 
            // LabelImage
            // 
            this.LabelImage.AutoSize = true;
            this.LabelImage.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelImage.ForeColor = System.Drawing.Color.White;
            this.LabelImage.Location = new System.Drawing.Point(6, 7);
            this.LabelImage.Name = "LabelImage";
            this.LabelImage.Size = new System.Drawing.Size(20, 23);
            this.LabelImage.TabIndex = 13;
            this.LabelImage.Text = "0";
            // 
            // PBoxImage
            // 
            this.PBoxImage.BackColor = System.Drawing.Color.Black;
            this.PBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxImage.Location = new System.Drawing.Point(0, 0);
            this.PBoxImage.Name = "PBoxImage";
            this.PBoxImage.Size = new System.Drawing.Size(800, 415);
            this.PBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImage.TabIndex = 17;
            this.PBoxImage.TabStop = false;
            this.PBoxImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PBoxImage_Paint);
            // 
            // Pan_Image
            // 
            this.Pan_Image.Controls.Add(this.PBoxImage);
            this.Pan_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Image.Location = new System.Drawing.Point(0, 35);
            this.Pan_Image.Name = "Pan_Image";
            this.Pan_Image.Size = new System.Drawing.Size(800, 415);
            this.Pan_Image.TabIndex = 18;
            // 
            // ImgAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pan_Image);
            this.Controls.Add(this.Pan_WinBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImgAlert";
            this.Text = "ImgAlert";
            this.Load += new System.EventHandler(this.ImgAlert_Load);
            this.Pan_WinBar.ResumeLayout(false);
            this.Pan_WinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).EndInit();
            this.Pan_Image.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_WinBar;
        private System.Windows.Forms.PictureBox Icon_Maximize;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Icon_Close;
        private System.Windows.Forms.Label LabelImage;
        private System.Windows.Forms.PictureBox PBoxImage;
        private System.Windows.Forms.Panel Pan_Image;
    }
}