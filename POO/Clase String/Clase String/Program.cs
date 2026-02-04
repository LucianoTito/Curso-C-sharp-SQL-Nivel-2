using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            nombre = Console.ReadLine();

            //Definición de string: Es una funcion que almacena una cadena de caracteres.
            //Como string es una clase, tenemos una serie de métodos viene con metodos incluidos incluidos para utilizar.
            //Métodos que de otra manera, tendríamos que programar nosotros mismos.

            //Ejemplos de métodos de la clase string:

            int cantidadCaracteres = nombre.Length;

            nombre = nombre.ToUpper(); //Convierte todos los caracteres a mayúsculas.
            nombre = nombre.ToLower(); //Convierte todos los caracteres a minúsculas.
            nombre = nombre.Trim(); //Elimina los espacios en blanco al inicio y al final de la cadena.
            nombre = nombre.Replace('a', '@');//Reemplaza todas las apariciones de un carácter por otro.


        }  
    }
}
