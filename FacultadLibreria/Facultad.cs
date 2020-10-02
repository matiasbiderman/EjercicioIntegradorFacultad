using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            if (alumno.Equals(alumno))
            {
                _alumnos.Add(alumno);
            }
            else
            {
                throw new ExisteAlumnoException();
            }

        }
        /* public void AgregarEmpleado(Empleado empleado)
         {

         }*/
        public void EliminarAlumno(int codigo)
        {
            int indice = -1;
            
            foreach (Alumno alu in _alumnos)
            {

                if (codigo == alu.Codigo)
                {
                    indice = _alumnos.IndexOf(alu);
                }
            }
            if (indice != -1) //ver de tirar la excepcion y que siga el programa
            {
                _alumnos.RemoveAt(indice);
            }
            else
            {
                throw new CodigoAlumnoInvalidoException();
            }
        }
        public void EliminarEmpleado(int legajo)
        {

        }
        /*public void ModificarEmpleado(Empleado empleado)
        {

        }
       */
        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }
        public string ListarAumnos()
        {
            string lista = "";
            foreach (Alumno alumno in _alumnos)
            {
                lista += alumno.ToString() + "\n";
            }
            if(lista == "")
            {
                lista = "No se encuentran alumnos listados, ingrese uno";
            }
            return lista;
        }

        /*
        public List<Empleado> TraerEmpleados()
        {

        }
        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {

        }
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {

        }*/
    }
}
