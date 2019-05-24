using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class AutorExterno : Autor
    {
        public AutorExterno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            ContadorAutor = ContadorAutor + 1;
            deUniversidad = false;
        }
        public AutorExterno()
        {
            ContadorAutor = ContadorAutor + 1;
            deUniversidad = false;
        }
    }
}
