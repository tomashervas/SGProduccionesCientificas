using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public abstract class ArticuloCientifico : ProduccionCientifica
    {
        public int Paginas { get; set; }
        public int Citas { get; set; }
        public string DOI { get; set; }
    }
}
