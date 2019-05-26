namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class Buscar
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProducciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoGrupo = new System.Windows.Forms.GroupBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioPatente = new System.Windows.Forms.RadioButton();
            this.radioConferencia = new System.Windows.Forms.RadioButton();
            this.radioRevista = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducciones)).BeginInit();
            this.tipoGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(112, 94);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(178, 25);
            this.textNombre.TabIndex = 0;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.BuscarBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Location = new System.Drawing.Point(112, 126);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(178, 41);
            this.BuscarBtn.TabIndex = 1;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = false;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intoduzca el nombre del autor";
            // 
            // dataGridProducciones
            // 
            this.dataGridProducciones.AllowUserToAddRows = false;
            this.dataGridProducciones.AllowUserToDeleteRows = false;
            this.dataGridProducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.titulo,
            this.año,
            this.Tipo});
            this.dataGridProducciones.Location = new System.Drawing.Point(13, 245);
            this.dataGridProducciones.MultiSelect = false;
            this.dataGridProducciones.Name = "dataGridProducciones";
            this.dataGridProducciones.ReadOnly = true;
            this.dataGridProducciones.RowHeadersVisible = false;
            this.dataGridProducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducciones.Size = new System.Drawing.Size(359, 150);
            this.dataGridProducciones.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // año
            // 
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // tipoGrupo
            // 
            this.tipoGrupo.Controls.Add(this.radioRevista);
            this.tipoGrupo.Controls.Add(this.radioConferencia);
            this.tipoGrupo.Controls.Add(this.radioPatente);
            this.tipoGrupo.Controls.Add(this.radioTodos);
            this.tipoGrupo.Location = new System.Drawing.Point(34, 173);
            this.tipoGrupo.Name = "tipoGrupo";
            this.tipoGrupo.Size = new System.Drawing.Size(325, 48);
            this.tipoGrupo.TabIndex = 4;
            this.tipoGrupo.TabStop = false;
            this.tipoGrupo.Text = "Tipo";
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(7, 20);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(55, 17);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioPatente
            // 
            this.radioPatente.AutoSize = true;
            this.radioPatente.Location = new System.Drawing.Point(69, 20);
            this.radioPatente.Name = "radioPatente";
            this.radioPatente.Size = new System.Drawing.Size(62, 17);
            this.radioPatente.TabIndex = 1;
            this.radioPatente.TabStop = true;
            this.radioPatente.Text = "Patente";
            this.radioPatente.UseVisualStyleBackColor = true;
            // 
            // radioConferencia
            // 
            this.radioConferencia.AutoSize = true;
            this.radioConferencia.Location = new System.Drawing.Point(138, 20);
            this.radioConferencia.Name = "radioConferencia";
            this.radioConferencia.Size = new System.Drawing.Size(101, 17);
            this.radioConferencia.TabIndex = 2;
            this.radioConferencia.TabStop = true;
            this.radioConferencia.Text = "Art. Conferencia";
            this.radioConferencia.UseVisualStyleBackColor = true;
            // 
            // radioRevista
            // 
            this.radioRevista.AutoSize = true;
            this.radioRevista.Location = new System.Drawing.Point(245, 20);
            this.radioRevista.Name = "radioRevista";
            this.radioRevista.Size = new System.Drawing.Size(80, 17);
            this.radioRevista.TabIndex = 3;
            this.radioRevista.TabStop = true;
            this.radioRevista.Text = "Art. Revista";
            this.radioRevista.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.tipoGrupo);
            this.Controls.Add(this.dataGridProducciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.textNombre);
            this.Name = "Buscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducciones)).EndInit();
            this.tipoGrupo.ResumeLayout(false);
            this.tipoGrupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.GroupBox tipoGrupo;
        private System.Windows.Forms.RadioButton radioRevista;
        private System.Windows.Forms.RadioButton radioConferencia;
        private System.Windows.Forms.RadioButton radioPatente;
        private System.Windows.Forms.RadioButton radioTodos;
    }
}