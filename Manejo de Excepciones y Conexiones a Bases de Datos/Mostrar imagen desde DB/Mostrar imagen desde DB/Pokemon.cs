using System;
using System.Collections.Generic;
using System.Text;

namespace Mostrar_imagen_desde_DB
{
    internal class Pokemon
    {
        // Propiedades autoimplementadas,.
        // Representan las columnas de la tabla de la base de datos.
        public int Numero { get; set; }

        // Inicializamos con string.Empty para evitar warnings de nulidad.
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string UrlImagen { get; set; } = string.Empty;
    }
}