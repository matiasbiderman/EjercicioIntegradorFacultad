using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class ExisteAlumnoException : Exception
    {
        public ExisteAlumnoException() : base("El alumno no existe")
        { }
    }
}
