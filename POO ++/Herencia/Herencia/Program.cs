using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona();
            Developer d1 = new Developer();
            d1.Nombre = "Changuito Zeballos";
            Lider l1 = new Lider();
            l1.Nombre = "Lider Supremo";

        }
    }
}
