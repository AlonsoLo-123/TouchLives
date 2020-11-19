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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaAll = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Pan_Tables_Alert = new System.Windows.Forms.Panel();
            this.Pan_Left_Middle = new System.Windows.Forms.Panel();
            this.TablaAlert = new System.Windows.Forms.DataGridView();
            this.BtnMostrarT = new System.Windows.Forms.Button();
            this.Pan_Button = new System.Windows.Forms.Panel();
            this.Pan_Left_Bottom = new System.Windows.Forms.Panel();
            this.Pan_Maps = new System.Windows.Forms.Panel();
            this.Pan_Middle = new System.Windows.Forms.Panel();
            this.BtnSat = new System.Windows.Forms.Button();
            this.BtnCenter = new System.Windows.Forms.Button();
            this.LMun = new System.Windows.Forms.Label();
            this.GMapAlert = new GMap.NET.WindowsForms.GMapControl();
            this.LabelAlertas = new System.Windows.Forms.Label();
            this.Pan_Tables_Users = new System.Windows.Forms.Panel();
            this.Activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBarLoading = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNot)).BeginInit();
            this.Pan_WinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).BeginInit();
            this.Pan_Tables.SuspendLayout();
            this.Pan_Tables_Alert.SuspendLayout();
            this.Pan_Left_Middle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAlert)).BeginInit();
            this.Pan_Button.SuspendLayout();
            this.Pan_Maps.SuspendLayout();
            this.Pan_Tables_Users.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaAll
            // 
            this.TablaAll.AllowUserToAddRows = false;
            this.TablaAll.AllowUserToDeleteRows = false;
            this.TablaAll.AllowUserToResizeRows = false;
            this.TablaAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TablaAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.Nombre,
            this.Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaAll.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TablaAll.Location = new System.Drawing.Point(0, 0);
            this.TablaAll.Name = "TablaAll";
            this.TablaAll.ReadOnly = true;
            this.TablaAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaAll.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.TablaAll.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaAll.Size = new System.Drawing.Size(380, 320);
            this.TablaAll.TabIndex = 0;
            this.TablaAll.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tabla_CellMouseClick);
            this.TablaAll.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablaAll_CellMouseDoubleClick);
            // 
            // UID
            // 
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // BtnMostrarH
            // 
            this.BtnMostrarH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMostrarH.BackColor = System.Drawing.Color.Transparent;
            this.BtnMostrarH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarH.Location = new System.Drawing.Point(3, 602);
            this.BtnMostrarH.Name = "BtnMostrarH";
            this.BtnMostrarH.Size = new System.Drawing.Size(82, 31);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaNot.DefaultCellStyle = dataGridViewCellStyle5;
            this.TablaNot.Location = new System.Drawing.Point(541, 3);
            this.TablaNot.MultiSelect = false;
            this.TablaNot.Name = "TablaNot";
            this.TablaNot.ReadOnly = true;
            this.TablaNot.RowHeadersVisible = false;
            this.TablaNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TablaNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaNot.Size = new System.Drawing.Size(149, 92);
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
            this.Icon_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Maximize.Image")));
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
            this.Icon_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Minimize.Image")));
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
            this.Icon_Close.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Close.Image")));
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
            this.Pan_Tables.Controls.Add(this.Pan_Tables_Users);
            this.Pan_Tables.Controls.Add(this.Pan_Tables_Alert);
            this.Pan_Tables.Controls.Add(this.BtnMostrarT);
            this.Pan_Tables.Controls.Add(this.BtnMostrarH);
            this.Pan_Tables.Controls.Add(this.Pan_Button);
            this.Pan_Tables.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Tables.Location = new System.Drawing.Point(0, 35);
            this.Pan_Tables.Name = "Pan_Tables";
            this.Pan_Tables.Size = new System.Drawing.Size(380, 638);
            this.Pan_Tables.TabIndex = 7;
            // 
            // Pan_Tables_Alert
            // 
            this.Pan_Tables_Alert.Controls.Add(this.TablaAlert);
            this.Pan_Tables_Alert.Controls.Add(this.Pan_Left_Middle);
            this.Pan_Tables_Alert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_Tables_Alert.Location = new System.Drawing.Point(0, 320);
            this.Pan_Tables_Alert.Name = "Pan_Tables_Alert";
            this.Pan_Tables_Alert.Size = new System.Drawing.Size(380, 242);
            this.Pan_Tables_Alert.TabIndex = 4;
            // 
            // Pan_Left_Middle
            // 
            this.Pan_Left_Middle.BackColor = System.Drawing.Color.Black;
            this.Pan_Left_Middle.Controls.Add(this.LabelAlertas);
            this.Pan_Left_Middle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_Left_Middle.Location = new System.Drawing.Point(0, 0);
            this.Pan_Left_Middle.Name = "Pan_Left_Middle";
            this.Pan_Left_Middle.Size = new System.Drawing.Size(380, 27);
            this.Pan_Left_Middle.TabIndex = 5;
            // 
            // TablaAlert
            // 
            this.TablaAlert.AllowUserToAddRows = false;
            this.TablaAlert.AllowUserToDeleteRows = false;
            this.TablaAlert.AllowUserToResizeRows = false;
            this.TablaAlert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaAlert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TablaAlert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaAlert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TablaAlert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaAlert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activa,
            this.Fecha,
            this.Colonia,
            this.Long,
            this.Lat});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaAlert.DefaultCellStyle = dataGridViewCellStyle7;
            this.TablaAlert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablaAlert.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TablaAlert.Location = new System.Drawing.Point(0, 26);
            this.TablaAlert.Name = "TablaAlert";
            this.TablaAlert.ReadOnly = true;
            this.TablaAlert.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.TablaAlert.RowHeadersVisible = false;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.TablaAlert.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.TablaAlert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaAlert.Size = new System.Drawing.Size(380, 216);
            this.TablaAlert.TabIndex = 0;
            this.TablaAlert.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablaAlert_CellMouseClick);
            // 
            // BtnMostrarT
            // 
            this.BtnMostrarT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMostrarT.BackColor = System.Drawing.Color.Transparent;
            this.BtnMostrarT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrarT.Location = new System.Drawing.Point(91, 602);
            this.BtnMostrarT.Name = "BtnMostrarT";
            this.BtnMostrarT.Size = new System.Drawing.Size(82, 31);
            this.BtnMostrarT.TabIndex = 0;
            this.BtnMostrarT.Text = "Mostrar Todo";
            this.BtnMostrarT.UseVisualStyleBackColor = false;
            this.BtnMostrarT.Click += new System.EventHandler(this.MostrarT_Click);
            // 
            // Pan_Button
            // 
            this.Pan_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pan_Button.Controls.Add(this.Pan_Left_Bottom);
            this.Pan_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pan_Button.Location = new System.Drawing.Point(0, 562);
            this.Pan_Button.Name = "Pan_Button";
            this.Pan_Button.Size = new System.Drawing.Size(380, 76);
            this.Pan_Button.TabIndex = 3;
            // 
            // Pan_Left_Bottom
            // 
            this.Pan_Left_Bottom.BackColor = System.Drawing.Color.Black;
            this.Pan_Left_Bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_Left_Bottom.Location = new System.Drawing.Point(0, 0);
            this.Pan_Left_Bottom.Name = "Pan_Left_Bottom";
            this.Pan_Left_Bottom.Size = new System.Drawing.Size(380, 3);
            this.Pan_Left_Bottom.TabIndex = 5;
            // 
            // Pan_Maps
            // 
            this.Pan_Maps.Controls.Add(this.Pan_Middle);
            this.Pan_Maps.Controls.Add(this.BtnSat);
            this.Pan_Maps.Controls.Add(this.BtnCenter);
            this.Pan_Maps.Controls.Add(this.LMun);
            this.Pan_Maps.Controls.Add(this.TablaNot);
            this.Pan_Maps.Controls.Add(this.GMapAlert);
            this.Pan_Maps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Maps.Location = new System.Drawing.Point(380, 35);
            this.Pan_Maps.Name = "Pan_Maps";
            this.Pan_Maps.Size = new System.Drawing.Size(693, 638);
            this.Pan_Maps.TabIndex = 8;
            // 
            // Pan_Middle
            // 
            this.Pan_Middle.BackColor = System.Drawing.Color.Black;
            this.Pan_Middle.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_Middle.Location = new System.Drawing.Point(0, 0);
            this.Pan_Middle.Name = "Pan_Middle";
            this.Pan_Middle.Size = new System.Drawing.Size(3, 638);
            this.Pan_Middle.TabIndex = 10;
            // 
            // BtnSat
            // 
            this.BtnSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSat.FlatAppearance.BorderSize = 2;
            this.BtnSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSat.ForeColor = System.Drawing.Color.White;
            this.BtnSat.Image = global::TouchLives.Properties.Resources.Group;
            this.BtnSat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSat.Location = new System.Drawing.Point(559, 602);
            this.BtnSat.Name = "BtnSat";
            this.BtnSat.Size = new System.Drawing.Size(92, 33);
            this.BtnSat.TabIndex = 3;
            this.BtnSat.Text = "Satélite";
            this.BtnSat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSat.UseVisualStyleBackColor = true;
            this.BtnSat.Click += new System.EventHandler(this.BtnSat_Click);
            // 
            // BtnCenter
            // 
            this.BtnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCenter.BackColor = System.Drawing.Color.Transparent;
            this.BtnCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCenter.BackgroundImage")));
            this.BtnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCenter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCenter.FlatAppearance.BorderSize = 2;
            this.BtnCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCenter.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCenter.Location = new System.Drawing.Point(657, 602);
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
            this.LMun.Location = new System.Drawing.Point(6, 3);
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
            this.GMapAlert.Size = new System.Drawing.Size(693, 638);
            this.GMapAlert.TabIndex = 0;
            this.GMapAlert.Zoom = 0D;
            // 
            // LabelAlertas
            // 
            this.LabelAlertas.AutoSize = true;
            this.LabelAlertas.ForeColor = System.Drawing.Color.White;
            this.LabelAlertas.Location = new System.Drawing.Point(3, 6);
            this.LabelAlertas.Name = "LabelAlertas";
            this.LabelAlertas.Size = new System.Drawing.Size(60, 13);
            this.LabelAlertas.TabIndex = 0;
            this.LabelAlertas.Text = "Alertas de: ";
            // 
            // Pan_Tables_Users
            // 
            this.Pan_Tables_Users.Controls.Add(this.PBarLoading);
            this.Pan_Tables_Users.Controls.Add(this.TablaAll);
            this.Pan_Tables_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pan_Tables_Users.Location = new System.Drawing.Point(0, 0);
            this.Pan_Tables_Users.Name = "Pan_Tables_Users";
            this.Pan_Tables_Users.Size = new System.Drawing.Size(380, 320);
            this.Pan_Tables_Users.TabIndex = 7;
            // 
            // Activa
            // 
            this.Activa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Activa.Frozen = true;
            this.Activa.HeaderText = "Activa";
            this.Activa.Name = "Activa";
            this.Activa.ReadOnly = true;
            this.Activa.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Colonia
            // 
            this.Colonia.HeaderText = "Colonia";
            this.Colonia.Name = "Colonia";
            this.Colonia.ReadOnly = true;
            // 
            // Long
            // 
            this.Long.HeaderText = "Long";
            this.Long.Name = "Long";
            this.Long.ReadOnly = true;
            this.Long.Visible = false;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            this.Lat.Visible = false;
            // 
            // PBarLoading
            // 
            this.PBarLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBarLoading.Location = new System.Drawing.Point(0, 310);
            this.PBarLoading.Name = "PBarLoading";
            this.PBarLoading.Size = new System.Drawing.Size(380, 10);
            this.PBarLoading.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.TablaNot)).EndInit();
            this.Pan_WinBar.ResumeLayout(false);
            this.Pan_WinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Title)).EndInit();
            this.Pan_Tables.ResumeLayout(false);
            this.Pan_Tables_Alert.ResumeLayout(false);
            this.Pan_Left_Middle.ResumeLayout(false);
            this.Pan_Left_Middle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaAlert)).EndInit();
            this.Pan_Button.ResumeLayout(false);
            this.Pan_Maps.ResumeLayout(false);
            this.Pan_Maps.PerformLayout();
            this.Pan_Tables_Users.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button BtnSat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button BtnMostrarT;
        public System.Windows.Forms.DataGridView TablaAlert;
        private System.Windows.Forms.Panel Pan_Button;
        private System.Windows.Forms.Panel Pan_Middle;
        private System.Windows.Forms.Panel Pan_Left_Bottom;
        private System.Windows.Forms.Panel Pan_Tables_Alert;
        private System.Windows.Forms.Panel Pan_Left_Middle;
        private System.Windows.Forms.Label LabelAlertas;
        private System.Windows.Forms.Panel Pan_Tables_Users;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.ProgressBar PBarLoading;
    }
}

