using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class LegajoInvalidoException : Exception
    {
        public LegajoInvalidoException() : base("Ya hay un empleado con ese legajo")
        { }
    }
}
