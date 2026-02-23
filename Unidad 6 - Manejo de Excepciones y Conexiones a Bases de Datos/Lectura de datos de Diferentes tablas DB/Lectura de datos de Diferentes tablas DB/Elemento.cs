using System;
using System.Collections.Generic;
using System.Text;

namespace Lectura_de_datos_de_Diferentes_tablas_DB
{
    internal class Elemento
    {
        public int Id { get; set; }
        public string Decripcion { get; set; } = string.Empty;

        public override string ToString()
        {
            return Decripcion;
        }
    }
}
