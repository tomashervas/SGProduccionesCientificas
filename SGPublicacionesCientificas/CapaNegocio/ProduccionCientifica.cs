using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class ProduccionCientifica
    {
        protected bool Equals(ProduccionCientifica other)
        {
            return ID == other.ID;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ProduccionCientifica) obj);
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public int ID { get; set; }
        public string Titulo { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }

        public ProduccionCientifica(string titulo, int año)
        {
            Titulo = titulo;
            Año = año;
        }

        public ProduccionCientifica()
        {

        }
    }
}
