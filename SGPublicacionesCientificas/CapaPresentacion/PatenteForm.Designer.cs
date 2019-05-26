namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class PatenteForm
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
            this.dataGridPatente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarAutorBoton = new System.Windows.Forms.Button();
            this.BorrarBoton = new System.Windows.Forms.Button();
            this.guardarBoton = new System.Windows.Forms.Button();
            this.FechaVencimiento = new System.Windows.Forms.Label();
            this.cuantia = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.textCuantia = new System.Windows.Forms.TextBox();
            this.textAño = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.dateTimePickerP = new System.Windows.Forms.DateTimePicker();
            this.dataGridAutoresPublicacion = new System.Windows.Forms.DataGridView();
            this.autoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridAutores = new System.Windows.Forms.DataGridView();
            this.IDautores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoAutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñadirAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalidadBoton = new System.Windows.Forms.Button();
            this.CalidadLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresPublicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPatente
            // 
            this.dataGridPatente.AllowUserToAddRows = false;
            this.dataGridPatente.AllowUserToDeleteRows = false;
            this.dataGridPatente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridPatente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.dataGridPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreTitulo,
            this.NombreAño,
            this.NombreCuantia,
            this.NombreFecha});
            this.dataGridPatente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridPatente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridPatente.Location = new System.Drawing.Point(12, 12);
            this.dataGridPatente.MultiSelect = false;
            this.dataGridPatente.Name = "dataGridPatente";
            this.dataGridPatente.ReadOnly = true;
            this.dataGridPatente.RowHeadersVisible = false;
            this.dataGridPatente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPatente.Size = new System.Drawing.Size(422, 229);
            this.dataGridPatente.TabIndex = 1;
            this.dataGridPatente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPatente_CellClick);
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
            // NombreCuantia
            // 
            this.NombreCuantia.HeaderText = "Cuantía";
            this.NombreCuantia.Name = "NombreCuantia";
            this.NombreCuantia.ReadOnly = true;
            this.NombreCuantia.Width = 70;
            // 
            // NombreFecha
            // 
            this.NombreFecha.HeaderText = "Vencimiento";
            this.NombreFecha.Name = "NombreFecha";
            this.NombreFecha.ReadOnly = true;
            this.NombreFecha.Width = 90;
            // 
            // EliminarAutorBoton
            // 
            this.EliminarAutorBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.EliminarAutorBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarAutorBoton.Location = new System.Drawing.Point(257, 611);
            this.EliminarAutorBoton.Name = "EliminarAutorBoton";
            this.EliminarAutorBoton.Size = new System.Drawing.Size(115, 32);
            this.EliminarAutorBoton.TabIndex = 14;
            this.EliminarAutorBoton.Text = "Eliminar";
            this.EliminarAutorBoton.UseVisualStyleBackColor = false;
            this.EliminarAutorBoton.Click += new System.EventHandler(this.EliminarAutorBoton_Click);
            // 
            // BorrarBoton
            // 
            this.BorrarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.BorrarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBoton.Location = new System.Drawing.Point(118, 611);
            this.BorrarBoton.Name = "BorrarBoton";
            this.BorrarBoton.Size = new System.Drawing.Size(133, 32);
            this.BorrarBoton.TabIndex = 15;
            this.BorrarBoton.Text = "Borrar Formulario";
            this.BorrarBoton.UseVisualStyleBackColor = false;
            this.BorrarBoton.Click += new System.EventHandler(this.BorrarBoton_Click);
            // 
            // guardarBoton
            // 
            this.guardarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.guardarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBoton.Location = new System.Drawing.Point(12, 611);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(100, 32);
            this.guardarBoton.TabIndex = 16;
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.UseVisualStyleBackColor = false;
            this.guardarBoton.Click += new System.EventHandler(this.guardarBoton_Click);
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.AutoSize = true;
            this.FechaVencimiento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimiento.Location = new System.Drawing.Point(12, 580);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(132, 17);
            this.FechaVencimiento.TabIndex = 10;
            this.FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // cuantia
            // 
            this.cuantia.AutoSize = true;
            this.cuantia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuantia.Location = new System.Drawing.Point(12, 549);
            this.cuantia.Name = "cuantia";
            this.cuantia.Size = new System.Drawing.Size(58, 17);
            this.cuantia.TabIndex = 11;
            this.cuantia.Text = "Cuantía";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Año.Location = new System.Drawing.Point(12, 518);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(33, 17);
            this.Año.TabIndex = 12;
            this.Año.Text = "Año";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 487);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(43, 17);
            this.Titulo.TabIndex = 13;
            this.Titulo.Text = "Título";
            // 
            // textCuantia
            // 
            this.textCuantia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCuantia.Location = new System.Drawing.Point(204, 549);
            this.textCuantia.Name = "textCuantia";
            this.textCuantia.Size = new System.Drawing.Size(230, 25);
            this.textCuantia.TabIndex = 6;
            // 
            // textAño
            // 
            this.textAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textAño.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAño.Location = new System.Drawing.Point(204, 518);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(230, 25);
            this.textAño.TabIndex = 7;
            // 
            // textTitulo
            // 
            this.textTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.Location = new System.Drawing.Point(204, 487);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(230, 25);
            this.textTitulo.TabIndex = 8;
            // 
            // dateTimePickerP
            // 
            this.dateTimePickerP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerP.Location = new System.Drawing.Point(204, 580);
            this.dateTimePickerP.Name = "dateTimePickerP";
            this.dateTimePickerP.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerP.TabIndex = 17;
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
            this.dataGridAutoresPublicacion.Location = new System.Drawing.Point(15, 278);
            this.dataGridAutoresPublicacion.MultiSelect = false;
            this.dataGridAutoresPublicacion.Name = "dataGridAutoresPublicacion";
            this.dataGridAutoresPublicacion.ReadOnly = true;
            this.dataGridAutoresPublicacion.RowHeadersVisible = false;
            this.dataGridAutoresPublicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutoresPublicacion.Size = new System.Drawing.Size(193, 161);
            this.dataGridAutoresPublicacion.TabIndex = 18;
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
            this.dataGridAutores.Location = new System.Drawing.Point(245, 278);
            this.dataGridAutores.MultiSelect = false;
            this.dataGridAutores.Name = "dataGridAutores";
            this.dataGridAutores.ReadOnly = true;
            this.dataGridAutores.RowHeadersVisible = false;
            this.dataGridAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutores.Size = new System.Drawing.Size(189, 161);
            this.dataGridAutores.TabIndex = 18;
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
            // AñadirAutor
            // 
            this.AñadirAutor.Location = new System.Drawing.Point(214, 348);
            this.AñadirAutor.Name = "AñadirAutor";
            this.AñadirAutor.Size = new System.Drawing.Size(25, 23);
            this.AñadirAutor.TabIndex = 19;
            this.AñadirAutor.Text = "<";
            this.AñadirAutor.UseVisualStyleBackColor = true;
            this.AñadirAutor.Click += new System.EventHandler(this.AñadirAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Autores patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Todos los autores";
            // 
            // CalidadBoton
            // 
            this.CalidadBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.CalidadBoton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalidadBoton.Location = new System.Drawing.Point(15, 446);
            this.CalidadBoton.Name = "CalidadBoton";
            this.CalidadBoton.Size = new System.Drawing.Size(75, 31);
            this.CalidadBoton.TabIndex = 20;
            this.CalidadBoton.Text = "Calidad";
            this.CalidadBoton.UseVisualStyleBackColor = false;
            this.CalidadBoton.Click += new System.EventHandler(this.CalidadBoton_Click);
            // 
            // CalidadLbl
            // 
            this.CalidadLbl.AutoSize = true;
            this.CalidadLbl.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalidadLbl.Location = new System.Drawing.Point(102, 450);
            this.CalidadLbl.Name = "CalidadLbl";
            this.CalidadLbl.Size = new System.Drawing.Size(20, 22);
            this.CalidadLbl.TabIndex = 21;
            this.CalidadLbl.Text = "_";
            // 
            // PatenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(446, 658);
            this.Controls.Add(this.CalidadLbl);
            this.Controls.Add(this.CalidadBoton);
            this.Controls.Add(this.AñadirAutor);
            this.Controls.Add(this.dataGridAutores);
            this.Controls.Add(this.dataGridAutoresPublicacion);
            this.Controls.Add(this.dateTimePickerP);
            this.Controls.Add(this.EliminarAutorBoton);
            this.Controls.Add(this.BorrarBoton);
            this.Controls.Add(this.guardarBoton);
            this.Controls.Add(this.FechaVencimiento);
            this.Controls.Add(this.cuantia);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textCuantia);
            this.Controls.Add(this.textAño);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.dataGridPatente);
            this.Name = "PatenteForm";
            this.Text = "PatenteForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatenteForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresPublicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPatente;
        private System.Windows.Forms.Button EliminarAutorBoton;
        private System.Windows.Forms.Button BorrarBoton;
        private System.Windows.Forms.Button guardarBoton;
        private System.Windows.Forms.Label FechaVencimiento;
        private System.Windows.Forms.Label cuantia;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox textCuantia;
        private System.Windows.Forms.TextBox textAño;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePickerP;
        private System.Windows.Forms.DataGridView dataGridAutoresPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridView dataGridAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDautores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoAutores;
        private System.Windows.Forms.Button AñadirAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalidadBoton;
        private System.Windows.Forms.Label CalidadLbl;
    }
}