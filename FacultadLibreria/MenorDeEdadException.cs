using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    public class MenorDeEdadException : Exception
    {
        public MenorDeEdadException() : base("La persona es menor de edad")
        { }
    }
}
