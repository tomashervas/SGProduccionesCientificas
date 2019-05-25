using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPublicacionesCientificas.CapaPresentacion
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BotonAutor_Click(object sender, EventArgs e)
        {
            AutorForm autorForm = new AutorForm();
            autorForm.ShowDialog();
        }

        private void BotonPatente_Click(object sender, EventArgs e)
        {
            PatenteForm patenteForm = new PatenteForm();
            patenteForm.ShowDialog();
        }
    }
}
