using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Persona
    {
        //Persona: edad, sueldo, nombre
        //Atributos o miembros

        private int edad;
        private float sueldo;
        private string nombre;

        //Creo un constructor para asignarle el nombre a persona
        public Persona(string Nombre)
        {
            this.nombre = Nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return this.edad;
        }
        public void SetSueldo(float sueldo)
        {
            this.sueldo = sueldo;
        }
        public float getSueldo()
        {
            return this.sueldo;
        }



        //Metodos: Un método es una función que pertenece a una clase y define un comportamiento o una acción que esa clase puede realizar.

        public string saludar()
        {
            return "Hola , mi nombre es " + this.nombre + ", tengo " + this.edad + " años y mi sueldo es " + this.sueldo;
        }
    }
}
