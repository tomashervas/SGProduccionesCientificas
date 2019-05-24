namespace SGPublicacionesCientificas.CapaPresentacion
{
    partial class AutorForm
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
            this.BotonUni = new System.Windows.Forms.Button();
            this.BotonExterno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonUni
            // 
            this.BotonUni.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonUni.Location = new System.Drawing.Point(51, 171);
            this.BotonUni.Name = "BotonUni";
            this.BotonUni.Size = new System.Drawing.Size(287, 73);
            this.BotonUni.TabIndex = 0;
            this.BotonUni.Text = "Autor de universidad";
            this.BotonUni.UseVisualStyleBackColor = true;
            this.BotonUni.Click += new System.EventHandler(this.BotonUni_Click);
            // 
            // BotonExterno
            // 
            this.BotonExterno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonExterno.Location = new System.Drawing.Point(51, 250);
            this.BotonExterno.Name = "BotonExterno";
            this.BotonExterno.Size = new System.Drawing.Size(287, 73);
            this.BotonExterno.TabIndex = 0;
            this.BotonExterno.Text = "Autor externo";
            this.BotonExterno.UseVisualStyleBackColor = true;
            // 
            // AutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.BotonExterno);
            this.Controls.Add(this.BotonUni);
            this.Name = "AutorForm";
            this.Text = "AutorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonUni;
        private System.Windows.Forms.Button BotonExterno;
    }
}