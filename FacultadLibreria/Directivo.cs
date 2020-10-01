using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    class Directivo : Empleado
    {
        public override string GetNombreCompleto()
        {
            return "Director  " + //falta apellido;
        }
    }
}
