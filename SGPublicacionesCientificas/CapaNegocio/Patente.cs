using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    class Patente : ProduccionCientifica
    {
        public ICollection<Autor> AutoresPatente { get; set; }
        public string FechaVencimiento { get; set; }
        public double Cuantia { get; set; }
        public Patente(string titulo, int año, string vencimiento, double cuantia)
        {
            AutoresPatente = new List<Autor>();
            Titulo = titulo;
            Año = año;
            FechaVencimiento = vencimiento;
            Cuantia = cuantia;
            ContadorProduccion = ContadorProduccion + 1;
        }
    }
}
