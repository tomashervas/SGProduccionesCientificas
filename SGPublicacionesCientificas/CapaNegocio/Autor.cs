using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaNegocio
{
    //clase autor abstracta de la que heredan las clases autorUniverdidad y autorExterno
    public abstract class Autor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool deUniversidad { get; set; }

        public override bool Equals(object obj)
        {
            var autor = obj as Autor;
            return autor != null &&
                   ID == autor.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }
    }
}
