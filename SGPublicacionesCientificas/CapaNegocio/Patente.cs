using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    class Patente : ProduccionCientifica
    {
        public string FechaVencimiento { get; set; }
        public double Cuantia { get; set; }
        public Patente(string titulo, int año, string vencimiento, double cuantia)
        {
            Titulo = titulo;
            Año = año;
            FechaVencimiento = vencimiento;
            Cuantia = cuantia;
        }
    }
}
