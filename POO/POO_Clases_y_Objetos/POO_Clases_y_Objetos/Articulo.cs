using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clases_y_Objetos
{

    class Articulo
    {
        //Codigo del articulo (3 digitos no correlativos)
        //Precio del articulo
        //Codigo de marca (1 a 10)
        public int codigoArticulo { get; set; } //Otra forma de crear una propiedad automática

        public float precioArticulo { get; set; }

        private int codigoMarca;

        public int CodigoMarca
        {
            get { return codigoMarca; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    codigoMarca = value;
                }
                else
                {
                    Console.WriteLine("El código de marca debe estar entre 1 y 10.");
                }
            }
        }



    }
}

