using System;
using System.Collections.Generic;
using System.Text;

namespace Conexiones_con_POKEMON_DB
{
    internal class Pokemon
    {
        // Propiedades que mapean las columnas de la Base de Datos
        // Es buena práctica inicializarlas para evitar valores nulos (NullReferenceException)
        public int PokedexNumero { get; set; }

        // Inicializamos con string.Empty para que nunca sea null al arrancar
        public string Nombre { get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty;

        // Aquí podríamos agregar una propiedad para la imagen más adelante
        // public string UrlImagen { get; set; }
    }
}