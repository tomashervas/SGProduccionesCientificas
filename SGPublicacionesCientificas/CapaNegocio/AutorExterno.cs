using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class AutorExterno : Autor
    {
        public AutorExterno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            deUniversidad = false;
        }
        public AutorExterno()
        {
            ID = AutorExtForm.IDactualAutor + 1;
            deUniversidad = false;
        }
    }
}
