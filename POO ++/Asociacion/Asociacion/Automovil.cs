using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    internal class Automovil: Vehiculo
    {
        //Constructor
        public Automovil()
        {
            Chasis = new Chasis(); // Inicializa la propiedad Chasis en el constructor
        }

        
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }



        //Composición (Relación fuerte)
        public Chasis Chasis { get; }  // Tiene un objeto del tipo Chasis como propiedad


        //Agregación (Relación débil)
        public Motor Motor { get; set; } // Tiene un objeto del tipo Motor como propiedad
    }
}
