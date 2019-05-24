namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class AutorUniForm
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
            this.dataGridAutoresUni = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNombreUni = new System.Windows.Forms.TextBox();
            this.NombreUni = new System.Windows.Forms.Label();
            this.textApellidoUni = new System.Windows.Forms.TextBox();
            this.ApellidoUni = new System.Windows.Forms.Label();
            this.textDepartamentoUni = new System.Windows.Forms.TextBox();
            this.DepartamentoUni = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guardarBoton = new System.Windows.Forms.Button();
            this.BorrarBoton = new System.Windows.Forms.Button();
            this.EliminarAutorBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresUni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAutoresUni
            // 
            this.dataGridAutoresUni.AllowUserToAddRows = false;
            this.dataGridAutoresUni.AllowUserToDeleteRows = false;
            this.dataGridAutoresUni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAutoresUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutoresUni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Departamento,
            this.DNI,
            this.Edad});
            this.dataGridAutoresUni.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridAutoresUni.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAutoresUni.Location = new System.Drawing.Point(12, 12);
            this.dataGridAutoresUni.MultiSelect = false;
            this.dataGridAutoresUni.Name = "dataGridAutoresUni";
            this.dataGridAutoresUni.ReadOnly = true;
            this.dataGridAutoresUni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutoresUni.Size = new System.Drawing.Size(360, 263);
            this.dataGridAutoresUni.TabIndex = 0;
            this.dataGridAutoresUni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAutoresUni_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // textNombreUni
            // 
            this.textNombreUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreUni.Location = new System.Drawing.Point(142, 309);
            this.textNombreUni.Name = "textNombreUni";
            this.textNombreUni.Size = new System.Drawing.Size(230, 25);
            this.textNombreUni.TabIndex = 1;
            // 
            // NombreUni
            // 
            this.NombreUni.AutoSize = true;
            this.NombreUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUni.Location = new System.Drawing.Point(12, 309);
            this.NombreUni.Name = "NombreUni";
            this.NombreUni.Size = new System.Drawing.Size(60, 17);
            this.NombreUni.TabIndex = 2;
            this.NombreUni.Text = "Nombre";
            // 
            // textApellidoUni
            // 
            this.textApellidoUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoUni.Location = new System.Drawing.Point(142, 340);
            this.textApellidoUni.Name = "textApellidoUni";
            this.textApellidoUni.Size = new System.Drawing.Size(230, 25);
            this.textApellidoUni.TabIndex = 1;
            // 
            // ApellidoUni
            // 
            this.ApellidoUni.AutoSize = true;
            this.ApellidoUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoUni.Location = new System.Drawing.Point(12, 340);
            this.ApellidoUni.Name = "ApellidoUni";
            this.ApellidoUni.Size = new System.Drawing.Size(66, 17);
            this.ApellidoUni.TabIndex = 2;
            this.ApellidoUni.Text = "Apellidos";
            // 
            // textDepartamentoUni
            // 
            this.textDepartamentoUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepartamentoUni.Location = new System.Drawing.Point(142, 371);
            this.textDepartamentoUni.Name = "textDepartamentoUni";
            this.textDepartamentoUni.Size = new System.Drawing.Size(230, 25);
            this.textDepartamentoUni.TabIndex = 1;
            // 
            // DepartamentoUni
            // 
            this.DepartamentoUni.AutoSize = true;
            this.DepartamentoUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentoUni.Location = new System.Drawing.Point(12, 371);
            this.DepartamentoUni.Name = "DepartamentoUni";
            this.DepartamentoUni.Size = new System.Drawing.Size(101, 17);
            this.DepartamentoUni.TabIndex = 2;
            this.DepartamentoUni.Text = "Departamento";
            // 
            // textDNI
            // 
            this.textDNI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDNI.Location = new System.Drawing.Point(142, 402);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(230, 25);
            this.textDNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // textEdad
            // 
            this.textEdad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdad.Location = new System.Drawing.Point(142, 433);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(230, 25);
            this.textEdad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // guardarBoton
            // 
            this.guardarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBoton.Location = new System.Drawing.Point(12, 467);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(100, 32);
            this.guardarBoton.TabIndex = 3;
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.UseVisualStyleBackColor = true;
            this.guardarBoton.Click += new System.EventHandler(this.guardarBoton_Click);
            // 
            // BorrarBoton
            // 
            this.BorrarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBoton.Location = new System.Drawing.Point(118, 467);
            this.BorrarBoton.Name = "BorrarBoton";
            this.BorrarBoton.Size = new System.Drawing.Size(133, 32);
            this.BorrarBoton.TabIndex = 3;
            this.BorrarBoton.Text = "Borrar Formulario";
            this.BorrarBoton.UseVisualStyleBackColor = true;
            this.BorrarBoton.Click += new System.EventHandler(this.BorrarBoton_Click);
            // 
            // EliminarAutorBoton
            // 
            this.EliminarAutorBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarAutorBoton.Location = new System.Drawing.Point(257, 467);
            this.EliminarAutorBoton.Name = "EliminarAutorBoton";
            this.EliminarAutorBoton.Size = new System.Drawing.Size(115, 32);
            this.EliminarAutorBoton.TabIndex = 3;
            this.EliminarAutorBoton.Text = "Eliminar";
            this.EliminarAutorBoton.UseVisualStyleBackColor = true;
            this.EliminarAutorBoton.Click += new System.EventHandler(this.EliminarAutorBoton_Click);
            // 
            // AutorUniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.EliminarAutorBoton);
            this.Controls.Add(this.BorrarBoton);
            this.Controls.Add(this.guardarBoton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartamentoUni);
            this.Controls.Add(this.ApellidoUni);
            this.Controls.Add(this.NombreUni);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textDepartamentoUni);
            this.Controls.Add(this.textApellidoUni);
            this.Controls.Add(this.textNombreUni);
            this.Controls.Add(this.dataGridAutoresUni);
            this.Name = "AutorUniForm";
            this.Text = "AutorUniForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorUniForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresUni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAutoresUni;
        private System.Windows.Forms.TextBox textNombreUni;
        private System.Windows.Forms.Label NombreUni;
        private System.Windows.Forms.TextBox textApellidoUni;
        private System.Windows.Forms.Label ApellidoUni;
        private System.Windows.Forms.TextBox textDepartamentoUni;
        private System.Windows.Forms.Label DepartamentoUni;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guardarBoton;
        private System.Windows.Forms.Button BorrarBoton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Button EliminarAutorBoton;
    }
}