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
    public partial class PatenteForm : Form
    {
        public List<Patente> ListaPatentes;
        private bool modificado = false;
        private bool FilaSeleccionada = false;
        public static int IDactualProduccion { get; set; }

        private Patente BuscarSeleccionado()
        {
            int id = (int)dataGridPatente.SelectedRows[0].Cells[0].Value;
            Patente autor = null;
            foreach (Patente a in ListaPatentes)
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
            dataGridPatente.Rows.Clear();
            foreach (Patente patente in ListaPatentes)
            {
                dataGridPatente.Rows.Add(patente.ID, patente.Titulo, patente.Año, patente.Cuantia, patente.FechaVencimiento.Date);
            }
        }

        public PatenteForm()
        {
            BBDD.Conectar("root");
            ListaPatentes = (List<Patente>)PatenteDAO.MostrarTodo();
            InitializeComponent();
            RellenarDataGrid();
        }

        private void RellenarForm()
        {
            Patente patente = new Patente();
            patente = BuscarSeleccionado();
            textTitulo.Text = patente.Titulo;
            textAño.Text = patente.Año.ToString();
            textCuantia.Text = patente.Cuantia.ToString();
            //textVencimiento.Text = patente.FechaVencimiento.Date.ToString();
            dateTimePickerP.Text = patente.FechaVencimiento.ToString();

        }

        private void Insertar()
        {
            IDactualProduccion = PatenteDAO.IDactual();
            Patente patente = new Patente();
            if (textTitulo.Text.Trim() == "" || textAño.Text.Trim() == "" || textCuantia.Text.Trim() == "")
            {
                MessageBox.Show("Debe rellenar los campos primero");
            }

            else
            {
                patente.Titulo = textTitulo.Text;
                patente.Año = int.Parse(textAño.Text);
                patente.Cuantia = int.Parse(textCuantia.Text);
                patente.FechaVencimiento = dateTimePickerP.Value;
                ListaPatentes.Add(patente);
                PatenteDAO.Insertar(patente);
                MessageBox.Show("Registro guardado con éxito");
                BorrarForm();
                RellenarDataGrid();
            }
        }

        private void Eliminar()
        {
            Patente patente = BuscarSeleccionado();
            dataGridPatente.Rows.Remove(dataGridPatente.SelectedRows[0]);
            PatenteDAO.BorrarRegistro(patente);
            ListaPatentes.Remove(patente);
        }

        private void Modificar()
        {
            Patente patente = BuscarSeleccionado();
            patente = BuscarSeleccionado();
            patente.Titulo = textTitulo.Text;
            patente.Año = int.Parse(textAño.Text);
            patente.Cuantia = int.Parse(textCuantia.Text);
            patente.FechaVencimiento = dateTimePickerP.Value;

            int indice = ListaPatentes.IndexOf(patente);
            if (indice >= 0)
            {
                ListaPatentes[indice] = patente;
            }
            PatenteDAO.ActualizarRegistro(patente);
            MessageBox.Show("Registro modificado con éxito");
            RellenarDataGrid();
        }

        private void guardarBoton_Click(object sender, EventArgs e)
        {
            if (FilaSeleccionada)
            {
                Modificar();
                FilaSeleccionada = false;
            }
            else
            {
                Insertar();
            }
        }

        private void BorrarForm()
        {
            textTitulo.Clear();
            textAño.Clear();
            textCuantia.Clear();
            dateTimePickerP.Text= DateTime.Today.Date.ToString();
        }

        private void BorrarBoton_Click(object sender, EventArgs e)
        {
            BorrarForm();
            FilaSeleccionada = false;
        }

        private void EliminarAutorBoton_Click(object sender, EventArgs e)
        {
            if (dataGridPatente.SelectedRows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que quiere eliminar este registro de forma permanente?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    Eliminar();
                    MessageBox.Show("La producción se ha modificado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero una producción");
            }

        }

        private void PatenteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.Desconectar();
        }

        private void dataGridPatente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RellenarForm();
            FilaSeleccionada = true;
        }
    }
}
