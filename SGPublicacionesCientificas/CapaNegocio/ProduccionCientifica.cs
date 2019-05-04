using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public abstract class ProduccionCientifica
    {
        protected static int ContadorProduccion = 1;
        public int ID { get; } = ContadorProduccion;
        public string Titulo { get; set; }
        public int Año { get; set; }
    }
}
