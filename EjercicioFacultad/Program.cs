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

            Facultad facultad = new Facultad();

            do
            {
                opcionMenu = ServValidac.PedirStrNoVac("Ingrese opción:\n"
                    + ListarAlumnos + ": Encender Maquina\n"
                    + ListarEmpleados + ": Insertar lata\n"
                    + AltaAlumnos + ": Listar lata\n"
                    + AltaEmpleados + ": Extraer Lata\n"
                    + BorrarAlumnos + ": Conocer Balance\n"
                    + BorrarEmpleados + ": Conocer Stock\n"
                    + ModificarAlumnos + ": Conocer Stock\n"
                    + ModificarEmpleados + ": Conocer Stock\n"
                    + Salir + ": Salir");

                switch (opcionMenu)
                {
                    case ListarAlumnos:
                        Console.WriteLine(facultad.TraerAlumnos());
                        break;
                    case ListarEmpleados:
                        Console.WriteLine(facultad.TraerEmpleados());
                        break;
                    case AltaAlumnos:
                        InsertarAlumno(facultad);
                        break;
                    case AltaEmpleados:
                        InsertarEmpleado(facultad);
                        break;
                    case BorrarAlumnos:
                        BorrarAlumno(facultad);
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

        private static void ListarAlumno(Facultad facultad)
        {
            //pasa un alumno
        }
        private static void ListarEmpleado(Facultad facultad)
        {
            //pasa un alumno
        }
        private static void InsertarAlumno(Facultad facultad)
        {
            //pasa un alumno
        }
        private static void InsertarEmpleado(Facultad facultad)
        {
            //pasa un empleado
        }
        private static void BorrarAlumno(Facultad facultad)
        {
            //pasa un codigo de alumno
        }
        private static void BorrarEmpleado(Facultad facultad)
        {
            //pasa un legajo
        }
        private static void ModificarAlumno(Facultad facultad)
        {

        }
        private static void ModificarEmpleado(Facultad facultad)
        {

        }
    }
}
