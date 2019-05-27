using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class ArticuloRevista : ArticuloCientifico
    {
        public ICollection<Conferencia> AutoresRevista { get; set; }
        public string NombreRevista { get; set; }
        public string Editorial { get; set; }
        public double FactorImpacto;
        public ArticuloRevista(string titulo, int año, int paginas, int citas, string doi, string nombre, string editorial, double impacto)
        {
            AutoresRevista = new List<Conferencia>();
            Titulo = titulo;
            Año = año;
            Paginas = paginas;
            Citas = citas;
            DOI = doi;
            NombreRevista = nombre;
            Editorial = editorial;
            FactorImpacto = impacto;
            Tipo = "revista";
        }

        public ArticuloRevista()
        {
            //ID = RevistaForm.IDactualProduccion + 1;
            Tipo = "revista";
        }
    }
}
