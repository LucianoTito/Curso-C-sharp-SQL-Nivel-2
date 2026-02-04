using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Botella
    {
        //Constructor con parametros
        public Botella(string color, string material) {

            this.color = color;
            this.material = material;
            capacidad = 1000;
            cantidadActual = 0;
            precioPorLitro= 50.0f;
        }

        //Sobrecarga de constructores
        public Botella() { }

        //BOTELLA: color, material, capacidad,
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        private float precioPorLitro;

        public Botella(float precioPorLitro)
        {
            this.precioPorLitro = precioPorLitro;
        }

        //Propiedades Las propiedades son miembros de una clase que proporcionan un mecanismo flexible para leer, escribir o calcular los valores de los campos privados.
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Capacidad
        {
            get { return capacidad; }
          
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
            
        }

   
        // Método que recarga la botella y calcula el costo en pesos
        // cantidadARecargar: cantidad que se quiere cargar (en mililitros)
        // precioPorLitro: precio del líquido por litro
        public float recargar(int cantidadARecargar, float precioPorLitro)
        {
            // Variable que guarda cuántos mililitros
            // efectivamente se pueden recargar
            int cantidadRecargable;

            // Verificamos si la recarga completa entra en la botella
            if (cantidadActual + cantidadARecargar <= capacidad)
            {
                // Se puede recargar todo lo pedido
                cantidadRecargable = cantidadARecargar;

                // Actualizamos la cantidad actual de la botella
                cantidadActual += cantidadARecargar;
            }
            else
            {
                // No entra todo: solo se recarga hasta llenar la botella
                cantidadRecargable = capacidad - cantidadActual;

                // La botella queda llena
                cantidadActual = capacidad;
            }

            // Convertimos los mililitros recargados a litros
            // 1000 ml = 1 litro
            float litros = cantidadRecargable / 1000f;

            // Calculamos y devolvemos el costo total de la recarga
            return litros * precioPorLitro;
        }


    }
}
