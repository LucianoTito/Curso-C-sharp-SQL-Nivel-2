using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Metodos
{
    internal class Perro : AnimalDomestico
    {
        //Sobrecarga de Metodos
        public override string comunicarse()
        {
            return "Guau Guau";
        }
    }
}
