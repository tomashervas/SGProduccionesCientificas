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
    public partial class AutorUniForm : Form
    {
        public ICollection<AutorUniversidad> autoresUni;

        private AutorUniversidad BuscarSeleccionado()
        {
            AutorUniversidad autor = (AutorUniversidad)dataGridAutoresUni.CurrentRow.DataBoundItem;
            return autor;
        }
   
        public AutorUniForm()
        {
            BBDD.Conectar("root");

            autoresUni = AutorUniversidadDAO.MostrarTodo();
            InitializeComponent();
            dataGridAutoresUni.DataSource = autoresUni;
            

        }

        private void AutorUniForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.Desconectar();
        }

        private void dataGridAutoresUni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AutorUniversidad autor= BuscarSeleccionado();
            textNombreUni.Text = autor.Nombre;
            textApellidoUni.Text = autor.Apellido;
            textDNI.Text = autor.DNI;
            textDepartamentoUni.Text = autor.Departamento;
            textEdad.Text = autor.Edad.ToString();

        }

        private void InsertarAutorUni()
        {
            AutorUniversidad autor = new AutorUniversidad();
            autor.Nombre = textNombreUni.Text;
            autor.Apellido = textApellidoUni.Text;
            autor.DNI = textDNI.Text;
            autor.Departamento = textDepartamentoUni.Text;
            if (textNombreUni.Text.Trim() == "" || textEdad.Text.Trim() == "")
            {
                MessageBox.Show("Debe rellenar los campos primero");
            }
          
            else{
                autor.Edad = int.Parse(textEdad.Text);
                autoresUni.Add(autor);
                AutorUniversidadDAO.Insertar(autor);
                MessageBox.Show("Registro guardado con éxito");
            }
            

        }

        private void guardarBoton_Click(object sender, EventArgs e)
        {
            InsertarAutorUni();
        }
    }
}
