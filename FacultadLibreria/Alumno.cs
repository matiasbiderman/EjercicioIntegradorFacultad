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
        public Alumno(string nombre, string apellido, DateTime fechaNac, int codigo) : base(nombre, apellido, fechaNac)
        {
            this._codigo = codigo;
        }
        
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

        public override bool Equals(object obj)
        {
            return obj != null && obj is Alumno && this._codigo == ((Alumno)obj).Codigo;

        }
        public override string GetCredencial()
        {
            return "Código " + this._codigo + "\t" + GetNombreCompleto();
        }
    }
}
