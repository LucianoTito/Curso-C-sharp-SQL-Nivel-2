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



        //Sobrecarga de métodos: mismo nombre, diferente cantidad/tipo de parámetros

        public string saludar()
        {
            return "Hola , mi nombre es " + nombre + ", tengo " + this.edad;
        }


        public string saludar( string personaje)
        {
            return  " Hola ," + personaje + " mi nombre es: " + nombre + ", tengo " + this.edad;
        }


    }
}
