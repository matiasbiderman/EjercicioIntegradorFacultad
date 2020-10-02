using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad
{
    class ServValidac
    {
        public static string PedirStrNoVac(string mensaje)
        {
            string valor;
            Console.WriteLine(mensaje);
            do
            {
                valor = Console.ReadLine().ToUpper().Trim();
                if (valor == "")
                {
                    Console.WriteLine("ingrese una opcion valida");
                }
            } while (valor == "");
            return valor;
        }

        public static int PedirInt(string mensaje)
        {
            int valor;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    valor = -1;
                }
                if (valor < 0)
                {
                    Console.WriteLine("ingrese una opcion valida");
                }
            } while (valor < 0);

            return valor;
        }

            public static DateTime PedirFechaNac(string mensaje)
            {
                DateTime fecha;
                do
                {
                    Console.WriteLine(mensaje);
                }
                while (!DateTime.TryParse(Console.ReadLine(), out fecha));
                return fecha;
            }
    }
}
