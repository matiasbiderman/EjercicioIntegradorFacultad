using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacultadLibreria;

namespace EjercicioFacultad
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionMenu;

            const string ListarAlumnos = "A";
            const string ListarEmpleados = "B";
            const string AltaEmpleados = "C";
            const string AltaAlumnos = "D";
            const string BorrarAlumnos = "E";
            const string BorrarEmpleados = "F";
            const string ModificarAlumnos = "G";
            const string ModificarEmpleados = "H";
            const string Salir = "S";

            Facultad facultad = new Facultad("FCE", 17);

            do
            {
                opcionMenu = ServValidac.PedirStrNoVac("Ingrese opción:\n"
                    + ListarAlumnos + ": Listar Alumnos\n"
                    + ListarEmpleados + ": Listar Empleados\n"
                    + AltaAlumnos + ": Alta Alumno\n"
                    + AltaEmpleados + ": Alta Empleado\n"
                    + BorrarAlumnos + ": Borrar Alumno\n"
                    + BorrarEmpleados + ": Borrar Empleados\n"
                    + ModificarAlumnos + ": Modificar Alumnos\n"
                    + ModificarEmpleados + ": Modificar Empleados\n"
                    + Salir + ": Salir");

                switch (opcionMenu)
                {
                    case ListarAlumnos:
                        Console.WriteLine(facultad.ListarAumnos());
                        break;
                    case ListarEmpleados:
                        // Console.WriteLine(facultad.TraerEmpleados());
                        break;
                    case AltaAlumnos:
                        InsertarAlumno(facultad);
                        break;
                    case AltaEmpleados:
                        InsertarEmpleado(facultad);
                        break;
                    case BorrarAlumnos:
                        if (facultad.ListarAumnos() != "No se encuentran alumnos listados, ingrese uno")
                            BorrarAlumno(facultad);
                        else
                            Console.WriteLine(facultad.ListarAumnos());
                        break;
                    case BorrarEmpleados:
                        BorrarEmpleado(facultad);
                        break;
                    case ModificarAlumnos:
                        if (facultad.ListarAumnos() != "No se encuentran alumnos listados, ingrese uno")
                            ModificarAlumno(facultad);
                        else
                            Console.WriteLine(facultad.ListarAumnos());
                        break;
                    case ModificarEmpleados:
                        ModificarEmpleado(facultad);
                        break;
                    case Salir:
                        break;
                    default:
                        Console.WriteLine("Opción no existente");
                        break;
                }

            } while (opcionMenu != Salir);
        }

        private static void InsertarAlumno(Facultad facultad)
        {
            string nombre = ServValidac.PedirStrNoVac("Ingrese un nombre de alumno");
            string apellido = ServValidac.PedirStrNoVac("Ingrese un apellido de alumno");
            int codigo = ServValidac.PedirInt("Ingrese un codigo de alumno");
            DateTime fechanac = ServValidac.PedirFechaNac("Ingrese fecha de nacimiento del alumno");

            Alumno alumno = new Alumno(nombre, apellido, fechanac, codigo);
            try
            {
                facultad.AgregarAlumno(alumno);
                Console.WriteLine(alumno.ToString());
            }
            catch (ExisteAlumnoException ex)
            {
                Console.WriteLine(ex.Message); //no lo va a encontrar por ya existir
            }
            catch (CodigoAlumnoInvalidoException cd)
            {
                Console.WriteLine(cd.Message); //no lo va a encontrar ya que esta duplicado el codigo
            }

        }
        private static void InsertarEmpleado(Facultad facultad)
        {
            //pasa un empleado
        }
        private static void BorrarAlumno(Facultad facultad)
        {

            Console.WriteLine(facultad.ListarAumnos());
            int codigo = ServValidac.PedirInt("Ingrese el codigo de alumno a eliminar");
            try
            {
                facultad.EliminarAlumno(codigo);
                Console.WriteLine(facultad.ListarAumnos());
            }
            catch (CodigoAlumnoInvalidoException cd)
            {
                Console.WriteLine(cd.Message);
            }
        }
        private static void BorrarEmpleado(Facultad facultad)
        {
            //pasa un legajo
        }
        private static void ModificarAlumno(Facultad facultad)
        {
            
            Console.WriteLine("Los alumnos disponibles para su modificacion son: \n" + facultad.ListarAumnos());
            int codigoAlumno = ServValidac.PedirInt("Ingrese el codigo de alumno a modificar");
            Console.WriteLine("El alumno a modificar es: \n" + facultad.getAlumnosByCodigo(codigoAlumno));

            string nombre = ServValidac.PedirStrNoVac("Ingrese un nuevo nombre de alumno");
            string apellido = ServValidac.PedirStrNoVac("Ingrese un nuevo apellido de alumno");
            DateTime fechanac = ServValidac.PedirFechaNac("Ingrese nueva fecha de nacimiento del alumno");

            Alumno alumno = new Alumno(nombre, apellido, fechanac, codigoAlumno);
            facultad.ModificarAlumno(alumno);
            Console.WriteLine("El alumno quedo modificado de la siguiente manera: \n" + facultad.getAlumnosByCodigo(codigoAlumno));


        }
        private static void ModificarEmpleado(Facultad facultad)
        {

        }
    }
}
