﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    class Bedel : Empleado
    {
        private string _apodo;
        public override string GetNombreCompleto()
        {
            return "Bedel " + this._apodo;
        }
        public string Apodo
        {
            get
            {
                return this._apodo;
            }
            set
            {
                this._apodo = value;
            }
        }
    }
}
