using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Metodos
{
    internal class AnimalDomestico:Animal
    {


        //Propiedades autoimplementadas, para que no sea necesario escribir private, a menos que se necesite logica adicional antes de entregarla
        public string Nombre { get; set; }

        //Sobrecarga de Metodos
        public override string ToString()
        {
            return "Animal Doméstico: " + Nombre;
        }

    }
}
