using SGPublicacionesCientificas.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class Conferencia : ArticuloCientifico
    {
        //La clase conferencia hereda de articulo científico y de la clase Producción Científica
        public ICollection<Conferencia> AutoresConferencia { get; set; }
        public string NombreConferencia { get; set; }
        public string Lugar { get; set; }
        public string Categoria;
        public Conferencia(string titulo, int año, int paginas, int citas, string doi, string nombre, string lugar, string categoria )
        {
            AutoresConferencia = new List<Conferencia>();
            Titulo = titulo;
            Año = año;
            Paginas = paginas;
            Citas = citas;
            DOI = doi;
            NombreConferencia = nombre;
            Lugar = lugar;
            Categoria = categoria;
            Tipo = "conferencia";
        }

        public Conferencia()
        {
            ID = ConferenciaForm.IDactualProduccion + 1;
            Tipo = "conferencia";
        }
    }
}
