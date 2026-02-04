using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Telefono telefono1 = new Telefono("T14 PRO", "Xiaomi");

            //Console.WriteLine("Ingrese el número telefónico: "  );
            //telefono1.NumeroTelefonico = Console.ReadLine();
            telefono1.NumeroTelefonico = "3874527977";
            telefono1.CodigoOperador = 99;

           // Console.WriteLine("Ingrese el codigo de Operador ( 1, 2 o 3): ");
            // telefono1.CodigoOperador = int.Parse(Console.ReadLine());

            //Mostrar los datos
            Console.WriteLine("El modelo es: " + telefono1.Modelo);
            Console.WriteLine("La marca es: " + telefono1.Marca);
            Console.WriteLine("El número guardado es " + telefono1.NumeroTelefonico);
            Console.WriteLine("El código de operador es: " + telefono1.CodigoOperador);
            Console.WriteLine(telefono1.Llamar());
            Console.WriteLine(telefono1.Llamar("Bianchi"));

            Console.ReadKey();
        }
    }
}
