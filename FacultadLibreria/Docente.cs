﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class Docente : Empleado
    {
        public Docente(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo, double bruto) :
            base(nombre, apellido, fechaNac, fechaIngreso, legajo, bruto)
        {

        }
        public override string GetNombreCompleto()
        {
            return "Docente  " + Nombre;// falta nombre;
        }
    }
}
