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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BotonAutor = new System.Windows.Forms.Button();
            this.BotonPatente = new System.Windows.Forms.Button();
            this.BotonConferencia = new System.Windows.Forms.Button();
            this.BotonRevista = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BotonAutor);
            this.flowLayoutPanel1.Controls.Add(this.BotonPatente);
            this.flowLayoutPanel1.Controls.Add(this.BotonConferencia);
            this.flowLayoutPanel1.Controls.Add(this.BotonRevista);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(52, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BotonAutor
            // 
            this.BotonAutor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAutor.Location = new System.Drawing.Point(3, 3);
            this.BotonAutor.Name = "BotonAutor";
            this.BotonAutor.Size = new System.Drawing.Size(287, 73);
            this.BotonAutor.TabIndex = 0;
            this.BotonAutor.Text = "Autor";
            this.BotonAutor.UseVisualStyleBackColor = true;
            this.BotonAutor.Click += new System.EventHandler(this.BotonAutor_Click);
            // 
            // BotonPatente
            // 
            this.BotonPatente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPatente.Location = new System.Drawing.Point(3, 82);
            this.BotonPatente.Name = "BotonPatente";
            this.BotonPatente.Size = new System.Drawing.Size(287, 73);
            this.BotonPatente.TabIndex = 0;
            this.BotonPatente.Text = "Patente";
            this.BotonPatente.UseVisualStyleBackColor = true;
            // 
            // BotonConferencia
            // 
            this.BotonConferencia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConferencia.Location = new System.Drawing.Point(3, 161);
            this.BotonConferencia.Name = "BotonConferencia";
            this.BotonConferencia.Size = new System.Drawing.Size(287, 73);
            this.BotonConferencia.TabIndex = 0;
            this.BotonConferencia.Text = "Artículo de conferencia";
            this.BotonConferencia.UseVisualStyleBackColor = true;
            // 
            // BotonRevista
            // 
            this.BotonRevista.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRevista.Location = new System.Drawing.Point(3, 240);
            this.BotonRevista.Name = "BotonRevista";
            this.BotonRevista.Size = new System.Drawing.Size(287, 73);
            this.BotonRevista.TabIndex = 0;
            this.BotonRevista.Text = "Artículo de revista";
            this.BotonRevista.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BotonAutor;
        private System.Windows.Forms.Button BotonPatente;
        private System.Windows.Forms.Button BotonConferencia;
        private System.Windows.Forms.Button BotonRevista;
    }
}