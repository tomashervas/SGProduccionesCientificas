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
        public ICollection<int> ListaIDAutoresPublicacion = new List<int>();
        public ICollection<AutorExterno> ListaAutoresPublicacion = new List<AutorExterno>();
        public ICollection<AutorExterno> ListaAutoresCompleta = new List<AutorExterno>();
        private bool modificado = false;
        private bool FilaSeleccionada = false;
        public static int IDactualProduccion { get; set; }
        private AutorExterno AutorSeleccionado = null;
        private Patente PatenteSeleccionada = null;

        /// <summary>
        /// Metodo para encontrar por id una patente dentro de una lista
        /// </summary>
        /// <returns>Objeto de tipo patente</returns>
        private Patente BuscarSeleccionado()
        {
            int id = (int)dataGridPatente.SelectedRows[0].Cells[0].Value;
            Patente patente = null;
            foreach (Patente a in ListaPatentes)
            {
                if (a.ID == id)
                {
                    patente = a;
                    break;
                }
            }
            return patente;
        }

        /// <summary>
        /// Metodo para encontrar por id un autor  dentro de una lista
        /// </summary>
        /// <returns>Devuelve un objeto de tipo AutorExterno</returns>
        private AutorExterno BuscarAutorSeleccionado()
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

        /// <summary>
        /// Metodo que recorre la lista de patentes y va rellenando el DataGridView
        /// </summary>
        private void RellenarDataGrid()
        {
            dataGridPatente.Rows.Clear();
            foreach (Patente patente in ListaPatentes)
            {
                dataGridPatente.Rows.Add(patente.ID, patente.Titulo, patente.Año, patente.Cuantia, patente.FechaVencimiento.Date);
            }
        }

        /// <summary>
        /// Método para rellenar un datagrid con objetos de tipo AutorExterno, ya que en esta lista se encuentran todos los autores
        /// y nos permite sellecionarlos para rellenar una nueva patente
        /// </summary>
        /// <param name="data">Objeto de tipo dataGridView</param>
        /// <param name="lista">Lista de autorExterno</param>
        private void RellenarDataAutores(DataGridView data, List<AutorExterno> lista)
        {
            data.Rows.Clear();
            foreach (AutorExterno autor in lista)
            {
                data.Rows.Add(autor.ID, autor.Nombre, autor.Apellido);
            }
        }


        public PatenteForm()
        {
            BBDD.Conectar("tomas");
            ListaPatentes = (List<Patente>) PatenteDAO.MostrarTodo();
            InitializeComponent();
            RellenarDataGrid();
            ListaAutoresCompleta = AutorExternoDAO.MostrarExternosInternos();
            RellenarDataAutores(dataGridAutores, (List<AutorExterno>)ListaAutoresCompleta);
        }

        /// <summary>
        /// Método que permite rellenar el formularrio, una vez llamado el evento de click en una casilla del datagrid, así
        /// nos permite modificar los textbox y modificar la patente en el mismo form
        /// </summary>
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

        /// <summary>
        /// metodo que permite rellenar el formulario de una nueva patente, es llamado una vez se ha rellenado, sino salta un messagebox avisando,
        /// después borra de nuevo el formulario y actualiza el datagrid, también llama el método insertar del DAO patente para
        /// reflejar el resultado en la base de datos
        /// </summary>
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
                foreach (int id in ListaIDAutoresPublicacion)
                {
                    PatenteDAO.InsertarPublicaPatente(id, patente.ID);
                }
                MessageBox.Show("Registro guardado con éxito");
                BorrarForm();
                RellenarDataGrid();
            }
        }

        /// <summary>
        /// Método que elimina la patente seleccionada del datagrid y llama al dao para elimanarla de la base de datos
        /// </summary>
        private void Eliminar()
        {
            Patente patente = BuscarSeleccionado();
            dataGridPatente.Rows.Remove(dataGridPatente.SelectedRows[0]);
            PatenteDAO.BorrarRegistro(patente);
            ListaPatentes.Remove(patente);
        }

        /// <summary>
        /// Metdodo que una vez seleccionado la patente en el datagrid, rellena el formulario y permite modificar la informacion en el
        /// la memoria y en la base de datos
        /// </summary>
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

        /// <summary>
        /// Método que lla a los metodos modificar o insertar según se haya seleccionado una patente del datagrid o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Método que borra el formulario para introducir una nueva patente
        /// </summary>
        private void BorrarForm()
        {
            textTitulo.Clear();
            textAño.Clear();
            textCuantia.Clear();
            dateTimePickerP.Text= DateTime.Today.Date.ToString();
            dataGridAutoresPublicacion.Rows.Clear();
            ListaAutoresPublicacion.Clear();

        }

        private void BorrarBoton_Click(object sender, EventArgs e)
        {
            BorrarForm();
            FilaSeleccionada = false;
        }

        /// <summary>
        /// Metodo que llama al método eliminar, antes comprueba que se haya seleccionado un registro y pregunta al usuario por
        /// confirmación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Metodo que rellena el datagrid, vacía las listas de autores relacionados con la patente y la lista total de autores,
        /// activa los métodos de rellenado de los otros 2 datagrid al hacer click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridPatente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modificado = true;
            ListaAutoresPublicacion.Clear();
            ListaIDAutoresPublicacion.Clear();
            RellenarForm();
            FilaSeleccionada = true;
            Patente patente = BuscarSeleccionado();
            PatenteSeleccionada = BuscarSeleccionado();
            ListaIDAutoresPublicacion = PatenteDAO.MostrarAutoresPublicacion(patente.ID);
            foreach (int id in ListaIDAutoresPublicacion)
            {
                AutorExterno autor = AutorExternoDAO.BuscarAutorPorID(id);
                ListaAutoresPublicacion.Add(autor);
                //Console.WriteLine(autor.Nombre);
            }
            RellenarDataAutores(dataGridAutoresPublicacion, (List<AutorExterno>)ListaAutoresPublicacion);
        }

        private void dataGridAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AutorSeleccionado = BuscarAutorSeleccionado();
        }

        /// <summary>
        /// Metodo que es llamado al hacer click en el boton flecha que hay entre los 2 datagrid de autores y permite pasar de la lsita
        /// general de todos los autores a la lista de los autores que se guardarán relacionados a la patente que damos de alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    RellenarDataAutores(dataGridAutoresPublicacion, (List<AutorExterno>)ListaAutoresPublicacion);
                }
                else
                {
                    MessageBox.Show("Seleccione primero un autor que añadir");
                }
            }
        }

        /// <summary>
        /// metodo que permite calcular la calidad de la patente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalidadBoton_Click(object sender, EventArgs e)
        {
            if (PatenteSeleccionada != null)
            {
                double resultado = Math.Round(((double)PatenteSeleccionada.FechaVencimiento.Year - DateTime.Today.Year) / (PatenteSeleccionada.FechaVencimiento.Year - PatenteSeleccionada.Año), 2);
                CalidadLbl.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione primero una patente");
            }
        }
    }
}
