using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gato gato1 = new Gato();
            gato1.Nombre = "Michi";

            Perro perro1 = new Perro();
            perro1.Nombre = "Firulais";

            //LISTA DE ANIMALES
            List<Animal> animales = new List<Animal>();
            animales.Add(gato1);
            animales.Add(perro1);
            animales.Add(new Aguila() { Nombre = "Aguila Real" });
            animales.Add(new Oso() { Nombre = "Oso Panda" });

            List <IVolador> voladores = new List<IVolador>(); //Lista de voladores
            voladores.Add(new Aguila() { Nombre = "Aguila Calva" });
            
        }
    }
}
