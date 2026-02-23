using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Automovil auto1 = new Automovil(); // Crear una instancia de Automovil
            auto1.Motor = new Motor(); // Crear una instancia de Motor y asignarla al Automovil
        }
    }
}
