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
                if (getAlumnoByCodigoDuplicado(alumno.Codigo))
                {
                    throw new CodigoAlumnoInvalidoException();
                }
                else if (alumno.Edad < 18)
                {
                    throw new MenorDeEdadException();

                }
                else
                {
                    _alumnos.Add(alumno);
                }
            }
            else
            {
                throw new ExisteAlumnoException();
            }
        }
        public void AgregarEmpleado(Empleado empleado)
         {
            if (empleado.Equals(empleado))
            {

                if (this._empleados.SingleOrDefault(x => x.Legajo == empleado.Legajo) != null)
                {
                    throw new LegajoInvalidoException();
                }
                else if (empleado.Edad < 18)
                {
                    throw new MenorDeEdadException();
                }
                else
                {
                    _empleados.Add(empleado);
                }
            }
            else
            {
                throw new ExisteAlumnoException();
            }
         }
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
            Empleado empleado = TraerEmpleadoPorLegajo(legajo);
            if (empleado == null)
                throw new Exception("No se pudo borrar el empleado");
            else
            _empleados.Remove(empleado);
        }
        public void ModificarAlumno(Alumno alumnonuevo)
        {
            if (alumnonuevo.Edad >= 18)
            {
                for (int i = 0; i < _alumnos.Count; i++)
                {
                    if (_alumnos[i].Codigo == alumnonuevo.Codigo)
                    {
                        _alumnos[i] = alumnonuevo;
                    }
                }
            }
            else
            {
                throw new MenorDeEdadException();
            }
        }
        public string getAlumnosByCodigo(int codigo)
        {
            string lista = "";
            foreach (Alumno alumno in _alumnos)
            {
                if (codigo == alumno.Codigo)
                {
                    lista += alumno.ToString() + "\n";
                }
            }
            if (lista == "")
            {
                lista = "No se encuentran alumnos listados, ingrese uno";
            }
            return lista;
        }

        public bool getAlumnoByCodigoDuplicado(int codigo)
        {
            bool encuentra = false;
            foreach (Alumno alumno in _alumnos)
            {
                if (codigo == alumno.Codigo)
                {
                    encuentra = true;
                }
            }
            if (encuentra)
            {
                return encuentra;
            }
            return encuentra;
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
            if (lista == "")
            {
                lista = "No hay alumnos disponibles, ingrese uno";
            }
            return lista;
        }
        public string ListarEmpleados()
        {
            string lista = "";
            foreach (Empleado empleado in _empleados)
            {
                lista += empleado.ToString() + "\n";
            }
            if (lista == "")
            {
                lista = "No hay empleados disponibles, ingrese uno";
            }
            return lista;
        }

        /*
        public List<Empleado> TraerEmpleados()
        {

        }
        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {

        }*/
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            foreach (Empleado e in _empleados)
            {
                if (legajo == e.Legajo)
                    return e;
            }
            return null;
        }
    }
}
