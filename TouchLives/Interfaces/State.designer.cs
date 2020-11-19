namespace TouchLives
{
    partial class State
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
            this.WinBarLogin = new System.Windows.Forms.Panel();
            this.LabelTL = new System.Windows.Forms.Label();
            this.LCargando = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CBCity = new System.Windows.Forms.ComboBox();
            this.LCity = new System.Windows.Forms.Label();
            this.CBState = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LSEstado = new System.Windows.Forms.Label();
            this.Icon_Title = new System.Windows.Forms.PictureBox();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Icon_Close = new System.Windows.Forms.PictureBox();
            this.WinBarLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // WinBarLogin
            // 
            this.WinBarLogin.BackColor = System.Drawing.Color.Black;
            this.WinBarLogin.Controls.Add(this.Icon_Title);
            this.WinBarLogin.Controls.Add(this.Icon_Minimize);
            this.WinBarLogin.Controls.Add(this.Icon_Close);
            this.WinBarLogin.Controls.Add(this.LabelTL);
            this.WinBarLogin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.WinBarLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.WinBarLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WinBarLogin.Location = new System.Drawing.Point(0, 0);
            this.WinBarLogin.Name = "WinBarLogin";
            this.WinBarLogin.Size = new System.Drawing.Size(298, 32);
            this.WinBarLogin.TabIndex = 16;
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
            this.LabelTL.TabIndex = 9;
            this.LabelTL.Text = "Touch Lives";
            // 
            // LCargando
            // 
            this.LCargando.AutoSize = true;
            this.LCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LCargando.Location = new System.Drawing.Point(12, 386);
            this.LCargando.Name = "LCargando";
            this.LCargando.Size = new System.Drawing.Size(0, 16);
            this.LCargando.TabIndex = 17;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnAceptar.Location = new System.Drawing.Point(97, 267);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(104, 35);
            this.BtnAceptar.TabIndex = 15;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CBCity
            // 
            this.CBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCity.Enabled = false;
            this.CBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCity.ForeColor = System.Drawing.Color.Black;
            this.CBCity.FormattingEnabled = true;
            this.CBCity.Location = new System.Drawing.Point(72, 197);
            this.CBCity.Name = "CBCity";
            this.CBCity.Size = new System.Drawing.Size(154, 28);
            this.CBCity.Sorted = true;
            this.CBCity.TabIndex = 14;
            // 
            // LCity
            // 
            this.LCity.AutoSize = true;
            this.LCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCity.ForeColor = System.Drawing.Color.White;
            this.LCity.Location = new System.Drawing.Point(70, 174);
            this.LCity.Name = "LCity";
            this.LCity.Size = new System.Drawing.Size(159, 20);
            this.LCity.TabIndex = 13;
            this.LCity.Text = "Municipio/Delegación";
            // 
            // CBState
            // 
            this.CBState.DropDownHeight = 100;
            this.CBState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBState.DropDownWidth = 100;
            this.CBState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBState.ForeColor = System.Drawing.Color.Black;
            this.CBState.IntegralHeight = false;
            this.CBState.ItemHeight = 20;
            this.CBState.Location = new System.Drawing.Point(72, 130);
            this.CBState.Name = "CBState";
            this.CBState.Size = new System.Drawing.Size(154, 28);
            this.CBState.Sorted = true;
            this.CBState.TabIndex = 12;
            this.CBState.SelectedIndexChanged += new System.EventHandler(this.CBState_SelectedIndexChangedAsync);
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.ForeColor = System.Drawing.Color.White;
            this.LEstado.Location = new System.Drawing.Point(119, 107);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(60, 20);
            this.LEstado.TabIndex = 11;
            this.LEstado.Text = "Estado";
            // 
            // LSEstado
            // 
            this.LSEstado.AutoSize = true;
            this.LSEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LSEstado.Location = new System.Drawing.Point(244, 35);
            this.LSEstado.Name = "LSEstado";
            this.LSEstado.Size = new System.Drawing.Size(51, 16);
            this.LSEstado.TabIndex = 18;
            this.LSEstado.Text = "Estado";
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
            this.Icon_Minimize.Image = global::TouchLives.Properties.Resources.clarity_window_min_line;
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
            this.Icon_Close.Image = global::TouchLives.Properties.Resources.codicon_chrome_close;
            this.Icon_Close.Location = new System.Drawing.Point(269, 3);
            this.Icon_Close.Name = "Icon_Close";
            this.Icon_Close.Size = new System.Drawing.Size(26, 26);
            this.Icon_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_Close.TabIndex = 11;
            this.Icon_Close.TabStop = false;
            this.Icon_Close.Click += new System.EventHandler(this.Icon_Close_Click);
            // 
            // State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(298, 411);
            this.Controls.Add(this.LSEstado);
            this.Controls.Add(this.WinBarLogin);
            this.Controls.Add(this.LCargando);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CBCity);
            this.Controls.Add(this.LCity);
            this.Controls.Add(this.CBState);
            this.Controls.Add(this.LEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "State";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State";
            this.Load += new System.EventHandler(this.State_Load);
            this.WinBarLogin.ResumeLayout(false);
            this.WinBarLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WinBarLogin;
        private System.Windows.Forms.PictureBox Icon_Title;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Icon_Close;
        private System.Windows.Forms.Label LabelTL;
        private System.Windows.Forms.Label LCargando;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CBCity;
        private System.Windows.Forms.Label LCity;
        private System.Windows.Forms.ComboBox CBState;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LSEstado;
    }
}