namespace Lab8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.iconPictureMain = new FontAwesome.Sharp.IconPictureBox();
            this.RevisarLocalPanel = new System.Windows.Forms.Panel();
            this.IngreseElIdLabel = new System.Windows.Forms.Label();
            this.RevisarLocalListbox = new System.Windows.Forms.ListBox();
            this.BuscarBuston = new FontAwesome.Sharp.IconButton();
            this.RevisarLocal = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AgregarLocalPanel = new System.Windows.Forms.Panel();
            this.Tipodelocal = new FontAwesome.Sharp.IconButton();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.MesasExclusivasComboBox = new System.Windows.Forms.ComboBox();
            this.DefaultLabel = new System.Windows.Forms.Label();
            this.textBoxCrearlocal = new System.Windows.Forms.TextBox();
            this.VerificarLocalButton = new FontAwesome.Sharp.IconButton();
            this.HoraCierreInput = new System.Windows.Forms.TextBox();
            this.HoraCierreLabel = new System.Windows.Forms.Label();
            this.HoraAperturaInput = new System.Windows.Forms.TextBox();
            this.NombreDueñoInput = new System.Windows.Forms.TextBox();
            this.TipodelocalcomboBox = new System.Windows.Forms.ComboBox();
            this.HoraAperturaLabel = new System.Windows.Forms.Label();
            this.CrearLocalDueñoLabel = new System.Windows.Forms.Label();
            this.AgragrlocalTipoTabel = new System.Windows.Forms.Label();
            this.AgragarPanelLabel = new System.Windows.Forms.Label();
            this.VerLocalesPanel = new System.Windows.Forms.Panel();
            this.VerLocalesListListBox = new System.Windows.Forms.ListBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SeeAllLocalButton = new FontAwesome.Sharp.IconButton();
            this.CheckLocalButton = new FontAwesome.Sharp.IconButton();
            this.AgregarLocalButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMain)).BeginInit();
            this.RevisarLocalPanel.SuspendLayout();
            this.AgregarLocalPanel.SuspendLayout();
            this.VerLocalesPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gray;
            this.MainPanel.Controls.Add(this.RevisarLocalPanel);
            this.MainPanel.Controls.Add(this.AgregarLocalPanel);
            this.MainPanel.Controls.Add(this.VerLocalesPanel);
            this.MainPanel.Controls.Add(this.SidePanel);
            this.MainPanel.Controls.Add(this.iconPictureMain);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1057, 601);
            this.MainPanel.TabIndex = 0;
            // 
            // iconPictureMain
            // 
            this.iconPictureMain.BackColor = System.Drawing.Color.Gray;
            this.iconPictureMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureMain.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.iconPictureMain.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureMain.IconSize = 169;
            this.iconPictureMain.Location = new System.Drawing.Point(604, 189);
            this.iconPictureMain.Name = "iconPictureMain";
            this.iconPictureMain.Size = new System.Drawing.Size(169, 169);
            this.iconPictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureMain.TabIndex = 4;
            this.iconPictureMain.TabStop = false;
            // 
            // RevisarLocalPanel
            // 
            this.RevisarLocalPanel.AutoScroll = true;
            this.RevisarLocalPanel.BackColor = System.Drawing.Color.Gray;
            this.RevisarLocalPanel.Controls.Add(this.IngreseElIdLabel);
            this.RevisarLocalPanel.Controls.Add(this.RevisarLocalListbox);
            this.RevisarLocalPanel.Controls.Add(this.BuscarBuston);
            this.RevisarLocalPanel.Controls.Add(this.RevisarLocal);
            this.RevisarLocalPanel.Controls.Add(this.SearchTextBox);
            this.RevisarLocalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisarLocalPanel.Location = new System.Drawing.Point(284, 0);
            this.RevisarLocalPanel.Name = "RevisarLocalPanel";
            this.RevisarLocalPanel.Size = new System.Drawing.Size(773, 601);
            this.RevisarLocalPanel.TabIndex = 3;
            this.RevisarLocalPanel.Visible = false;
            // 
            // IngreseElIdLabel
            // 
            this.IngreseElIdLabel.Location = new System.Drawing.Point(6, 87);
            this.IngreseElIdLabel.Name = "IngreseElIdLabel";
            this.IngreseElIdLabel.Size = new System.Drawing.Size(161, 67);
            this.IngreseElIdLabel.TabIndex = 4;
            this.IngreseElIdLabel.Text = "Ingrese el ID";
            this.IngreseElIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevisarLocalListbox
            // 
            this.RevisarLocalListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RevisarLocalListbox.BackColor = System.Drawing.Color.Silver;
            this.RevisarLocalListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RevisarLocalListbox.FormattingEnabled = true;
            this.RevisarLocalListbox.ItemHeight = 20;
            this.RevisarLocalListbox.Location = new System.Drawing.Point(176, 227);
            this.RevisarLocalListbox.Name = "RevisarLocalListbox";
            this.RevisarLocalListbox.Size = new System.Drawing.Size(489, 342);
            this.RevisarLocalListbox.TabIndex = 3;
            this.RevisarLocalListbox.Visible = false;
            // 
            // BuscarBuston
            // 
            this.BuscarBuston.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarBuston.BackColor = System.Drawing.Color.White;
            this.BuscarBuston.FlatAppearance.BorderSize = 0;
            this.BuscarBuston.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarBuston.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BuscarBuston.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BuscarBuston.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BuscarBuston.IconSize = 36;
            this.BuscarBuston.Location = new System.Drawing.Point(347, 149);
            this.BuscarBuston.Name = "BuscarBuston";
            this.BuscarBuston.Rotation = 0D;
            this.BuscarBuston.Size = new System.Drawing.Size(166, 60);
            this.BuscarBuston.TabIndex = 2;
            this.BuscarBuston.Text = "Buscar";
            this.BuscarBuston.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarBuston.UseVisualStyleBackColor = false;
            this.BuscarBuston.Click += new System.EventHandler(this.BuscarBuston_Click);
            // 
            // RevisarLocal
            // 
            this.RevisarLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RevisarLocal.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisarLocal.Location = new System.Drawing.Point(221, 33);
            this.RevisarLocal.Name = "RevisarLocal";
            this.RevisarLocal.Size = new System.Drawing.Size(386, 56);
            this.RevisarLocal.TabIndex = 1;
            this.RevisarLocal.Text = "Revisar Local";
            this.RevisarLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(173, 107);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(489, 26);
            this.SearchTextBox.TabIndex = 0;
            // 
            // AgregarLocalPanel
            // 
            this.AgregarLocalPanel.AutoScroll = true;
            this.AgregarLocalPanel.BackColor = System.Drawing.Color.Gray;
            this.AgregarLocalPanel.Controls.Add(this.Tipodelocal);
            this.AgregarLocalPanel.Controls.Add(this.IdTextbox);
            this.AgregarLocalPanel.Controls.Add(this.IdLabel);
            this.AgregarLocalPanel.Controls.Add(this.MesasExclusivasComboBox);
            this.AgregarLocalPanel.Controls.Add(this.DefaultLabel);
            this.AgregarLocalPanel.Controls.Add(this.textBoxCrearlocal);
            this.AgregarLocalPanel.Controls.Add(this.VerificarLocalButton);
            this.AgregarLocalPanel.Controls.Add(this.HoraCierreInput);
            this.AgregarLocalPanel.Controls.Add(this.HoraCierreLabel);
            this.AgregarLocalPanel.Controls.Add(this.HoraAperturaInput);
            this.AgregarLocalPanel.Controls.Add(this.NombreDueñoInput);
            this.AgregarLocalPanel.Controls.Add(this.TipodelocalcomboBox);
            this.AgregarLocalPanel.Controls.Add(this.HoraAperturaLabel);
            this.AgregarLocalPanel.Controls.Add(this.CrearLocalDueñoLabel);
            this.AgregarLocalPanel.Controls.Add(this.AgragrlocalTipoTabel);
            this.AgregarLocalPanel.Controls.Add(this.AgragarPanelLabel);
            this.AgregarLocalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgregarLocalPanel.Location = new System.Drawing.Point(284, 0);
            this.AgregarLocalPanel.Name = "AgregarLocalPanel";
            this.AgregarLocalPanel.Size = new System.Drawing.Size(773, 601);
            this.AgregarLocalPanel.TabIndex = 1;
            this.AgregarLocalPanel.Visible = false;
            // 
            // Tipodelocal
            // 
            this.Tipodelocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tipodelocal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Tipodelocal.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Tipodelocal.IconColor = System.Drawing.Color.Red;
            this.Tipodelocal.IconSize = 20;
            this.Tipodelocal.Location = new System.Drawing.Point(347, 139);
            this.Tipodelocal.Name = "Tipodelocal";
            this.Tipodelocal.Rotation = 0D;
            this.Tipodelocal.Size = new System.Drawing.Size(136, 44);
            this.Tipodelocal.TabIndex = 17;
            this.Tipodelocal.Text = "Tipo de local";
            this.Tipodelocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tipodelocal.UseVisualStyleBackColor = true;
            this.Tipodelocal.Click += new System.EventHandler(this.Tipodelocal_Click);
            // 
            // IdTextbox
            // 
            this.IdTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextbox.Location = new System.Drawing.Point(229, 377);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(364, 26);
            this.IdTextbox.TabIndex = 16;
            this.IdTextbox.Visible = false;
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(87, 361);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(101, 59);
            this.IdLabel.TabIndex = 15;
            this.IdLabel.Text = "ID\r\nxx.xxx.xxx";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IdLabel.Visible = false;
            // 
            // MesasExclusivasComboBox
            // 
            this.MesasExclusivasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MesasExclusivasComboBox.FormattingEnabled = true;
            this.MesasExclusivasComboBox.Items.AddRange(new object[] {
            "--Restaurant cuentan mesas exclusivas--",
            "Si",
            "No"});
            this.MesasExclusivasComboBox.Location = new System.Drawing.Point(229, 492);
            this.MesasExclusivasComboBox.Name = "MesasExclusivasComboBox";
            this.MesasExclusivasComboBox.Size = new System.Drawing.Size(365, 28);
            this.MesasExclusivasComboBox.TabIndex = 14;
            this.MesasExclusivasComboBox.Visible = false;
            // 
            // DefaultLabel
            // 
            this.DefaultLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DefaultLabel.Location = new System.Drawing.Point(66, 433);
            this.DefaultLabel.Name = "DefaultLabel";
            this.DefaultLabel.Size = new System.Drawing.Size(157, 26);
            this.DefaultLabel.TabIndex = 12;
            this.DefaultLabel.Text = "label1";
            this.DefaultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DefaultLabel.Visible = false;
            // 
            // textBoxCrearlocal
            // 
            this.textBoxCrearlocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCrearlocal.Location = new System.Drawing.Point(229, 433);
            this.textBoxCrearlocal.Name = "textBoxCrearlocal";
            this.textBoxCrearlocal.Size = new System.Drawing.Size(365, 26);
            this.textBoxCrearlocal.TabIndex = 11;
            this.textBoxCrearlocal.Visible = false;
            // 
            // VerificarLocalButton
            // 
            this.VerificarLocalButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerificarLocalButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.VerificarLocalButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.VerificarLocalButton.IconColor = System.Drawing.Color.Red;
            this.VerificarLocalButton.IconSize = 36;
            this.VerificarLocalButton.Location = new System.Drawing.Point(320, 537);
            this.VerificarLocalButton.Name = "VerificarLocalButton";
            this.VerificarLocalButton.Rotation = 0D;
            this.VerificarLocalButton.Size = new System.Drawing.Size(199, 41);
            this.VerificarLocalButton.TabIndex = 10;
            this.VerificarLocalButton.Text = "Agregar Local";
            this.VerificarLocalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VerificarLocalButton.UseVisualStyleBackColor = true;
            this.VerificarLocalButton.Visible = false;
            this.VerificarLocalButton.Click += new System.EventHandler(this.CrearLocalButton_Click);
            // 
            // HoraCierreInput
            // 
            this.HoraCierreInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraCierreInput.Location = new System.Drawing.Point(229, 325);
            this.HoraCierreInput.Name = "HoraCierreInput";
            this.HoraCierreInput.Size = new System.Drawing.Size(365, 26);
            this.HoraCierreInput.TabIndex = 9;
            this.HoraCierreInput.Visible = false;
            // 
            // HoraCierreLabel
            // 
            this.HoraCierreLabel.Location = new System.Drawing.Point(74, 315);
            this.HoraCierreLabel.Name = "HoraCierreLabel";
            this.HoraCierreLabel.Size = new System.Drawing.Size(128, 36);
            this.HoraCierreLabel.TabIndex = 8;
            this.HoraCierreLabel.Text = "Hora Cierre";
            this.HoraCierreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoraCierreLabel.Visible = false;
            // 
            // HoraAperturaInput
            // 
            this.HoraAperturaInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraAperturaInput.Location = new System.Drawing.Point(229, 276);
            this.HoraAperturaInput.Name = "HoraAperturaInput";
            this.HoraAperturaInput.Size = new System.Drawing.Size(365, 26);
            this.HoraAperturaInput.TabIndex = 7;
            this.HoraAperturaInput.Visible = false;
            // 
            // NombreDueñoInput
            // 
            this.NombreDueñoInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreDueñoInput.Location = new System.Drawing.Point(229, 226);
            this.NombreDueñoInput.Name = "NombreDueñoInput";
            this.NombreDueñoInput.Size = new System.Drawing.Size(365, 26);
            this.NombreDueñoInput.TabIndex = 6;
            this.NombreDueñoInput.Visible = false;
            // 
            // TipodelocalcomboBox
            // 
            this.TipodelocalcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipodelocalcomboBox.FormattingEnabled = true;
            this.TipodelocalcomboBox.Items.AddRange(new object[] {
            "---Selecione un tipo---",
            "Tienda",
            "Restaurante",
            "Cine",
            "Recreacional"});
            this.TipodelocalcomboBox.Location = new System.Drawing.Point(229, 92);
            this.TipodelocalcomboBox.Name = "TipodelocalcomboBox";
            this.TipodelocalcomboBox.Size = new System.Drawing.Size(365, 28);
            this.TipodelocalcomboBox.TabIndex = 5;
            // 
            // HoraAperturaLabel
            // 
            this.HoraAperturaLabel.Location = new System.Drawing.Point(62, 276);
            this.HoraAperturaLabel.Name = "HoraAperturaLabel";
            this.HoraAperturaLabel.Size = new System.Drawing.Size(130, 26);
            this.HoraAperturaLabel.TabIndex = 3;
            this.HoraAperturaLabel.Text = "Hora Apertura\r\n";
            this.HoraAperturaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoraAperturaLabel.Visible = false;
            // 
            // CrearLocalDueñoLabel
            // 
            this.CrearLocalDueñoLabel.Location = new System.Drawing.Point(62, 221);
            this.CrearLocalDueñoLabel.Name = "CrearLocalDueñoLabel";
            this.CrearLocalDueñoLabel.Size = new System.Drawing.Size(137, 31);
            this.CrearLocalDueñoLabel.TabIndex = 2;
            this.CrearLocalDueñoLabel.Text = "Nombre Dueño";
            this.CrearLocalDueñoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CrearLocalDueñoLabel.Visible = false;
            // 
            // AgragrlocalTipoTabel
            // 
            this.AgragrlocalTipoTabel.Location = new System.Drawing.Point(70, 92);
            this.AgragrlocalTipoTabel.Name = "AgragrlocalTipoTabel";
            this.AgragrlocalTipoTabel.Size = new System.Drawing.Size(132, 26);
            this.AgragrlocalTipoTabel.TabIndex = 1;
            this.AgragrlocalTipoTabel.Text = "Tipo de local";
            this.AgragrlocalTipoTabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgragarPanelLabel
            // 
            this.AgragarPanelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgragarPanelLabel.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgragarPanelLabel.Location = new System.Drawing.Point(168, 0);
            this.AgragarPanelLabel.Name = "AgragarPanelLabel";
            this.AgragarPanelLabel.Size = new System.Drawing.Size(451, 80);
            this.AgragarPanelLabel.TabIndex = 0;
            this.AgragarPanelLabel.Text = "Agregar Local";
            this.AgragarPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerLocalesPanel
            // 
            this.VerLocalesPanel.BackColor = System.Drawing.Color.Gray;
            this.VerLocalesPanel.Controls.Add(this.VerLocalesListListBox);
            this.VerLocalesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerLocalesPanel.Location = new System.Drawing.Point(284, 0);
            this.VerLocalesPanel.Name = "VerLocalesPanel";
            this.VerLocalesPanel.Size = new System.Drawing.Size(773, 601);
            this.VerLocalesPanel.TabIndex = 2;
            // 
            // VerLocalesListListBox
            // 
            this.VerLocalesListListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerLocalesListListBox.BackColor = System.Drawing.Color.Silver;
            this.VerLocalesListListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VerLocalesListListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.VerLocalesListListBox.FormattingEnabled = true;
            this.VerLocalesListListBox.ItemHeight = 20;
            this.VerLocalesListListBox.Location = new System.Drawing.Point(66, 27);
            this.VerLocalesListListBox.Name = "VerLocalesListListBox";
            this.VerLocalesListListBox.Size = new System.Drawing.Size(655, 502);
            this.VerLocalesListListBox.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.AutoScroll = true;
            this.SidePanel.BackColor = System.Drawing.Color.Gray;
            this.SidePanel.Controls.Add(this.SeeAllLocalButton);
            this.SidePanel.Controls.Add(this.CheckLocalButton);
            this.SidePanel.Controls.Add(this.AgregarLocalButton);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(284, 601);
            this.SidePanel.TabIndex = 0;
            // 
            // SeeAllLocalButton
            // 
            this.SeeAllLocalButton.BackColor = System.Drawing.Color.White;
            this.SeeAllLocalButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeeAllLocalButton.FlatAppearance.BorderSize = 0;
            this.SeeAllLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SeeAllLocalButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SeeAllLocalButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.SeeAllLocalButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SeeAllLocalButton.IconSize = 30;
            this.SeeAllLocalButton.Location = new System.Drawing.Point(0, 189);
            this.SeeAllLocalButton.Name = "SeeAllLocalButton";
            this.SeeAllLocalButton.Rotation = 0D;
            this.SeeAllLocalButton.Size = new System.Drawing.Size(284, 50);
            this.SeeAllLocalButton.TabIndex = 3;
            this.SeeAllLocalButton.Text = "Ver Locales";
            this.SeeAllLocalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SeeAllLocalButton.UseVisualStyleBackColor = false;
            this.SeeAllLocalButton.Click += new System.EventHandler(this.SeeAllLocalButton_Click);
            // 
            // CheckLocalButton
            // 
            this.CheckLocalButton.BackColor = System.Drawing.Color.White;
            this.CheckLocalButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckLocalButton.FlatAppearance.BorderSize = 0;
            this.CheckLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckLocalButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CheckLocalButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.CheckLocalButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckLocalButton.IconSize = 30;
            this.CheckLocalButton.Location = new System.Drawing.Point(0, 139);
            this.CheckLocalButton.Name = "CheckLocalButton";
            this.CheckLocalButton.Rotation = 0D;
            this.CheckLocalButton.Size = new System.Drawing.Size(284, 50);
            this.CheckLocalButton.TabIndex = 2;
            this.CheckLocalButton.Text = "Revisar Local";
            this.CheckLocalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckLocalButton.UseVisualStyleBackColor = false;
            this.CheckLocalButton.Click += new System.EventHandler(this.CheckLocalButton_Click);
            // 
            // AgregarLocalButton
            // 
            this.AgregarLocalButton.BackColor = System.Drawing.Color.White;
            this.AgregarLocalButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AgregarLocalButton.FlatAppearance.BorderSize = 0;
            this.AgregarLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarLocalButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AgregarLocalButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarLocalButton.IconColor = System.Drawing.Color.Crimson;
            this.AgregarLocalButton.IconSize = 30;
            this.AgregarLocalButton.Location = new System.Drawing.Point(0, 89);
            this.AgregarLocalButton.Name = "AgregarLocalButton";
            this.AgregarLocalButton.Rotation = 0D;
            this.AgregarLocalButton.Size = new System.Drawing.Size(284, 50);
            this.AgregarLocalButton.TabIndex = 1;
            this.AgregarLocalButton.Text = "Agregar Local";
            this.AgregarLocalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarLocalButton.UseVisualStyleBackColor = false;
            this.AgregarLocalButton.Click += new System.EventHandler(this.AgregarLocalButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 89);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconSize = 89;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(284, 89);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1057, 601);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1079, 657);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Comercial Uandes";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureMain)).EndInit();
            this.RevisarLocalPanel.ResumeLayout(false);
            this.RevisarLocalPanel.PerformLayout();
            this.AgregarLocalPanel.ResumeLayout(false);
            this.AgregarLocalPanel.PerformLayout();
            this.VerLocalesPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SidePanel;
        private FontAwesome.Sharp.IconButton SeeAllLocalButton;
        private FontAwesome.Sharp.IconButton CheckLocalButton;
        private FontAwesome.Sharp.IconButton AgregarLocalButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel AgregarLocalPanel;
        private System.Windows.Forms.Label HoraAperturaLabel;
        private System.Windows.Forms.Label CrearLocalDueñoLabel;
        private System.Windows.Forms.Label AgragrlocalTipoTabel;
        private System.Windows.Forms.Label AgragarPanelLabel;
        private System.Windows.Forms.ComboBox TipodelocalcomboBox;
        private System.Windows.Forms.TextBox NombreDueñoInput;
        private System.Windows.Forms.Label HoraCierreLabel;
        private System.Windows.Forms.TextBox HoraAperturaInput;
        private FontAwesome.Sharp.IconButton VerificarLocalButton;
        private System.Windows.Forms.TextBox HoraCierreInput;
        private System.Windows.Forms.Label DefaultLabel;
        private System.Windows.Forms.TextBox textBoxCrearlocal;
        private System.Windows.Forms.ComboBox MesasExclusivasComboBox;
        private System.Windows.Forms.Panel VerLocalesPanel;
        private System.Windows.Forms.ListBox VerLocalesListListBox;
        private System.Windows.Forms.Panel RevisarLocalPanel;
        private System.Windows.Forms.ListBox RevisarLocalListbox;
        private FontAwesome.Sharp.IconButton BuscarBuston;
        private System.Windows.Forms.Label RevisarLocal;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label IdLabel;
        private FontAwesome.Sharp.IconButton Tipodelocal;
        private System.Windows.Forms.Label IngreseElIdLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureMain;
    }
}

