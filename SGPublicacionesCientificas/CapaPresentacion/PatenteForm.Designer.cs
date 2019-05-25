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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPatente
            // 
            this.dataGridPatente.AllowUserToAddRows = false;
            this.dataGridPatente.AllowUserToDeleteRows = false;
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
            this.dataGridPatente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPatente.Size = new System.Drawing.Size(360, 263);
            this.dataGridPatente.TabIndex = 1;
            this.dataGridPatente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPatente_CellClick);
            // 
            // EliminarAutorBoton
            // 
            this.EliminarAutorBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.EliminarAutorBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarAutorBoton.Location = new System.Drawing.Point(257, 467);
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
            this.BorrarBoton.Location = new System.Drawing.Point(118, 467);
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
            this.guardarBoton.Location = new System.Drawing.Point(12, 467);
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
            this.FechaVencimiento.Location = new System.Drawing.Point(4, 402);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(132, 17);
            this.FechaVencimiento.TabIndex = 10;
            this.FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // cuantia
            // 
            this.cuantia.AutoSize = true;
            this.cuantia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuantia.Location = new System.Drawing.Point(12, 371);
            this.cuantia.Name = "cuantia";
            this.cuantia.Size = new System.Drawing.Size(58, 17);
            this.cuantia.TabIndex = 11;
            this.cuantia.Text = "Cuantía";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Año.Location = new System.Drawing.Point(12, 340);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(33, 17);
            this.Año.TabIndex = 12;
            this.Año.Text = "Año";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 309);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(43, 17);
            this.Titulo.TabIndex = 13;
            this.Titulo.Text = "Título";
            // 
            // textCuantia
            // 
            this.textCuantia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCuantia.Location = new System.Drawing.Point(142, 371);
            this.textCuantia.Name = "textCuantia";
            this.textCuantia.Size = new System.Drawing.Size(230, 25);
            this.textCuantia.TabIndex = 6;
            // 
            // textAño
            // 
            this.textAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textAño.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAño.Location = new System.Drawing.Point(142, 340);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(230, 25);
            this.textAño.TabIndex = 7;
            // 
            // textTitulo
            // 
            this.textTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.Location = new System.Drawing.Point(142, 309);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(230, 25);
            this.textTitulo.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NombreTitulo
            // 
            this.NombreTitulo.HeaderText = "Titulo";
            this.NombreTitulo.Name = "NombreTitulo";
            this.NombreTitulo.ReadOnly = true;
            // 
            // NombreAño
            // 
            this.NombreAño.HeaderText = "Año";
            this.NombreAño.Name = "NombreAño";
            this.NombreAño.ReadOnly = true;
            // 
            // NombreCuantia
            // 
            this.NombreCuantia.HeaderText = "Cuantía";
            this.NombreCuantia.Name = "NombreCuantia";
            this.NombreCuantia.ReadOnly = true;
            // 
            // NombreFecha
            // 
            this.NombreFecha.HeaderText = "Fecha vencimiento";
            this.NombreFecha.Name = "NombreFecha";
            this.NombreFecha.ReadOnly = true;
            // 
            // dateTimePickerP
            // 
            this.dateTimePickerP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerP.Location = new System.Drawing.Point(142, 402);
            this.dateTimePickerP.Name = "dateTimePickerP";
            this.dateTimePickerP.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerP.TabIndex = 17;
            // 
            // PatenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.dateTimePickerP);
            this.Controls.Add(this.EliminarAutorBoton);
            this.Controls.Add(this.BorrarBoton);
            this.Controls.Add(this.guardarBoton);
            this.Controls.Add(this.FechaVencimiento);
            this.Controls.Add(this.cuantia);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textCuantia);
            this.Controls.Add(this.textAño);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.dataGridPatente);
            this.Name = "PatenteForm";
            this.Text = "PatenteForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatenteForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatente)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerP;
    }
}