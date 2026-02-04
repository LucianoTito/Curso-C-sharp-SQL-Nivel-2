using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {

        //Constructor

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        //Atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        //Propiedades Las propiedades son miembros de una clase que proporcionan un mecanismo flexible para leer, escribir o calcular los valores de los campos privados.
        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public string NumeroTelefonico
        { 
          get { return numeroTelefonico; }
          set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        { get { return codigoOperador; }
          set 
            { 
            if (value == 1 || value == 2 || value == 3)
                { codigoOperador = value; }
                else
                {
                    codigoOperador = 0; ;
                }

            }
        }


        //Metodos

        public string Llamar ()
        {  return "Realizando llamada..."; }

        public string Llamar (string contacto)
        { return "Llamando a " + contacto; }

    }
}
