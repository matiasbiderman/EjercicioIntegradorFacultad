﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    abstract public class Persona
    {
        private string _apellido;
        private string _nombre;
        private DateTime _fechaNac;

        public Persona(string nombre, string apellido, DateTime fecha)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fecha;
        }

        public string Apellido
        {
            get
            { return this._apellido; }
            set
            {
                this._nombre = value;
            }
        }
        public string Nombre
        {
            get
            { return this._nombre; }
            set
            {
                this._nombre = value;
            }
        }
        public DateTime FechaNac
        {
            get
            { return this._fechaNac; }
            set
            {
                this._fechaNac = value;
            }
        }
        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - this._fechaNac.Year;
                    return edad;
            }
        }

        public abstract string GetCredencial();
        public virtual string GetNombreCompleto()
        {
            return "Apellido " + this._apellido + " Nombre " + this._nombre;
        }
    }
}
