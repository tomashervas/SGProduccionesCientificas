using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class Patente : ProduccionCientifica
    {
        public ICollection<Autor> AutoresPatente { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Cuantia { get; set; }
        public string Tipo { get; set; }
        public Patente(string titulo, int año, DateTime vencimiento, double cuantia)
        {
            AutoresPatente = new List<Autor>();
            Titulo = titulo;
            Año = año;
            FechaVencimiento = vencimiento.Date;
            Cuantia = cuantia;
            Tipo = "patente";
        }

        public Patente()
        {

            ID = PatenteForm.IDactualProduccion + 1;
            Tipo = "patente";
        }
    }
}
