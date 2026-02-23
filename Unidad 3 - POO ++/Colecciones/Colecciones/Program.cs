using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();

            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Blanco";
            c2.Color = "Negro";
            c3.Color="Azul";



            //Voy a crear una COLECCION
            //Las listas son colecciones dinámicas de objetos de un tipo específico y están fuertemente tipadas.

            List<Camioneta> listaCamionetas = new List<Camioneta>(); //Estoy creando una lista de objetos del tipo Camioneta
            listaCamionetas.Add(c1);//Agrego la camioneta c1 a la lista  
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count());
            Console.WriteLine("El color de la segunda camioneta es: " + listaCamionetas[1].Color);

            //Por ejemplo si quiero cambiar el color de una camioneta
            listaCamionetas[1].Color = "Turquesa";

            Console.WriteLine("El color de la segunda camioneta es: " + listaCamionetas[1].Color);

            //Por ejemplo si quiero remover una camioneta
            listaCamionetas.Remove(c2);

            Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count());


            //Ahora por ejemplo quiero ver el color de todas las camionetas

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }



            Console.ReadKey();
        }
    }
}
