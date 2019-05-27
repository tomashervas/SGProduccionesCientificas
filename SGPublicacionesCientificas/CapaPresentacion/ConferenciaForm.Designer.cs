namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class ConferenciaForm
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
            this.components = new System.ComponentModel.Container();
            this.CalidadBoton = new System.Windows.Forms.Button();
            this.AñadirAutor = new System.Windows.Forms.Button();
            this.dataGridAutores = new System.Windows.Forms.DataGridView();
            this.IDautores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAutoresPublicacion = new System.Windows.Forms.DataGridView();
            this.autoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarAutorBoton = new System.Windows.Forms.Button();
            this.BorrarBoton = new System.Windows.Forms.Button();
            this.guardarBoton = new System.Windows.Forms.Button();
            this.FechaVencimiento = new System.Windows.Forms.Label();
            this.cuantia = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.textPaginas = new System.Windows.Forms.TextBox();
            this.textAño = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.dataGridConferencia = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreConferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textCitas = new System.Windows.Forms.TextBox();
            this.textDoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorAño = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPaginas = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCitas = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.CalidadLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresPublicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // CalidadBoton
            // 
            this.CalidadBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.CalidadBoton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalidadBoton.Location = new System.Drawing.Point(14, 449);
            this.CalidadBoton.Name = "CalidadBoton";
            this.CalidadBoton.Size = new System.Drawing.Size(75, 31);
            this.CalidadBoton.TabIndex = 38;
            this.CalidadBoton.Text = "Calidad";
            this.CalidadBoton.UseVisualStyleBackColor = false;
            this.CalidadBoton.Click += new System.EventHandler(this.CalidadBoton_Click);
            // 
            // AñadirAutor
            // 
            this.AñadirAutor.Location = new System.Drawing.Point(213, 351);
            this.AñadirAutor.Name = "AñadirAutor";
            this.AñadirAutor.Size = new System.Drawing.Size(25, 23);
            this.AñadirAutor.TabIndex = 37;
            this.AñadirAutor.Text = "<";
            this.AñadirAutor.UseVisualStyleBackColor = true;
            this.AñadirAutor.Click += new System.EventHandler(this.AñadirAutor_Click);
            // 
            // dataGridAutores
            // 
            this.dataGridAutores.AllowUserToAddRows = false;
            this.dataGridAutores.AllowUserToDeleteRows = false;
            this.dataGridAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridAutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.dataGridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDautores,
            this.NombreAutores,
            this.ApellidoAutores});
            this.dataGridAutores.Location = new System.Drawing.Point(244, 281);
            this.dataGridAutores.MultiSelect = false;
            this.dataGridAutores.Name = "dataGridAutores";
            this.dataGridAutores.ReadOnly = true;
            this.dataGridAutores.RowHeadersVisible = false;
            this.dataGridAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutores.Size = new System.Drawing.Size(189, 161);
            this.dataGridAutores.TabIndex = 36;
            this.dataGridAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAutores_CellClick);
            // 
            // IDautores
            // 
            this.IDautores.HeaderText = "ID";
            this.IDautores.Name = "IDautores";
            this.IDautores.ReadOnly = true;
            this.IDautores.Width = 43;
            // 
            // NombreAutores
            // 
            this.NombreAutores.HeaderText = "Nombre";
            this.NombreAutores.Name = "NombreAutores";
            this.NombreAutores.ReadOnly = true;
            this.NombreAutores.Width = 69;
            // 
            // ApellidoAutores
            // 
            this.ApellidoAutores.HeaderText = "Apelido";
            this.ApellidoAutores.Name = "ApellidoAutores";
            this.ApellidoAutores.ReadOnly = true;
            this.ApellidoAutores.Width = 67;
            // 
            // dataGridAutoresPublicacion
            // 
            this.dataGridAutoresPublicacion.AllowUserToAddRows = false;
            this.dataGridAutoresPublicacion.AllowUserToDeleteRows = false;
            this.dataGridAutoresPublicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridAutoresPublicacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.dataGridAutoresPublicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutoresPublicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoID,
            this.Nombre,
            this.Apellido});
            this.dataGridAutoresPublicacion.Location = new System.Drawing.Point(14, 281);
            this.dataGridAutoresPublicacion.MultiSelect = false;
            this.dataGridAutoresPublicacion.Name = "dataGridAutoresPublicacion";
            this.dataGridAutoresPublicacion.ReadOnly = true;
            this.dataGridAutoresPublicacion.RowHeadersVisible = false;
            this.dataGridAutoresPublicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutoresPublicacion.Size = new System.Drawing.Size(193, 161);
            this.dataGridAutoresPublicacion.TabIndex = 35;
            // 
            // autoID
            // 
            this.autoID.HeaderText = "ID";
            this.autoID.Name = "autoID";
            this.autoID.ReadOnly = true;
            this.autoID.Width = 43;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 69;
            // 
            // EliminarAutorBoton
            // 
            this.EliminarAutorBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.EliminarAutorBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarAutorBoton.Location = new System.Drawing.Point(259, 741);
            this.EliminarAutorBoton.Name = "EliminarAutorBoton";
            this.EliminarAutorBoton.Size = new System.Drawing.Size(115, 32);
            this.EliminarAutorBoton.TabIndex = 31;
            this.EliminarAutorBoton.Text = "Eliminar";
            this.EliminarAutorBoton.UseVisualStyleBackColor = false;
            this.EliminarAutorBoton.Click += new System.EventHandler(this.EliminarAutorBoton_Click);
            // 
            // BorrarBoton
            // 
            this.BorrarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.BorrarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBoton.Location = new System.Drawing.Point(120, 741);
            this.BorrarBoton.Name = "BorrarBoton";
            this.BorrarBoton.Size = new System.Drawing.Size(133, 32);
            this.BorrarBoton.TabIndex = 32;
            this.BorrarBoton.Text = "Borrar Formulario";
            this.BorrarBoton.UseVisualStyleBackColor = false;
            this.BorrarBoton.Click += new System.EventHandler(this.BorrarBoton_Click);
            // 
            // guardarBoton
            // 
            this.guardarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.guardarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBoton.Location = new System.Drawing.Point(14, 741);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(100, 32);
            this.guardarBoton.TabIndex = 33;
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.UseVisualStyleBackColor = false;
            this.guardarBoton.Click += new System.EventHandler(this.guardarBoton_Click);
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.AutoSize = true;
            this.FechaVencimiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimiento.Location = new System.Drawing.Point(11, 583);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(61, 17);
            this.FechaVencimiento.TabIndex = 25;
            this.FechaVencimiento.Text = "Nº Citas";
            // 
            // cuantia
            // 
            this.cuantia.AutoSize = true;
            this.cuantia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuantia.Location = new System.Drawing.Point(11, 552);
            this.cuantia.Name = "cuantia";
            this.cuantia.Size = new System.Drawing.Size(80, 17);
            this.cuantia.TabIndex = 26;
            this.cuantia.Text = "Nº Páginas";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Año.Location = new System.Drawing.Point(11, 521);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(33, 17);
            this.Año.TabIndex = 27;
            this.Año.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Todos los autores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Autores patente";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(11, 490);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(43, 17);
            this.Titulo.TabIndex = 30;
            this.Titulo.Text = "Título";
            // 
            // textPaginas
            // 
            this.textPaginas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPaginas.Location = new System.Drawing.Point(203, 552);
            this.textPaginas.Name = "textPaginas";
            this.textPaginas.Size = new System.Drawing.Size(230, 25);
            this.textPaginas.TabIndex = 22;
            this.textPaginas.Validating += new System.ComponentModel.CancelEventHandler(this.textPaginas_Validating);
            // 
            // textAño
            // 
            this.textAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textAño.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAño.Location = new System.Drawing.Point(203, 521);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(230, 25);
            this.textAño.TabIndex = 23;
            this.textAño.Validating += new System.ComponentModel.CancelEventHandler(this.textAño_Validating);
            // 
            // textTitulo
            // 
            this.textTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.Location = new System.Drawing.Point(203, 490);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(230, 25);
            this.textTitulo.TabIndex = 24;
            // 
            // dataGridConferencia
            // 
            this.dataGridConferencia.AllowUserToAddRows = false;
            this.dataGridConferencia.AllowUserToDeleteRows = false;
            this.dataGridConferencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridConferencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.dataGridConferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConferencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreTitulo,
            this.NombreAño,
            this.paginas,
            this.citas,
            this.doi,
            this.nombreConferencia,
            this.lugar,
            this.categoria});
            this.dataGridConferencia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridConferencia.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridConferencia.Location = new System.Drawing.Point(11, 15);
            this.dataGridConferencia.MultiSelect = false;
            this.dataGridConferencia.Name = "dataGridConferencia";
            this.dataGridConferencia.ReadOnly = true;
            this.dataGridConferencia.RowHeadersVisible = false;
            this.dataGridConferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConferencia.Size = new System.Drawing.Size(422, 229);
            this.dataGridConferencia.TabIndex = 21;
            this.dataGridConferencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConferencia_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // NombreTitulo
            // 
            this.NombreTitulo.HeaderText = "Titulo";
            this.NombreTitulo.Name = "NombreTitulo";
            this.NombreTitulo.ReadOnly = true;
            this.NombreTitulo.Width = 58;
            // 
            // NombreAño
            // 
            this.NombreAño.HeaderText = "Año";
            this.NombreAño.Name = "NombreAño";
            this.NombreAño.ReadOnly = true;
            this.NombreAño.Width = 51;
            // 
            // paginas
            // 
            this.paginas.HeaderText = "Paginas";
            this.paginas.Name = "paginas";
            this.paginas.ReadOnly = true;
            this.paginas.Width = 70;
            // 
            // citas
            // 
            this.citas.HeaderText = "Citas";
            this.citas.Name = "citas";
            this.citas.ReadOnly = true;
            this.citas.Width = 55;
            // 
            // doi
            // 
            this.doi.HeaderText = "DOI";
            this.doi.Name = "doi";
            this.doi.ReadOnly = true;
            this.doi.Width = 51;
            // 
            // nombreConferencia
            // 
            this.nombreConferencia.HeaderText = "Nombre";
            this.nombreConferencia.Name = "nombreConferencia";
            this.nombreConferencia.ReadOnly = true;
            this.nombreConferencia.Width = 69;
            // 
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            this.lugar.Width = 59;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 77;
            // 
            // textCitas
            // 
            this.textCitas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCitas.Location = new System.Drawing.Point(202, 583);
            this.textCitas.Name = "textCitas";
            this.textCitas.Size = new System.Drawing.Size(230, 25);
            this.textCitas.TabIndex = 22;
            this.textCitas.Validating += new System.ComponentModel.CancelEventHandler(this.textCitas_Validating);
            // 
            // textDoi
            // 
            this.textDoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDoi.Location = new System.Drawing.Point(202, 614);
            this.textDoi.Name = "textDoi";
            this.textDoi.Size = new System.Drawing.Size(230, 25);
            this.textDoi.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "DOI";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(202, 645);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(230, 25);
            this.textNombre.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nombre Conferencia";
            // 
            // textLugar
            // 
            this.textLugar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLugar.Location = new System.Drawing.Point(202, 676);
            this.textLugar.Name = "textLugar";
            this.textLugar.Size = new System.Drawing.Size(230, 25);
            this.textLugar.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 676);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lugar";
            // 
            // textCategoria
            // 
            this.textCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategoria.Location = new System.Drawing.Point(202, 707);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(230, 25);
            this.textCategoria.TabIndex = 22;
            this.textCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.textCategoria_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 707);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Categoria";
            // 
            // errorAño
            // 
            this.errorAño.ContainerControl = this;
            // 
            // errorPaginas
            // 
            this.errorPaginas.ContainerControl = this;
            // 
            // errorCitas
            // 
            this.errorCitas.ContainerControl = this;
            // 
            // errorCategoria
            // 
            this.errorCategoria.ContainerControl = this;
            // 
            // CalidadLbl
            // 
            this.CalidadLbl.AutoSize = true;
            this.CalidadLbl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalidadLbl.Location = new System.Drawing.Point(101, 453);
            this.CalidadLbl.Name = "CalidadLbl";
            this.CalidadLbl.Size = new System.Drawing.Size(20, 22);
            this.CalidadLbl.TabIndex = 39;
            this.CalidadLbl.Text = "_";
            // 
            // ConferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(444, 785);
            this.Controls.Add(this.CalidadLbl);
            this.Controls.Add(this.CalidadBoton);
            this.Controls.Add(this.AñadirAutor);
            this.Controls.Add(this.dataGridAutores);
            this.Controls.Add(this.dataGridAutoresPublicacion);
            this.Controls.Add(this.EliminarAutorBoton);
            this.Controls.Add(this.BorrarBoton);
            this.Controls.Add(this.guardarBoton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaVencimiento);
            this.Controls.Add(this.cuantia);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.textLugar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textDoi);
            this.Controls.Add(this.textCitas);
            this.Controls.Add(this.textPaginas);
            this.Controls.Add(this.textAño);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.dataGridConferencia);
            this.Name = "ConferenciaForm";
            this.Text = "ConferenciaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConferenciaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresPublicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalidadBoton;
        private System.Windows.Forms.Button AñadirAutor;
        private System.Windows.Forms.DataGridView dataGridAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDautores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoAutores;
        private System.Windows.Forms.DataGridView dataGridAutoresPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button EliminarAutorBoton;
        private System.Windows.Forms.Button BorrarBoton;
        private System.Windows.Forms.Button guardarBoton;
        private System.Windows.Forms.Label FechaVencimiento;
        private System.Windows.Forms.Label cuantia;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox textPaginas;
        private System.Windows.Forms.TextBox textAño;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.DataGridView dataGridConferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn citas;
        private System.Windows.Forms.DataGridViewTextBoxColumn doi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.TextBox textCitas;
        private System.Windows.Forms.TextBox textDoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorAño;
        private System.Windows.Forms.ErrorProvider errorPaginas;
        private System.Windows.Forms.ErrorProvider errorCitas;
        private System.Windows.Forms.ErrorProvider errorCategoria;
        private System.Windows.Forms.Label CalidadLbl;
    }
}