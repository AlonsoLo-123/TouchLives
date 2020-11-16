namespace TouchLives
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaAll = new System.Windows.Forms.DataGridView();
            this.BtnMostrarT = new System.Windows.Forms.Button();
            this.GB_Alert = new System.Windows.Forms.GroupBox();
            this.BtnMostrarH = new System.Windows.Forms.Button();
            this.TablaNot = new System.Windows.Forms.DataGridView();
            this.NombreNot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pan_WinBar = new System.Windows.Forms.Panel();
            this.LabelTL = new System.Windows.Forms.Label();
            this.Icon_Maximize = new System.Windows.Forms.PictureBox();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Icon_Close = new System.Windows.Forms.PictureBox();
            this.Icon_Title = new System.Windows.Forms.PictureBox();
            this.Pan_Tables = new System.Windows.Forms.Panel();
            this.Pan_Maps = new System.Windows.Forms.Panel();
            this.BtnCenter = new System.Windows.Forms.Button();
            this.LMun = new System.Windows.Forms.Label();
            this.GMapAlert = new GMap.NET.WindowsForms.GMapControl();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAll)).BeginInit();
            this.GB_Alert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNot)).BeginInit();
            this.Pan_WinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).BeginInit();
            this.Pan_Tables.SuspendLayout();
            this.Pan_Maps.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaAll
            // 
            this.TablaAll.AllowUserToAddRows = false;
            this.TablaAll.AllowUserToDeleteRows = false;
            this.TablaAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TablaAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Ap_Paterno,
            this.Ap_Materno,
            this.Telefono});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaAll.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaAll.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TablaAll.Location = new System.Drawing.Point(3, 16);
            this.TablaAll.Name = "TablaAll";
            this.TablaAll.ReadOnly = true;
            this.TablaAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.TablaAll.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaAll.Size = new System.Drawing.Size(471, 513);
            this.TablaAll.TabIndex = 0;
            this.TablaAll.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tabla_CellMouseClick);
            // 
            // BtnMostrarT
            // 
            this.BtnMostrarT.BackColor = System.Drawing.Color.Transparent;
            this.BtnMostrarT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarT.Location = new System.Drawing.Point(10, 16);
            this.BtnMostrarT.Name = "BtnMostrarT";
            this.BtnMostrarT.Size = new System.Drawing.Size(104, 37);
            this.BtnMostrarT.TabIndex = 0;
            this.BtnMostrarT.Text = "Mostrar Todo";
            this.BtnMostrarT.UseVisualStyleBackColor = false;
            this.BtnMostrarT.Click += new System.EventHandler(this.MostrarT_Click);
            // 
            // GB_Alert
            // 
            this.GB_Alert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB_Alert.Controls.Add(this.TablaAll);
            this.GB_Alert.ForeColor = System.Drawing.Color.White;
            this.GB_Alert.Location = new System.Drawing.Point(4, 106);
            this.GB_Alert.Name = "GB_Alert";
            this.GB_Alert.Size = new System.Drawing.Size(477, 532);
            this.GB_Alert.TabIndex = 1;
            this.GB_Alert.TabStop = false;
            this.GB_Alert.Text = "Alertas";
            // 
            // BtnMostrarH
            // 
            this.BtnMostrarH.BackColor = System.Drawing.Color.Transparent;
            this.BtnMostrarH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarH.Location = new System.Drawing.Point(10, 63);
            this.BtnMostrarH.Name = "BtnMostrarH";
            this.BtnMostrarH.Size = new System.Drawing.Size(104, 37);
            this.BtnMostrarH.TabIndex = 2;
            this.BtnMostrarH.Text = "Mostrar Hoy";
            this.BtnMostrarH.UseVisualStyleBackColor = false;
            this.BtnMostrarH.Click += new System.EventHandler(this.MostrarH_Click);
            // 
            // TablaNot
            // 
            this.TablaNot.AllowUserToAddRows = false;
            this.TablaNot.AllowUserToDeleteRows = false;
            this.TablaNot.AllowUserToResizeColumns = false;
            this.TablaNot.AllowUserToResizeRows = false;
            this.TablaNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaNot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TablaNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaNot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreNot});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaNot.DefaultCellStyle = dataGridViewCellStyle4;
            this.TablaNot.Location = new System.Drawing.Point(389, 3);
            this.TablaNot.MultiSelect = false;
            this.TablaNot.Name = "TablaNot";
            this.TablaNot.ReadOnly = true;
            this.TablaNot.RowHeadersVisible = false;
            this.TablaNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TablaNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaNot.Size = new System.Drawing.Size(196, 92);
            this.TablaNot.TabIndex = 0;
            // 
            // NombreNot
            // 
            this.NombreNot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreNot.HeaderText = "Notificaciones Entrantes";
            this.NombreNot.Name = "NombreNot";
            this.NombreNot.ReadOnly = true;
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
            this.Pan_WinBar.Size = new System.Drawing.Size(1073, 35);
            this.Pan_WinBar.TabIndex = 5;
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
            this.Icon_Maximize.Image = global::TouchLives.Properties.Resources.feather_maximize_2;
            this.Icon_Maximize.Location = new System.Drawing.Point(1012, 4);
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
            this.Icon_Minimize.Image = global::TouchLives.Properties.Resources.clarity_window_min_line;
            this.Icon_Minimize.Location = new System.Drawing.Point(980, 4);
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
            this.Icon_Close.Image = global::TouchLives.Properties.Resources.codicon_chrome_close;
            this.Icon_Close.Location = new System.Drawing.Point(1044, 4);
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
            this.Icon_Title.Size = new System.Drawing.Size(23, 24);
            this.Icon_Title.TabIndex = 0;
            this.Icon_Title.TabStop = false;
            // 
            // Pan_Tables
            // 
            this.Pan_Tables.Controls.Add(this.GB_Alert);
            this.Pan_Tables.Controls.Add(this.BtnMostrarT);
            this.Pan_Tables.Controls.Add(this.BtnMostrarH);
            this.Pan_Tables.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Tables.Location = new System.Drawing.Point(0, 35);
            this.Pan_Tables.Name = "Pan_Tables";
            this.Pan_Tables.Size = new System.Drawing.Size(485, 638);
            this.Pan_Tables.TabIndex = 7;
            // 
            // Pan_Maps
            // 
            this.Pan_Maps.Controls.Add(this.BtnCenter);
            this.Pan_Maps.Controls.Add(this.LMun);
            this.Pan_Maps.Controls.Add(this.TablaNot);
            this.Pan_Maps.Controls.Add(this.GMapAlert);
            this.Pan_Maps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Maps.Location = new System.Drawing.Point(485, 35);
            this.Pan_Maps.Name = "Pan_Maps";
            this.Pan_Maps.Size = new System.Drawing.Size(588, 638);
            this.Pan_Maps.TabIndex = 8;
            // 
            // BtnCenter
            // 
            this.BtnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCenter.BackColor = System.Drawing.Color.Transparent;
            this.BtnCenter.BackgroundImage = global::TouchLives.Properties.Resources.ic_baseline_gps_fixed;
            this.BtnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCenter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCenter.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCenter.Location = new System.Drawing.Point(552, 602);
            this.BtnCenter.Name = "BtnCenter";
            this.BtnCenter.Size = new System.Drawing.Size(33, 33);
            this.BtnCenter.TabIndex = 9;
            this.BtnCenter.UseVisualStyleBackColor = false;
            this.BtnCenter.Click += new System.EventHandler(this.BtnCenter_Click);
            // 
            // LMun
            // 
            this.LMun.AutoSize = true;
            this.LMun.ForeColor = System.Drawing.Color.White;
            this.LMun.Location = new System.Drawing.Point(3, 3);
            this.LMun.Name = "LMun";
            this.LMun.Size = new System.Drawing.Size(55, 13);
            this.LMun.TabIndex = 7;
            this.LMun.Text = "Municipio:";
            // 
            // GMapAlert
            // 
            this.GMapAlert.Bearing = 0F;
            this.GMapAlert.CanDragMap = true;
            this.GMapAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GMapAlert.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapAlert.GrayScaleMode = false;
            this.GMapAlert.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapAlert.LevelsKeepInMemory = 5;
            this.GMapAlert.Location = new System.Drawing.Point(0, 0);
            this.GMapAlert.MarkersEnabled = true;
            this.GMapAlert.MaxZoom = 2;
            this.GMapAlert.MinZoom = 2;
            this.GMapAlert.MouseWheelZoomEnabled = true;
            this.GMapAlert.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapAlert.Name = "GMapAlert";
            this.GMapAlert.NegativeMode = false;
            this.GMapAlert.PolygonsEnabled = true;
            this.GMapAlert.RetryLoadTile = 0;
            this.GMapAlert.RoutesEnabled = true;
            this.GMapAlert.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapAlert.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapAlert.ShowTileGridLines = false;
            this.GMapAlert.Size = new System.Drawing.Size(588, 638);
            this.GMapAlert.TabIndex = 0;
            this.GMapAlert.Zoom = 0D;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Ap_Materno
            // 
            this.Ap_Materno.HeaderText = "Ap_Materno";
            this.Ap_Materno.Name = "Ap_Materno";
            this.Ap_Materno.ReadOnly = true;
            this.Ap_Materno.Visible = false;
            // 
            // Ap_Paterno
            // 
            this.Ap_Paterno.HeaderText = "Ap_Paterno";
            this.Ap_Paterno.Name = "Ap_Paterno";
            this.Ap_Paterno.ReadOnly = true;
            this.Ap_Paterno.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1073, 673);
            this.Controls.Add(this.Pan_Maps);
            this.Controls.Add(this.Pan_Tables);
            this.Controls.Add(this.Pan_WinBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "TouchLives";
            this.Load += new System.EventHandler(this.TouchLives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaAll)).EndInit();
            this.GB_Alert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaNot)).EndInit();
            this.Pan_WinBar.ResumeLayout(false);
            this.Pan_WinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).EndInit();
            this.Pan_Tables.ResumeLayout(false);
            this.Pan_Maps.ResumeLayout(false);
            this.Pan_Maps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrarT;
        private System.Windows.Forms.GroupBox GB_Alert;
        private System.Windows.Forms.Button BtnMostrarH;
        public System.Windows.Forms.DataGridView TablaAll;
        private System.Windows.Forms.Panel Pan_WinBar;
        private System.Windows.Forms.PictureBox Icon_Close;
        private System.Windows.Forms.PictureBox Icon_Title;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Icon_Maximize;
        private System.Windows.Forms.Panel Pan_Tables;
        private System.Windows.Forms.Panel Pan_Maps;
        public System.Windows.Forms.DataGridView TablaNot;
        private System.Windows.Forms.Label LabelTL;
        private System.Windows.Forms.Label LMun;
        private GMap.NET.WindowsForms.GMapControl GMapAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNot;
        private System.Windows.Forms.Button BtnCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}

