using System;
using System.Collections.Generic;
using System.Text;

namespace Lectura_de_datos_de_Diferentes_tablas_DB
{
    internal class Pokemon
    {
        //Propiedades autoimplementadas.
        //Representan las columna de la tabla de la base de datos

        public int Numero {  get; set; }

        //Inicializamos con string.Empty para evitar warnings de nulidad

        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string UrlImagen { get; set; } = string.Empty;

        // Inicializar las propiedades de referencia no anulables para evitar CS8618
        public Elemento Tipo { get; set; } = new Elemento();

        // Inicializar las propiedades de referencia no anulables para evitar CS8618
        public Elemento Debilidad { get; set; } = new Elemento();
    }
}
