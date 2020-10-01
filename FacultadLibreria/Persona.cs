using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    abstract class Persona
    {
        private string _apellido;
        private string _nombre;
        private DateTime _fechaNac;

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
       public int Edad
        {
            get
            {
                DateTime now = DateTime.Today;
                int edad = DateTime.Today.Year - this._fechaNac.Year;

                if (DateTime.Today < _fechaNac.AddYears(edad))
                    return --edad;
                else
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
