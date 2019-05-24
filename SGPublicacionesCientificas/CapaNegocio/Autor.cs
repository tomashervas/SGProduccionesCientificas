using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaDAOs;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public abstract class Autor
    {
        
        protected static int ContadorAutor = (AutorForm.IDactualAutor)+1;
        public int ID { get; set; } = ContadorAutor;
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
