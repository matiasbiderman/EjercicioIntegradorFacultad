using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public Facultad(string nombre, int cantsedes)
        {
            this._nombre = nombre;
            this._cantidadSedes = cantsedes;
            this._alumnos = new List<Alumno>();
            this._empleados = new List<Empleado>();
        }
        public Facultad() { }
        public int CantidadSedes
        {
            get
            { return this._cantidadSedes; }
            set
            {
                this._cantidadSedes = value;
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
        public void AgregarAlumno(Alumno alumno)
        {

        }
        public void AgregarEmpleado(Empleado empleado)
        {

        }
        public void EliminarAlumno(int codigo)
        {

        }
        public void EliminarEmpleado(int legajo)
        {

        }
        public void ModificarEmpleado(Empleado empleado)
        {

        }
        public List<Alumno> TraerAlumnos()
        {
            Alumno alumno;
            foreach (Alumno alu in _alumnos)
            {
               
            }
        }
        public List<Empleado> TraerEmpleados()
        {

        }
        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {

        }
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {

        }
    }
}
