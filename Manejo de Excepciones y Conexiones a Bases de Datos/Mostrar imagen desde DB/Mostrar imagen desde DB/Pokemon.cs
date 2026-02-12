using System;
using System.Collections.Generic;
using System.Text;

namespace Mostrar_imagen_desde_DB
{
    internal class Pokemon
    {
        public int Numero { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string UrlImagen { get; set; } = string.Empty;
    }
}
