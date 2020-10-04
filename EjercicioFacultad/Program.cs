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
            const string AltaEmpleados = "D";
            const string AltaAlumnos = "C";
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
                        Console.WriteLine(facultad.ListarEmpleados());
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
            catch (MenorDeEdadException ed)
            {
                Console.WriteLine(ed.Message);
            }

        }
        private static void InsertarEmpleado(Facultad facultad)
        {
            int opcionMenu;
            do
            {
                opcionMenu = ServValidac.PedirInt("Elija un tipo de empleado a ingresar:\n"
                    + (int)TipoEmpleado.Bedel + ": Bedel\n"
                    + (int)TipoEmpleado.Docente + ": Docente\n"
                    + (int)TipoEmpleado.Directivo + ": Directivo\n");

                if (opcionMenu != (int)TipoEmpleado.Bedel && opcionMenu != (int)TipoEmpleado.Docente && opcionMenu != (int)TipoEmpleado.Directivo)
                {
                    Console.WriteLine("Vuelva a Ingresar un tipo de empleado");
                }
                if (opcionMenu == (int)TipoEmpleado.Bedel)
                {
                    string apodoBedel = ServValidac.PedirStrNoVac("Ingrese apodo del Bedel");
                    string nombreBedel = ServValidac.PedirStrNoVac("Ingrese nombre del Bedel");
                    int legajoBedel = ServValidac.PedirInt("Ingrese legajo del Bedel");
                    string apellidoBedel = ServValidac.PedirStrNoVac("Ingrese apellido del Bedel");
                    DateTime fechanacBedel = ServValidac.PedirFechaNac("Ingrese fecha de nacimiento del Bedel");
                    DateTime fechaIngresoBedel = ServValidac.PedirFechaNac("Ingrese fecha de ingreso del Bedel");
                    Empleado empleado = new Bedel(nombreBedel, apodoBedel, apellidoBedel, fechanacBedel, fechaIngresoBedel, legajoBedel);
                    ValidoExcepciones(facultad, empleado);
                }
                else if (opcionMenu == (int)TipoEmpleado.Docente)
                {
                    string nombreDocente = ServValidac.PedirStrNoVac("Ingrese nombre del docente");
                    string apellidoDocente = ServValidac.PedirStrNoVac("Ingrese apellido del docente");
                    DateTime fechanacDocente = ServValidac.PedirFechaNac("Ingrese fecha de nacimiento del docente");
                    DateTime fechaIngresoDocente = ServValidac.PedirFechaNac("Ingrese fecha de ingreso del docente");
                    int legajoDocente = ServValidac.PedirInt("Ingrese legajo del docente");
                    Empleado empleado = new Docente(nombreDocente, apellidoDocente, fechanacDocente, fechaIngresoDocente, legajoDocente);
                    ValidoExcepciones(facultad, empleado);
                }
                else if (opcionMenu == (int)TipoEmpleado.Directivo)
                {
                    string apellidoDirectivo = ServValidac.PedirStrNoVac("Ingrese apellido del directivo");
                    string nombreDirectivo = ServValidac.PedirStrNoVac("Ingrese nombre del Directivo");
                    DateTime fechanacDirectivo = ServValidac.PedirFechaNac("Ingrese fecha de nacimiento del Directivo");
                    DateTime fechaIngresoDirectivo = ServValidac.PedirFechaNac("Ingrese fecha de ingreso del Directivo");
                    int legajoDirectivo = ServValidac.PedirInt("Ingrese legajo del Directivo");
                    Empleado empleado = new Directivo(nombreDirectivo, apellidoDirectivo, fechanacDirectivo, fechaIngresoDirectivo, legajoDirectivo);
                    ValidoExcepciones(facultad, empleado);

                }
            } while (opcionMenu != (int)TipoEmpleado.Bedel && opcionMenu != (int)TipoEmpleado.Docente && opcionMenu != (int)TipoEmpleado.Directivo);
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
            try
            {
                Console.WriteLine(facultad.ListarEmpleados());
                int legajo = ServValidac.PedirInt("Ingrese legajo del empleado a eliminar");
                facultad.EliminarEmpleado(legajo);
            }
            catch (EmpleadoExistenteException ee)
            {
                Console.WriteLine(ee.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ValidoExcepciones(Facultad facultad, Empleado empleado)
        {
            try
            {
                facultad.AgregarEmpleado(empleado);
                Console.WriteLine("\nEl empleado " + empleado.ToString() + " fue agregado con exito!");
            }
            catch (LegajoInvalidoException li)
            {
                Console.WriteLine(li.Message);
            }
            catch (MenorDeEdadException md)
            {
                Console.WriteLine(md.Message);
            }
            catch (EmpleadoExistenteException ee)
            {
                Console.WriteLine(ee.Message);   
            }
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
            try
            {
                facultad.ModificarAlumno(alumno);
                Console.WriteLine("El alumno quedo modificado de la siguiente manera: \n" + facultad.getAlumnosByCodigo(codigoAlumno));
            }
            catch (MenorDeEdadException ed)
            {
                Console.WriteLine(ed.Message);
            }
        }
        private static void ModificarEmpleado(Facultad facultad)
        {
        }
    }
}
