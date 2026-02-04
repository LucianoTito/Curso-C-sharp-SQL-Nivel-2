using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Persona
    {
        //Persona: nombre, sueldo, edad
        //Atributos, son variables dentro de la clase que permiten guardar información

        private int edad;
        private float sueldo;
        private string nombre;

        //Métodos: son funciones o procedimientos dentro de la clase que permiten realizar acciones

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return this.edad;
        }
    }
}
