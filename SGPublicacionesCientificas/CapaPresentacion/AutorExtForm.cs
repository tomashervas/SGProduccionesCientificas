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
    public partial class AutorExtForm : Form
    {
        public List<AutorExterno> autoresExt;
        private bool modificado = false;
        private bool FilaSeleccionada = false;

        private AutorExterno BuscarSeleccionado()
        {
            int id = (int)dataGridAutoresExt.SelectedRows[0].Cells[0].Value;
            AutorExterno autor = null;
            foreach (AutorExterno a in autoresExt)
            {
                if (a.ID == id)
                {
                    autor = a;
                    break;
                }
            }
            
            return autor;
        }

        private void RellenarDataGrid()
        {
            dataGridAutoresExt.Rows.Clear();
            foreach (AutorExterno autor in autoresExt)
            {
                dataGridAutoresExt.Rows.Add(autor.ID, autor.Nombre, autor.Apellido);
            }
        }

        public AutorExtForm()
        {
            BBDD.Conectar("root");
            autoresExt = (List<AutorExterno>)AutorExternoDAO.MostrarTodo();
            InitializeComponent();
            RellenarDataGrid();

        }

        private void RellenarForm()
        {
            AutorExterno autor = new AutorExterno();
            autor = BuscarSeleccionado();
            textNombre.Text = autor.Nombre;
            textApellido.Text = autor.Apellido;
        }

        private void InsertarAutor()
        {
            AutorExterno autor = new AutorExterno();
            if (textNombre.Text.Trim() == "" || textApellido.Text.Trim() == "" )
            {
                MessageBox.Show("Debe rellenar los campos primero");
            }

            else
            {
                autor.Nombre = textNombre.Text;
                autor.Apellido = textApellido.Text;
                autoresExt.Add(autor);
                AutorExternoDAO.Insertar(autor);
                MessageBox.Show("Registro guardado con éxito");
                BorrarForm();
                RellenarDataGrid();
            }
        }

        private void EliminarAutor()
        {
            AutorExterno autor = BuscarSeleccionado();
            dataGridAutoresExt.Rows.Remove(dataGridAutoresExt.SelectedRows[0]);
            AutorExternoDAO.BorrarRegistro(autor);
            autoresExt.Remove(autor);
        }

        private void ModificarAutor()
        {
            AutorExterno autor = BuscarSeleccionado();
            autor = BuscarSeleccionado();
            autor.Nombre = textNombre.Text;
            autor.Apellido = textApellido.Text;
            int indice = autoresExt.IndexOf(autor);
            if (indice >= 0)
            {
                autoresExt[indice] = autor;
            }
            AutorExternoDAO.ActualizarRegistro(autor);
            MessageBox.Show("Registro modificado con éxito");
            RellenarDataGrid();
        }

        private void guardarBoton_Click(object sender, EventArgs e)
        {
            if (FilaSeleccionada)
            {
                ModificarAutor();
                FilaSeleccionada = false;
            }
            else
            {
                InsertarAutor();
            }
        }

        private void BorrarForm()
        {
            textNombre.Clear();
            textApellido.Clear();
        }

        private void BorrarBoton_Click(object sender, EventArgs e)
        {
            BorrarForm();
            FilaSeleccionada = false;
        }

        private void EliminarAutorBoton_Click(object sender, EventArgs e)
        {
            if (dataGridAutoresExt.SelectedRows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que quiere eliminar este registro de forma permanente?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    EliminarAutor();
                    MessageBox.Show("El autor se ha modificado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero un autor");
            }

        }

        private void AutorExtForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.Desconectar();
        }

        private void dataGridAutoresExt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RellenarForm();
            FilaSeleccionada = true;
        }
    }
}
