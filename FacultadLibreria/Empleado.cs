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

        public void AgregarSalario(Salario salario)
        {

        }
        public bool Equals(object)
        {

        }
        public string GetCredencial()
        {

        }
        public string GetNombreCompleto()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int Antiguedad()
        {

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
        public DateTime FechaNacimiento()
        {
           
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

            }
            set
            {

            }
        }
        public Salario UltimoSalario()
        {

        }
    }
}
