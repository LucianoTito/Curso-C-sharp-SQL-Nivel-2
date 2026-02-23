using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "Firulais";

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.comunicarse());


            Gato g1 = new Gato();
            g1.Nombre = "Michi";
            Console.WriteLine(g1.comunicarse());


            Perro p1 = new Perro();
            p1.Nombre = "Max";
            Console.WriteLine(p1.comunicarse());


            //LISTA DE ANIMALES
            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Oso()); //Este objeto no va a poder ser accedido desde otro lugar que no sea en esta lista
            animales.Add(new Aguila ());//Este objeto no va a poder ser accedido desde otro lugar que no sea en esta lista


            //Casteo explicito:
            Animal a9 = g1; //Upcasting
            Gato g8 = (Gato)a9; //Downcasting


            //Vamos a recorrer la LISTA

            foreach (Animal animal in animales)
            {
                Console.WriteLine(animal.comunicarse());
            }

            //Al recorrer esta lista podemos observar lo que es el POLIMORFISMO
            //El polimorfismo es: "La capacidad de un objeto de comportarse de diferentes formas dependiendo del contexto"
        }
    }
}
