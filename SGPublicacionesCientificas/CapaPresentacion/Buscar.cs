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
using Org.BouncyCastle.Bcpg;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaNegocio;

namespace SGPublicacionesCientificas.CapaPresentacion
{
    public partial class Buscar : Form
    {
        //Creamos una lista de producciones que almacenará las producciones de las búsquedas
        public ICollection<ProduccionCientifica> ListaProducciones = new List<ProduccionCientifica>();
        private string nombre;

        public Buscar()
        {
            BBDD.Conectar("tomas");
            InitializeComponent();
        }

        /// <summary>
        /// Funcion que utilizamos para rellenar el dataGrid con ListaProducciones
        /// </summary>
        private void RellenarDataGrid()
        {
            dataGridProducciones.Rows.Clear();
            foreach (ProduccionCientifica produccion in ListaProducciones)
            {
                dataGridProducciones.Rows.Add(produccion.ID, produccion.Titulo, produccion.Año, produccion.Tipo);
            }
        }


        //Creamos en el evento del boton de búsqueda 4 ifs que controlan las opciones de búsqueda por tipo mediante radiobuttons
        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            if (radioTodos.Checked)
            {
                nombre = textNombre.Text;
                ListaProducciones = ProduccionDAO.BuscarProduccionPorAutor(nombre);
                RellenarDataGrid();
            }

            else if(radioPatente.Checked)
            {
                nombre = textNombre.Text;
                ListaProducciones = ProduccionDAO.BuscarProduccionPorTipo("patente", nombre);
                RellenarDataGrid();
            }

            else if (radioConferencia.Checked)
            {
                nombre = textNombre.Text;
                ListaProducciones = ProduccionDAO.BuscarProduccionPorTipo("conferencia", nombre);
                RellenarDataGrid();
            }

            else
            {
                nombre = textNombre.Text;
                ListaProducciones = ProduccionDAO.BuscarProduccionPorTipo("revista", nombre);
                RellenarDataGrid();
            }
        }

        private void Buscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.Desconectar();
        }
    }
}
