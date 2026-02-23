using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_y_Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Rojo", "Metal");
            b1.Capacidad = 1.5;

            double algo = b1.Capacidad;

            Console.ReadKey();
        }
    }
}
