using Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Changuito");
            p1.SetEdad(24);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Leandro"));

            Console.ReadKey();
        }
    }
}
