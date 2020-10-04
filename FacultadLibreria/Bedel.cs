using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public Bedel(string nombre, string apodo, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo) :
           base(nombre, apellido, fechaNac, fechaIngreso, legajo)
        {
            this._apodo = apodo;
        }
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
