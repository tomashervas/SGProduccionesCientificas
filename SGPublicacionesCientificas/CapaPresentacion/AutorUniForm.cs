using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public List<AutorUniversidad> autoresUni;
        private bool FilaSeleccionada = false;
        public static int IDactualAutor { get; set; }
        private ICollection<ProduccionCientifica> ListaProducciones = new List<ProduccionCientifica>();
        private string nombre;

        /// <summary>
        /// Metodo que permite buscar un autor de universidad al hacer click en el datagrid
        /// </summary>
        /// <returns></returns>
        private AutorUniversidad BuscarSeleccionado()
        {
            int id = (int)dataGridAutoresUni.SelectedRows[0].Cells[0].Value;
            AutorUniversidad autor = null;
            foreach (AutorUniversidad a in autoresUni)
            {
                if(a.ID == id)
                {
                    autor = a;
                    break;
                }
            }
            /*AutorUniversidad autor = new AutorUniversidad();
            autor = (AutorUniversidad)dataGridAutoresUni.CurrentRow.DataBoundItem;funciona con DataSource*/
            return autor;
        }

        /// <summary>
        /// Metodo que rellena el datagrid a partir de una lsita de autores de universidad
        /// </summary>
        private void RellenarDataGrid()
        {
            dataGridAutoresUni.Rows.Clear();
            foreach(AutorUniversidad autor in autoresUni)
            {
                dataGridAutoresUni.Rows.Add(autor.ID, autor.Nombre, autor.Apellido,autor.Departamento, autor.DNI, autor.Edad);
            }
        }
   
        public AutorUniForm()
        {
            BBDD.Conectar("tomas");
            autoresUni = (List<AutorUniversidad>)AutorUniversidadDAO.MostrarTodo();
            InitializeComponent();
            //dataGridAutoresUni.DataSource = autoresUni;
            RellenarDataGrid();
            
        }

        private void AutorUniForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.Desconectar();
        }

        /// <summary>
        /// Método que permite rellenar los datos del formulario y así modificarlo
        /// </summary>
        private void RellenarForm()
        {
            AutorUniversidad autor = new AutorUniversidad();
            autor = BuscarSeleccionado();
            textNombreUni.Text = autor.Nombre;
            textApellidoUni.Text = autor.Apellido;
            textDNI.Text = autor.DNI;
            textDepartamentoUni.Text = autor.Departamento;
            textEdad.Text = autor.Edad.ToString();
        }

        
        private void dataGridAutoresUni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RellenarForm();
            FilaSeleccionada = true;
            nombre = BuscarSeleccionado().Nombre;
            Console.WriteLine(nombre);
        }

        /// <summary>
        /// Método para insertar un nuevo autor
        /// </summary>
        private void InsertarAutorUni()
        {
            IDactualAutor = AutorExternoDAO.IDactual();
            AutorUniversidad autor = new AutorUniversidad();
            if (textNombreUni.Text.Trim() == "" || textApellidoUni.Text.Trim() == "" || textEdad.Text.Trim() == "")
            {
                MessageBox.Show("Debe rellenar los campos primero");
            }
          
            else{
                autor.Nombre = textNombreUni.Text;
                autor.Apellido = textApellidoUni.Text;
                autor.DNI = textDNI.Text;
                autor.Departamento = textDepartamentoUni.Text;
                autor.Edad = int.Parse(textEdad.Text);
                //Console.WriteLine(autoresUni.Count());
                autoresUni.Add(autor);
                //Console.WriteLine(autoresUni.Count());
                AutorUniversidadDAO.Insertar(autor);
                MessageBox.Show("Registro guardado con éxito");
                BorrarForm();
                RellenarDataGrid();
            }
        }

        /// <summary>
        /// Metodo para eliminar un autor de la base de datos y de la memoria del programa
        /// </summary>
        private void EliminarAutor()
        {
            AutorUniversidad autor = BuscarSeleccionado();
            //Console.WriteLine(autoresUni.Count());
            dataGridAutoresUni.Rows.Remove(dataGridAutoresUni.SelectedRows[0]);
            AutorUniversidadDAO.BorrarRegistro(autor);
            autoresUni.Remove(autor);
            //Console.WriteLine(autoresUni.Count());
        }

        /// <summary>
        /// Método que a través de DAO permite modificar un autor en la bbdd y en la memoria
        /// </summary>
        private void ModificarAutorUni()
        {
            AutorUniversidad autor = BuscarSeleccionado();
            autor = BuscarSeleccionado();
            autor.Nombre = textNombreUni.Text;
            autor.Apellido = textApellidoUni.Text;
            autor.DNI = textDNI.Text;
            autor.Departamento = textDepartamentoUni.Text;
            autor.Edad = int.Parse(textEdad.Text);

            int indice = autoresUni.IndexOf(autor);
            if(indice >= 0)
            {
                autoresUni[indice] = autor;
            }
            AutorUniversidadDAO.ActualizarRegistro(autor);
            MessageBox.Show("Registro modificado con éxito");
            RellenarDataGrid();
        }

        private void guardarBoton_Click(object sender, EventArgs e)
        {
            if (FilaSeleccionada)
            {
                ModificarAutorUni();
                FilaSeleccionada = false;
            }
            else
            {
                InsertarAutorUni();
            }
        }

        /// <summary>
        /// Metodo para borrar el formulario
        /// </summary>
        private void BorrarForm()
        {
            textNombreUni.Clear();
            textApellidoUni.Clear();
            textDNI.Clear();
            textDepartamentoUni.Clear();
            textEdad.Clear();
            
        }

        private void BorrarBoton_Click(object sender, EventArgs e)
        {
            BorrarForm();
            FilaSeleccionada = false;
        }

        private void EliminarAutorBoton_Click(object sender, EventArgs e)
        {
            if (dataGridAutoresUni.SelectedRows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que quiere eliminar este registro de forma permanente?", "Eliminar autor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(respuesta == DialogResult.Yes)
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

        /// <summary>
        /// Método que comprueba si el texto introducido es un número entre 1 y 149
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEdad_Validating(object sender, CancelEventArgs e)
        {
            int nuevaEdad = -1;
            bool resultado = int.TryParse(textEdad.Text, out nuevaEdad);
            if (resultado && nuevaEdad > 0 && nuevaEdad < 150)
            {
                textEdad.Text = nuevaEdad.ToString();
                e.Cancel = false;
                errorEdad.SetError(textEdad,"");
            }
            else
            {
                errorEdad.SetError(textEdad, "El valor debe ser un número entre 1 y 149");
                e.Cancel = true;
            }
        }
    }
}
