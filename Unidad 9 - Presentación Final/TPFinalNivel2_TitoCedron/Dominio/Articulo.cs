using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Relaciones con las otras clases
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        public string ImagenUrl { get; set; } = string.Empty;

        //Precio del articulo
        public decimal Precio { get; set; }
    }
}
