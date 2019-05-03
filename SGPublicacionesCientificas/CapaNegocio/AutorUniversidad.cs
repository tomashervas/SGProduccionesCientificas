﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPublicacionesCientificas.CapaNegocio
{
    class AutorUniversidad : Autor
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
            Contador = Contador + 1;
        }
    }
}
