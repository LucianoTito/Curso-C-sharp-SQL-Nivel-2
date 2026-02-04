using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_y_Destructores
{
    class Botella
    {
        //Constructores
                public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }

        //sobrecarga de constructores
        public Botella() { }

        //Destructor
        ~Botella()
        {
            //Código de limpieza

        }

        // Atributos
        private string material;
        private double capacidad; // en litros
        private string color;

        //Propiedad
        public double Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        


    }
}
