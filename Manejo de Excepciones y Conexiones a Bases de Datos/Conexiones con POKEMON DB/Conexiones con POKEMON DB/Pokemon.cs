using System;
using System.Collections.Generic;
using System.Text;

namespace Conexiones_con_POKEMON_DB
{
    internal class Pokemon
    {
        public int PokedexNumero { get; set; }
        public string Nombre { get; set; } = string.Empty; //Inicializo la propiedad Nombre con un valor por defecto de cadena vacía para evitar problemas de null reference
        public string Tipo { get; set; } = string.Empty; //Inicializo la propiedad Tipo con un valor por defecto de cadena vacía para evitar problemas de null referenceS


    }
}
