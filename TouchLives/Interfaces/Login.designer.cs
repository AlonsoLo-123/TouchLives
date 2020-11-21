namespace TouchLives
{
    partial class Login
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.WinBarLogin = new System.Windows.Forms.Panel();
            this.LabelTL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LStateCity = new System.Windows.Forms.Label();
            this.LCargando = new System.Windows.Forms.Label();
            this.Icon_Title = new System.Windows.Forms.PictureBox();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Icon_Close = new System.Windows.Forms.PictureBox();
            this.WinBarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TBUser
            // 
            this.TBUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUser.ForeColor = System.Drawing.Color.White;
            this.TBUser.Location = new System.Drawing.Point(76, 130);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(145, 19);
            this.TBUser.TabIndex = 2;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(76, 197);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(145, 19);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // BtnEnter
            // 
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnEnter.Location = new System.Drawing.Point(97, 267);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(104, 35);
            this.BtnEnter.TabIndex = 8;
            this.BtnEnter.Text = "ENTRAR";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // WinBarLogin
            // 
            this.WinBarLogin.BackColor = System.Drawing.Color.Black;
            this.WinBarLogin.Controls.Add(this.LabelTL);
            this.WinBarLogin.Controls.Add(this.Icon_Title);
            this.WinBarLogin.Controls.Add(this.Icon_Minimize);
            this.WinBarLogin.Controls.Add(this.Icon_Close);
            this.WinBarLogin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.WinBarLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.WinBarLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WinBarLogin.Location = new System.Drawing.Point(0, 0);
            this.WinBarLogin.Name = "WinBarLogin";
            this.WinBarLogin.Size = new System.Drawing.Size(298, 32);
            this.WinBarLogin.TabIndex = 10;
            this.WinBarLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinBarLogin_MouseDown);
            this.WinBarLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinBarLogin_MouseMove);
            this.WinBarLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WinBarLogin_MouseUp);
            // 
            // LabelTL
            // 
            this.LabelTL.AutoSize = true;
            this.LabelTL.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTL.ForeColor = System.Drawing.Color.White;
            this.LabelTL.Location = new System.Drawing.Point(32, 8);
            this.LabelTL.Name = "LabelTL";
            this.LabelTL.Size = new System.Drawing.Size(93, 19);
            this.LabelTL.TabIndex = 13;
            this.LabelTL.Text = "Touch Lives";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(254, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login";
            // 
            // BtnConfig
            // 
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnConfig.Location = new System.Drawing.Point(3, 385);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(82, 23);
            this.BtnConfig.TabIndex = 11;
            this.BtnConfig.Text = "Configuración";
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(73, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(73, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "________________________";
            // 
            // LStateCity
            // 
            this.LStateCity.AutoSize = true;
            this.LStateCity.ForeColor = System.Drawing.Color.Snow;
            this.LStateCity.Location = new System.Drawing.Point(3, 35);
            this.LStateCity.Name = "LStateCity";
            this.LStateCity.Size = new System.Drawing.Size(55, 26);
            this.LStateCity.TabIndex = 13;
            this.LStateCity.Text = "Estado:\r\nMunicipio:";
            // 
            // LCargando
            // 
            this.LCargando.AutoSize = true;
            this.LCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LCargando.Location = new System.Drawing.Point(89, 323);
            this.LCargando.Name = "LCargando";
            this.LCargando.Size = new System.Drawing.Size(0, 16);
            this.LCargando.TabIndex = 18;
            // 
            // Icon_Title
            // 
            this.Icon_Title.BackColor = System.Drawing.Color.Red;
            this.Icon_Title.Location = new System.Drawing.Point(3, 3);
            this.Icon_Title.Name = "Icon_Title";
            this.Icon_Title.Size = new System.Drawing.Size(26, 26);
            this.Icon_Title.TabIndex = 11;
            this.Icon_Title.TabStop = false;
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Icon_Minimize.Image = global::TouchLives.Properties.Resources.Minimize;
            this.Icon_Minimize.Location = new System.Drawing.Point(237, 3);
            this.Icon_Minimize.Name = "Icon_Minimize";
            this.Icon_Minimize.Size = new System.Drawing.Size(26, 26);
            this.Icon_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Minimize.TabIndex = 12;
            this.Icon_Minimize.TabStop = false;
            this.Icon_Minimize.Click += new System.EventHandler(this.Icon_Minimize_Click);
            // 
            // Icon_Close
            // 
            this.Icon_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon_Close.BackColor = System.Drawing.Color.DarkRed;
            this.Icon_Close.Image = global::TouchLives.Properties.Resources.Close;
            this.Icon_Close.Location = new System.Drawing.Point(269, 3);
            this.Icon_Close.Name = "Icon_Close";
            this.Icon_Close.Size = new System.Drawing.Size(26, 26);
            this.Icon_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Close.TabIndex = 11;
            this.Icon_Close.TabStop = false;
            this.Icon_Close.Click += new System.EventHandler(this.Icon_Close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(298, 411);
            this.Controls.Add(this.LCargando);
            this.Controls.Add(this.LStateCity);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WinBarLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.WinBarLogin.ResumeLayout(false);
            this.WinBarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Panel WinBarLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Icon_Close;
        private System.Windows.Forms.PictureBox Icon_Title;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTL;
        private System.Windows.Forms.Label LStateCity;
        private System.Windows.Forms.Label LCargando;
    }
}