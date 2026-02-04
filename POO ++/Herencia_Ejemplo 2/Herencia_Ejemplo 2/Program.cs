using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            v1.motor = "V8";
            Camioneta c1 = new Camioneta();
            c1.capacidadCarga = "1000kg";


            Vehiculo v2 = new Camioneta(); // Esto funciona porque Camioneta hereda de Vehiculo entonces una Camioneta "es un" Vehiculo. Esto me sirve para polimorfismo.
            //Esa línea significa que estás guardando un objeto específico (Camioneta) dentro de una variable genérica (Vehiculo). Ganas generalidad, pero pierdes especificidad (acceso directo a las propiedades exclusivas de la camioneta).
        }
    }
}
