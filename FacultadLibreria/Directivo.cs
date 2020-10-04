using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class Directivo : Empleado
    {
        public Directivo(string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso, int legajo, double bruto) :
           base(nombre, apellido, fechaNac, fechaIngreso, legajo, bruto)
        {

        }
        public override string GetNombreCompleto()
        {
            return "Sr. Director  " + Apellido;// + falta apellido;
        }
    }
}
