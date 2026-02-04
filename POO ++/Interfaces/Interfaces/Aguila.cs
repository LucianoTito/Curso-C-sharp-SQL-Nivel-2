using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aguila: AnimalSalvaje, IVolador
    {
        //Implementacion del metodo volar de la interfaz IVolador, la interfaz necesita que el método esté definido.
        public string volar()
        {
            return "El águila está volando";
        }

    }
}
