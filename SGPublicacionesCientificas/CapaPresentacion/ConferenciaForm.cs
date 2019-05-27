using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaNegocio;

namespace SGPublicacionesCientificas.CapaPresentacion
{
    public partial class ConferenciaForm : Form
    {
        public List<Conferencia> ListaPatentes;
        public ICollection<int> ListaIDAutoresPublicacion = new List<int>();
        public ICollection<AutorExterno> ListaAutoresPublicacion = new List<AutorExterno>();
        public ICollection<AutorExterno> ListaAutoresCompleta = new List<AutorExterno>();
        private bool modificado = false;
        private bool FilaSeleccionada = false;
        public static int IDactualProduccion { get; set; }
        private AutorExterno AutorSeleccionado = null;
        private Conferencia ConferenciaSeleccionada = null;
        

        public ConferenciaForm()
        {
            BBDD.Conectar("tomas");
            InitializeComponent();
            ListaPatentes = (List<Conferencia>)ConferenciaDAO.MostrarTodo();
            RellenarDataGrid();
            ListaAutoresCompleta = AutorExternoDAO.MostrarExternosInternos();
            PatenteForm.RellenarDataAutores(dataGridAutores, (List<AutorExterno>)ListaAutoresCompleta);
        }

        private Conferencia BuscarSeleccionado()
        {
            int id = (int)dataGridConferencia.SelectedRows[0].Cells[0].Value;
            Conferencia conferencia = null;
            foreach (Conferencia a in ListaPatentes)
            {
                if (a.ID == id)
                {
                    conferencia = a;
                    break;
                }
            }
            return conferencia;
        }

        public AutorExterno BuscarAutorSeleccionado()
        {
            int id = (int)dataGridAutores.SelectedRows[0].Cells[0].Value;
            AutorExterno Autor = null;
            foreach (AutorExterno a in ListaAutoresCompleta)
            {
                if (a.ID == id)
                {
                    Autor = a;
                    break;
                }
            }
            return Autor;
        }

        private void RellenarDataGrid()
        {
            dataGridConferencia.Rows.Clear();
            foreach (Conferencia conferencia in ListaPatentes)
            {
                dataGridConferencia.Rows.Add(conferencia.ID, conferencia.Titulo, conferencia.Año, conferencia.Paginas, conferencia.Citas,conferencia.DOI,conferencia.NombreConferencia, conferencia.Lugar, conferencia.Categoria );
            }
        }

        private void RellenarForm()
        {
            Conferencia conferencia = new Conferencia();
            conferencia = BuscarSeleccionado();
            textTitulo.Text = conferencia.Titulo;
            textAño.Text = conferencia.Año.ToString();
            textPaginas.Text = conferencia.Paginas.ToString();
            textCitas.Text = conferencia.Citas.ToString();
            textDoi.Text = conferencia.DOI;
            textNombre.Text = conferencia.NombreConferencia;
            textLugar.Text = conferencia.Lugar;
            textCategoria.Text = conferencia.Categoria;
        }

        private void Insertar()
        {
            IDactualProduccion = PatenteDAO.IDactual();
            Conferencia conferencia = new Conferencia();
            if (textTitulo.Text.Trim() == "" || textNombre.Text.Trim() == "" || textCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Debe rellenar los campos primero");
            }

            else
            {
                conferencia.Titulo = textTitulo.Text;
                conferencia.Año = int.Parse(textAño.Text);
                conferencia.Paginas = int.Parse(textPaginas.Text);
                conferencia.Citas = int.Parse(textCitas.Text);
                conferencia.DOI = textDoi.Text;
                conferencia.NombreConferencia = textNombre.Text;
                conferencia.Lugar = textLugar.Text;
                conferencia.Categoria = textCategoria.Text;

                ListaPatentes.Add(conferencia);
                ConferenciaDAO.Insertar(conferencia);
                foreach (int id in ListaIDAutoresPublicacion)
                {
                    ConferenciaDAO.InsertarPublicaConferencia(id, conferencia.ID);
                }
                MessageBox.Show("Registro guardado con éxito");
                BorrarForm();
                RellenarDataGrid();
            }
        }

        private void BorrarForm()
        {
            textTitulo.Clear();
            textAño.Clear();
            textPaginas.Clear();
            textCitas.Clear();
            textDoi.Clear();
            textNombre.Clear();
            textLugar.Clear();
            textCategoria.Clear();
            dataGridAutoresPublicacion.Rows.Clear();
            ListaAutoresPublicacion.Clear();
        }

        private void Eliminar()
        {
            Conferencia conferencia = BuscarSeleccionado();
            dataGridConferencia.Rows.Remove(dataGridConferencia.SelectedRows[0]);
            ConferenciaDAO.BorrarRegistro(conferencia);
            ListaPatentes.Remove(conferencia);
        }

        private void Modificar()
        {
            Conferencia conferencia = BuscarSeleccionado();
            conferencia.Titulo = textTitulo.Text;
            conferencia.Año = int.Parse(textAño.Text);
            conferencia.Paginas = int.Parse(textPaginas.Text);
            conferencia.Citas = int.Parse(textCitas.Text);
            conferencia.DOI = textDoi.Text;
            conferencia.NombreConferencia = textNombre.Text;
            conferencia.Lugar = textLugar.Text;
            conferencia.Categoria = textCategoria.Text;

            int indice = ListaPatentes.IndexOf(conferencia);
            if (indice >= 0)
            {
                ListaPatentes[indice] = conferencia;
            }
            ConferenciaDAO.ActualizarRegistro(conferencia);
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

        private void BorrarBoton_Click(object sender, EventArgs e)
        {
            BorrarForm();
            FilaSeleccionada = false;
        }

        private void EliminarAutorBoton_Click(object sender, EventArgs e)
        {
            if (dataGridConferencia.SelectedRows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que quiere eliminar este registro de forma permanente?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.Yes)
                {
                    Eliminar();
                    MessageBox.Show("La producción se ha eliminado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero una producción");
            }

        }

        private void dataGridConferencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modificado = true;
            ListaAutoresPublicacion.Clear();
            ListaIDAutoresPublicacion.Clear();
            RellenarForm();
            FilaSeleccionada = true;
            Conferencia conferencia = BuscarSeleccionado();
            ConferenciaSeleccionada = BuscarSeleccionado();
            ListaIDAutoresPublicacion = PatenteDAO.MostrarAutoresPublicacion(conferencia.ID);
            foreach (int id in ListaIDAutoresPublicacion)
            {
                AutorExterno autor = AutorExternoDAO.BuscarAutorPorID(id);
                ListaAutoresPublicacion.Add(autor);
                //Console.WriteLine(autor.Nombre);
            }
            PatenteForm.RellenarDataAutores(dataGridAutoresPublicacion, (List<AutorExterno>)ListaAutoresPublicacion);
        }

        private void dataGridAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AutorSeleccionado = BuscarAutorSeleccionado();
        }

        private void AñadirAutor_Click(object sender, EventArgs e)
        {
            if (modificado)
            {
                MessageBox.Show("No se puede modificar los autores de una producción publicada anteriormente");
                modificado = false;
            }
            else
            {
                if (AutorSeleccionado != null)
                {
                    ListaAutoresPublicacion.Add(AutorSeleccionado);
                    ListaIDAutoresPublicacion.Add(AutorSeleccionado.ID);
                    PatenteForm.RellenarDataAutores(dataGridAutoresPublicacion, (List<AutorExterno>)ListaAutoresPublicacion);
                }
                else
                {
                    MessageBox.Show("Seleccione primero un autor que añadir");
                }
            }
        }

        /// <summary>
        /// Metodo que permite calcular la calidad de un articulo de conferencia al hacer click en el boton calidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalidadBoton_Click(object sender, EventArgs e)
        {
            if (ConferenciaSeleccionada != null)
            {
                if (ConferenciaSeleccionada.Categoria == "A*")
                {
                    CalidadLbl.Text = "1";
                }
                else if (ConferenciaSeleccionada.Categoria == "A")
                {
                    CalidadLbl.Text = "0.75";
                }
                else if (ConferenciaSeleccionada.Categoria == "B")
                {
                    CalidadLbl.Text = "0.5";
                }
                else
                {
                    CalidadLbl.Text = "0.25";
                }

            }
            else
            {
                MessageBox.Show("Seleccione primero un artículo de conferencia");
            }
        }

        private void textAño_Validating(object sender, CancelEventArgs e)
        {
            int nuevoAño = -1;
            bool resultado = int.TryParse(textAño.Text, out nuevoAño);
            if (resultado && nuevoAño > 1900 && nuevoAño < 2101)
            {
                textAño.Text = nuevoAño.ToString();
                e.Cancel = false;
                errorAño.SetError(textAño, "");

            }
            else
            {
                errorAño.SetError(textAño, "El valor debe ser un número entre 1900 y 2100");
                e.Cancel = true;
            }
        }

        private void textCuantia_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void ConferenciaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.Desconectar();
        }

        private void textPaginas_Validating(object sender, CancelEventArgs e)
        {
            int nuevo = -1;
            bool resultado = int.TryParse(textPaginas.Text, out nuevo);
            if (resultado && nuevo > 0)
            {
                textPaginas.Text = nuevo.ToString();
                e.Cancel = false;
                errorPaginas.SetError(textPaginas, "");

            }
            else
            {
                errorPaginas.SetError(textPaginas, "El valor debe ser un número positivo");
                e.Cancel = true;
            }
        }

        private void textCitas_Validating(object sender, CancelEventArgs e)
        {
            int nuevo = -1;
            bool resultado = int.TryParse(textCitas.Text, out nuevo);
            if (resultado && nuevo > 0)
            {
                textCitas.Text = nuevo.ToString();
                e.Cancel = false;
                errorCitas.SetError(textCitas, "");

            }
            else
            {
                errorCitas.SetError(textCitas, "El valor debe ser un número positivo");
                e.Cancel = true;
            }
        }

        private void textCategoria_Validating(object sender, CancelEventArgs e)
        {
            string a = textCategoria.Text;
            if (a == "A*" || a == "A" || a == "B" || a == "C")
            {
                e.Cancel = false;
                errorCategoria.SetError(textCategoria, "");
            }
            else
            {
                errorCategoria.SetError(textCategoria, "El valor debe ser A*, A,B o C");
                e.Cancel = true;
            }
        }
    }
}
