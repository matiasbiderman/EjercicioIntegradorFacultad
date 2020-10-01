using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class Alumno : Persona
    {
        private int _codigo;

        public override string ToString()
        {
            return GetCredencial();
        }
        public int Codigo
        {
            get
            { return this._codigo; }
            set
            {
                this._codigo = value;
            }
        }
        public override string GetCredencial()
        {
            return "Código " + this._codigo + "\t" + GetNombreCompleto();
        }
    }
}
