using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException() : base("El empleado no existe")
        { }
    }
}
