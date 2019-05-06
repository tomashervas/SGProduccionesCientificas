using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public abstract class Autor
    {
        //se leera desde la bbdd el ultimo id y se lo asignaremos a contador, para que sea automático y no tenga que ponerlo el usuario

        protected static int ContadorAutor = 2;
        public int ID { get; set; } = ContadorAutor;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool deUniversidad { get; set; }
    }
}
