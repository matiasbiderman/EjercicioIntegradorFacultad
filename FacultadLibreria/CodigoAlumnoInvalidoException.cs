using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class CodigoAlumnoInvalidoException : Exception
    {
        public CodigoAlumnoInvalidoException() : base("El codigo del alumno es invalido")
        { }
    }
}
