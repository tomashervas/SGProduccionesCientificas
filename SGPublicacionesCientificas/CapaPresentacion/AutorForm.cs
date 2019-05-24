using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaNegocio;

namespace SGPublicacionesCientificas.CapaPresentacion
{
    public partial class AutorForm : Form
    {
        public static int IDactualAutor { get; set; }

        public AutorForm()
        {
            BBDD.Conectar("root");
            InitializeComponent();
            IDactualAutor = AutorExternoDAO.IDactual();
            BBDD.Desconectar();
        }

        private void BotonUni_Click(object sender, EventArgs e)
        {
            AutorUniForm formUni = new AutorUniForm();
            formUni.ShowDialog();
        }

        private void BotonExterno_Click(object sender, EventArgs e)
        {
            AutorExtForm formExt = new AutorExtForm();
            formExt.ShowDialog();
        }
    }
}
