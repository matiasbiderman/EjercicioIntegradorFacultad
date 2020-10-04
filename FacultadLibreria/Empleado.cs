using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    abstract public class Empleado : Persona
    {
        private DateTime _fechaingreso;
        private int _legajo;
        private List<Salario> _salarios;

        public Empleado(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo) :
          base(nombre, apellido, fechaNac)
        {
            this._fechaingreso = fechaIngreso;
            this._legajo = legajo;
            _salarios = new List<Salario>();
        }
        public void AgregarSalario(Salario salario)
        {
            Salarios.Add(salario);
        }
      public override bool Equals(object obj)
        {
            return obj != null && obj is Empleado && this._legajo == ((Empleado)obj).Legajo;

        }
        public override string GetCredencial()
        {
            return "Legajo " + this._legajo + "-" + GetNombreCompleto();// + "Salario $ " + UltimoSalario().GetSalarioNeto();
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public int Antiguedad()
        {
            int antiguedad = DateTime.Now.Year - this._fechaingreso.Year;
            return antiguedad;
        }
        public DateTime FechaIngreso
        {
            get
            {
                return this._fechaingreso;
            }
            set
            {
                this._fechaingreso = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return this.FechaNac;
            }
            set
            {
                this.FechaNac = value;
            }
        }
        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public List<Salario> Salarios
        {
            get
            {
                return _salarios;
            }
           
        }
        public Salario UltimoSalario()
        {
            return Salarios.Last();
        }
    }
}
