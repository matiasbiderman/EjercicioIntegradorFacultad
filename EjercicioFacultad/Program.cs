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
                        ModificarAlumno(facultad);
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
                Console.WriteLine(ex.Message);
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
            string opcionMenuDatoAlumno;

            const string Nombre = "A";
            const string Apellido = "B";
            const string FechaNac = "C";
            const string Codigo = "D";
            const string Salir = "S";


            opcionMenuDatoAlumno = ServValidac.PedirStrNoVac("Elija el dato a modificar del alumno:\n"
               + Nombre + ": Nombre alumno\n"
               + Apellido + ": Apellido alumno\n"
               + FechaNac + ": FechaNac alumno\n"
               + Codigo + ": Codigo alumno\n"
               + Salir + ": Salir\n");

            Console.WriteLine(facultad.ListarAumnos());
            int codigoAlumno = ServValidac.PedirInt("Ingrese el codigo de alumno a eliminar");
            
            facultad.ModificarAlumno(codigoAlumno, opcionMenuDatoAlumno);


        }
        private static void ModificarEmpleado(Facultad facultad)
        {

        }
    }
}
