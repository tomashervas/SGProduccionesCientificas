using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGPublicacionesCientificas.CapaNegocio;

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
            //Application.Run(new Form1());
            AutorUniversidad Jose = new AutorUniversidad("Jose", "Hervas", "53601857N", 33, "Matemáticas");
            Console.WriteLine(Jose.ID);
            AutorUniversidad Jose2 = new AutorUniversidad("Jose", "Hervas", "53601857N", 33, "Matemáticas");
            Console.WriteLine(Jose2.ID);
            Console.WriteLine(Jose2.DNI + " " + Jose2.Nombre);
            AutorExterno pilu = new AutorExterno("Pilu", "Fernández");
            Console.WriteLine(pilu.ID + " " + pilu.Nombre);
            AutorUniversidad Jose3 = new AutorUniversidad("Jose", "Hervas", "53601857N", 33, "Matemáticas");
            Console.WriteLine(Jose3.ID);
        }
    }
}
