using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    class Alumno : Persona
    {
        private int _codigo;

        public override string ToString()
        {
            return base.ToString();
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
       /* public string Credenciak
        {
            get
            { return this._codigo; }
            set
            {
                this._codigo = value;
            }
        }*/
    }
}
