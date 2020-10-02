using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    abstract class Empleado : Persona
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

        }
      /*  public override bool Equals(object obj)
        {
            return (obj != null && obj is Empleado && this._legajo == ((Empleado)obj).Legajo);

        }*/
        public override string GetCredencial()
        {
            return "Legajo " + this._legajo + "-" + GetNombreCompleto();// + "Salario $ " + UltimoSalario;
        }
        

        public override string ToString()
        {
            return base.ToString();
        }
      /*  public int Antiguedad()
        {
            //fecha de ingresso - fecha actual
        }*/
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
        /*public DateTime FechaNacimiento()
        {
           //
        }*/
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
        /*public List<Salario> Salarios
        {
            get
            {

            }
            set
            {

            }
        }
        public Salario UltimoSalario
        {
            get
            {

            }
            set
            {

            }
        }*/
    }
}
