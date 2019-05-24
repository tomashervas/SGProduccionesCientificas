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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BotonUni
            // 
            this.BotonUni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.BotonUni.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonUni.Location = new System.Drawing.Point(51, 171);
            this.BotonUni.Name = "BotonUni";
            this.BotonUni.Size = new System.Drawing.Size(287, 73);
            this.BotonUni.TabIndex = 0;
            this.BotonUni.Text = "Autor de universidad";
            this.BotonUni.UseVisualStyleBackColor = false;
            this.BotonUni.Click += new System.EventHandler(this.BotonUni_Click);
            // 
            // BotonExterno
            // 
            this.BotonExterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(133)))), ((int)(((byte)(109)))));
            this.BotonExterno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonExterno.Location = new System.Drawing.Point(51, 250);
            this.BotonExterno.Name = "BotonExterno";
            this.BotonExterno.Size = new System.Drawing.Size(287, 73);
            this.BotonExterno.TabIndex = 0;
            this.BotonExterno.Text = "Autor externo";
            this.BotonExterno.UseVisualStyleBackColor = false;
            this.BotonExterno.Click += new System.EventHandler(this.BotonExterno_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 233);
            this.panel1.TabIndex = 2;
            // 
            // AutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.BotonExterno);
            this.Controls.Add(this.BotonUni);
            this.Controls.Add(this.panel1);
            this.Name = "AutorForm";
            this.Text = "AutorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonUni;
        private System.Windows.Forms.Button BotonExterno;
        private System.Windows.Forms.Panel panel1;
    }
}