namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class AutorExtForm
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
            this.dataGridAutoresExt = new System.Windows.Forms.DataGridView();
            this.EliminarAutorBoton = new System.Windows.Forms.Button();
            this.BorrarBoton = new System.Windows.Forms.Button();
            this.guardarBoton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoUni = new System.Windows.Forms.Label();
            this.NombreUni = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresExt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAutoresExt
            // 
            this.dataGridAutoresExt.AllowUserToAddRows = false;
            this.dataGridAutoresExt.AllowUserToDeleteRows = false;
            this.dataGridAutoresExt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.dataGridAutoresExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutoresExt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido});
            this.dataGridAutoresExt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridAutoresExt.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAutoresExt.Location = new System.Drawing.Point(12, 12);
            this.dataGridAutoresExt.MultiSelect = false;
            this.dataGridAutoresExt.Name = "dataGridAutoresExt";
            this.dataGridAutoresExt.ReadOnly = true;
            this.dataGridAutoresExt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAutoresExt.Size = new System.Drawing.Size(360, 263);
            this.dataGridAutoresExt.TabIndex = 1;
            this.dataGridAutoresExt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAutoresExt_CellClick);
            // 
            // EliminarAutorBoton
            // 
            this.EliminarAutorBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.EliminarAutorBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarAutorBoton.Location = new System.Drawing.Point(256, 467);
            this.EliminarAutorBoton.Name = "EliminarAutorBoton";
            this.EliminarAutorBoton.Size = new System.Drawing.Size(115, 32);
            this.EliminarAutorBoton.TabIndex = 4;
            this.EliminarAutorBoton.Text = "Eliminar";
            this.EliminarAutorBoton.UseVisualStyleBackColor = false;
            this.EliminarAutorBoton.Click += new System.EventHandler(this.EliminarAutorBoton_Click);
            // 
            // BorrarBoton
            // 
            this.BorrarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.BorrarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBoton.Location = new System.Drawing.Point(117, 467);
            this.BorrarBoton.Name = "BorrarBoton";
            this.BorrarBoton.Size = new System.Drawing.Size(133, 32);
            this.BorrarBoton.TabIndex = 5;
            this.BorrarBoton.Text = "Borrar Formulario";
            this.BorrarBoton.UseVisualStyleBackColor = false;
            this.BorrarBoton.Click += new System.EventHandler(this.BorrarBoton_Click);
            // 
            // guardarBoton
            // 
            this.guardarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.guardarBoton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBoton.Location = new System.Drawing.Point(11, 467);
            this.guardarBoton.Name = "guardarBoton";
            this.guardarBoton.Size = new System.Drawing.Size(100, 32);
            this.guardarBoton.TabIndex = 6;
            this.guardarBoton.Text = "Guardar";
            this.guardarBoton.UseVisualStyleBackColor = false;
            this.guardarBoton.Click += new System.EventHandler(this.guardarBoton_Click);
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
            // ApellidoUni
            // 
            this.ApellidoUni.AutoSize = true;
            this.ApellidoUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoUni.Location = new System.Drawing.Point(11, 330);
            this.ApellidoUni.Name = "ApellidoUni";
            this.ApellidoUni.Size = new System.Drawing.Size(66, 17);
            this.ApellidoUni.TabIndex = 9;
            this.ApellidoUni.Text = "Apellidos";
            // 
            // NombreUni
            // 
            this.NombreUni.AutoSize = true;
            this.NombreUni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUni.Location = new System.Drawing.Point(11, 299);
            this.NombreUni.Name = "NombreUni";
            this.NombreUni.Size = new System.Drawing.Size(60, 17);
            this.NombreUni.TabIndex = 10;
            this.NombreUni.Text = "Nombre";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(141, 330);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(230, 25);
            this.textApellido.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.textNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(141, 299);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(230, 25);
            this.textNombre.TabIndex = 8;
            // 
            // AutorExtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.ApellidoUni);
            this.Controls.Add(this.NombreUni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.EliminarAutorBoton);
            this.Controls.Add(this.BorrarBoton);
            this.Controls.Add(this.guardarBoton);
            this.Controls.Add(this.dataGridAutoresExt);
            this.Name = "AutorExtForm";
            this.Text = "AutorExtForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorExtForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutoresExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAutoresExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button EliminarAutorBoton;
        private System.Windows.Forms.Button BorrarBoton;
        private System.Windows.Forms.Button guardarBoton;
        private System.Windows.Forms.Label ApellidoUni;
        private System.Windows.Forms.Label NombreUni;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
    }
}