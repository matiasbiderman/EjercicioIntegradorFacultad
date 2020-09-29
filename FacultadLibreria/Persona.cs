using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    class Persona
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
       /* public int Edad
        {
            get
            { return this._fechaNac; }
            set
            {
                this._fechaNac = value;
            }
        }*/

        public string GetCredencial()
        {

        }
        public string GetNombreCompleto()
        {

        }
    }
}
