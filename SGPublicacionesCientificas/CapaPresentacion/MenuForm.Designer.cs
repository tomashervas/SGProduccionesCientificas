namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class MenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonRevista = new System.Windows.Forms.Button();
            this.BotonConferencia = new System.Windows.Forms.Button();
            this.BotonPatente = new System.Windows.Forms.Button();
            this.BotonAutor = new System.Windows.Forms.Button();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.BuscarBoton);
            this.panel1.Location = new System.Drawing.Point(-10, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 233);
            this.panel1.TabIndex = 1;
            // 
            // BotonRevista
            // 
            this.BotonRevista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.BotonRevista.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRevista.Location = new System.Drawing.Point(50, 322);
            this.BotonRevista.Name = "BotonRevista";
            this.BotonRevista.Size = new System.Drawing.Size(287, 73);
            this.BotonRevista.TabIndex = 0;
            this.BotonRevista.Text = "Artículo de revista";
            this.BotonRevista.UseVisualStyleBackColor = false;
            // 
            // BotonConferencia
            // 
            this.BotonConferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.BotonConferencia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConferencia.Location = new System.Drawing.Point(50, 243);
            this.BotonConferencia.Name = "BotonConferencia";
            this.BotonConferencia.Size = new System.Drawing.Size(287, 73);
            this.BotonConferencia.TabIndex = 0;
            this.BotonConferencia.Text = "Artículo de conferencia";
            this.BotonConferencia.UseVisualStyleBackColor = false;
            // 
            // BotonPatente
            // 
            this.BotonPatente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.BotonPatente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPatente.Location = new System.Drawing.Point(50, 164);
            this.BotonPatente.Name = "BotonPatente";
            this.BotonPatente.Size = new System.Drawing.Size(287, 73);
            this.BotonPatente.TabIndex = 0;
            this.BotonPatente.Text = "Patente";
            this.BotonPatente.UseVisualStyleBackColor = false;
            this.BotonPatente.Click += new System.EventHandler(this.BotonPatente_Click);
            // 
            // BotonAutor
            // 
            this.BotonAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.BotonAutor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAutor.Location = new System.Drawing.Point(50, 85);
            this.BotonAutor.Name = "BotonAutor";
            this.BotonAutor.Size = new System.Drawing.Size(287, 73);
            this.BotonAutor.TabIndex = 0;
            this.BotonAutor.Text = "Autor";
            this.BotonAutor.UseVisualStyleBackColor = false;
            this.BotonAutor.Click += new System.EventHandler(this.BotonAutor_Click);
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.BuscarBoton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBoton.Location = new System.Drawing.Point(60, 114);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(287, 73);
            this.BuscarBoton.TabIndex = 0;
            this.BuscarBoton.Text = "Buscar producción";
            this.BuscarBoton.UseVisualStyleBackColor = false;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.BotonAutor);
            this.Controls.Add(this.BotonPatente);
            this.Controls.Add(this.BotonConferencia);
            this.Controls.Add(this.BotonRevista);
            this.Controls.Add(this.panel1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonRevista;
        private System.Windows.Forms.Button BotonConferencia;
        private System.Windows.Forms.Button BotonPatente;
        private System.Windows.Forms.Button BotonAutor;
        private System.Windows.Forms.Button BuscarBoton;
    }
}