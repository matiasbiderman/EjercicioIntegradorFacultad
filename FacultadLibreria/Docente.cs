﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    class Docente : Empleado
    {
        public Docente(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo) :
            base(nombre, apellido, fechaNac, fechaIngreso, legajo)
        {

        }
        public override string GetNombreCompleto()
        {
            return "Docente  ";// falta nombre;
        }
    }
}
