using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_Date_Time
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // Declaración de una variable de tipo DateTime e invoco a un constructor para asignarle un valor
            DateTime fecha = new DateTime(1993, 01, 18);

            // Imprimo el valor de la variable
            Console.WriteLine("Valor de la variable fecha: " + fecha.ToString());

            // Obtengo la fecha y hora actual del sistema:
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine("Fecha y hora actual: " + fechaActual.ToString());


            //Como agregarle días a una fecha
            DateTime fechaMasCincoDias = fecha.AddDays(5);
            Console.WriteLine("Fecha más cinco días: " + fechaMasCincoDias.ToString());

            //Como mostrar solo la fecha sin la hora
            Console.WriteLine("Solo la fecha: " + fechaActual.ToShortDateString());

            //Como expresar la fecha en formato latinoamericano
            Console.WriteLine("Fecha en formato latinoamericano: " + fechaActual.ToString("dd/MM//yyyy"));

        }
    }
}
