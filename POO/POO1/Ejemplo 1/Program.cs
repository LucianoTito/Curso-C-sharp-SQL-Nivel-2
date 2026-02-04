using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: nombre, sueldo, edad
            // int edad;
            //float sueldo;
            //string nombre;
            //Ejemplo para guardar 10 edades
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            Persona p1 = new Persona();
            p1.SetEdad(33);
            Console.WriteLine("La edad de la persona es: " + p1.GetEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 500;



            Console.ReadKey();

        }
    }
}
