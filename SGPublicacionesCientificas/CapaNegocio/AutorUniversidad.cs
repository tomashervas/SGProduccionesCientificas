using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaNegocio
{
    public class AutorUniversidad : Autor
    {
        public string DNI { get; set; }
        public int Edad { get; set; }
        public string Departamento { get; set; }

        public AutorUniversidad(string nombre, string apellido, string dni, int edad, string departamento)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Edad = edad;
            Departamento = departamento;
            deUniversidad = true;
            
        }

        public AutorUniversidad()
        {
            ID = AutorUniForm.IDactualAutor + 1;
            deUniversidad = true;
        }


    }
}
