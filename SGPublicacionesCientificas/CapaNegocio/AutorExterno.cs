using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    class AutorExterno : Autor
    {
        public AutorExterno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Contador = Contador + 1;
        }
    }
}
