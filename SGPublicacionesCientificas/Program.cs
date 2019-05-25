using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGPublicacionesCientificas.CapaNegocio;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());

            //BBDD.Conectar("root");
            /*AutorUniversidad Jose = new AutorUniversidad("Jose", "Hervas", "53601857N", 33, "Matemáticas");
            Console.WriteLine(Jose.ID);
            AutorUniversidad Jose2 = new AutorUniversidad("Jose", "Hervas", "53601857N", 33, "Matemáticas");
            Console.WriteLine(Jose2.ID);
            Console.WriteLine(Jose2.DNI + " " + Jose2.Nombre);
            AutorExterno pilu = new AutorExterno("Pilu", "Fernández");
            Console.WriteLine(pilu.ID + " " + pilu.Nombre);
            AutorUniversidad Jose3 = new AutorUniversidad("Jose", "Hervas", "53601857N", 33, "Matemáticas");
            Console.WriteLine(Jose3.ID);*/
            //AutorUniversidadDAO.Insertar(Jose);
            //Jose.DNI = "22650078T";
            //Jose.Edad = 25;
            //AutorUniversidadDAO.ActualizarRegistro(Jose);
            //AutorUniversidadDAO.BorrarRegistro(Jose);
            //Console.WriteLine("Hola");
            /*ICollection<AutorUniversidad> autores = AutorUniversidadDAO.BuscarAutorUniversidadPorNombre("Jose");
            foreach (AutorUniversidad autor in autores)
            {
                Console.WriteLine(autor.ID + " " + autor.Nombre + " " + autor.Apellido + " " + autor.DNI + " " + autor.Edad + " " + autor.Departamento);
            }*/
            //Console.WriteLine(autores.Count());
            //AutorUniversidad autor2 = AutorUniversidadDAO.BuscarAutorUniversidadPorID(1);
            //Console.WriteLine(autor2.ID + " " + autor2.Nombre + " " + autor2.Apellido + " " + autor2.DNI + " " + autor2.Edad + " " + autor2.Departamento);
            //Console.WriteLine("hola");

            //----------------------Probando DAO Autor Externo-----------------------------------------------
            /*AutorExterno pilu = new AutorExterno("Pilu", "Fernández");
            AutorExternoDAO.Insertar(pilu);
            pilu.Apellido = "Accino";
            AutorExternoDAO.ActualizarRegistro(pilu);*/
            //AutorExternoDAO.BorrarRegistro(pilu);
            /*ICollection<AutorExterno> autores = AutorExternoDAO.MostrarTodo();
            foreach (AutorExterno autor in autores)
            {
                Console.WriteLine(autor.ID + " " + autor.Nombre + " " + autor.Apellido);
            }
            Console.WriteLine(autores.Count());*/
            //AutorUniversidad a1 = new AutorUniversidad("tomas","garcia","47123456n",45,"geologia");
            //Console.WriteLine(a1.ID);

            //------------------------Probando DAO Patente-------------------------------------------------------

            /*ICollection<Patente> patentes = PatenteDAO.MostrarTodo();
            foreach (Patente pat in patentes)
            {
                Console.WriteLine(pat.ID + " " + pat.Titulo + " " + pat.Año + " " + pat.Cuantia +" "+ pat.FechaVencimiento);
            }*/

            //Patente pat1 = new Patente("patenteX", 2014, "2029-01-25",2000);
            //pat1.ID = 2;
            //PatenteDAO.BorrarRegistro(pat1);
            //PatenteDAO.Insertar(pat1);

            //Console.WriteLine(PatenteDAO.IDactual());
            

            //BBDD.Desconectar();
        }
    }
}
