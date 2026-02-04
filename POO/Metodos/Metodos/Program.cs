using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO DE PERSONA
            //Persona p1 = new Persona("Leandro Paredes");
            //p1.SetEdad(33);
            //Console.WriteLine(p1.saludar());

            //Console.ReadKey();

            //EJEMPLO DE BOTELLA
            Botella b1 = new Botella("Azul", "Metal");

            Console.WriteLine("Capacidad de la botella: " + b1.Capacidad);
            Console.WriteLine("Cantidad actual: " + b1.CantidadActual);

            float costo = b1.recargar(900, 60.0f);

            Console.WriteLine("Cantidad luego de recargar: " + b1.CantidadActual);
            Console.WriteLine("Costo de la recarga: $" + costo);

            


            Console.ReadKey();
        }


    }
}
