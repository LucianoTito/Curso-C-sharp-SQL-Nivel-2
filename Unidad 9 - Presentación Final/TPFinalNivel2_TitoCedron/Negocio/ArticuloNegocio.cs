using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
      
        public List<Articulo> Listar()
          {
                List<Articulo> lista = new List<Articulo>();
                AccesoDatos datos = new AccesoDatos();
    
                try
                {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion AS Categoria, A.ImagenUrl, A.Precio FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                //Mapeo de la tabla sql a la clase Articulo
                while (datos.Lector.Read())
                 {
                    Articulo aux = new Articulo();

                    if (!datos.Lector.IsDBNull(0)) aux.Id = datos.Lector.GetInt32(0);
                    if (!datos.Lector.IsDBNull(1)) aux.Codigo = datos.Lector.GetString(1);
                    if (!datos.Lector.IsDBNull(2)) aux.Nombre = datos.Lector.GetString(2);
                    if (!datos.Lector.IsDBNull(3)) aux.Descripcion = datos.Lector.GetString(3);

                    //Instancio la marca
                    aux.Marca  = new Marca();
                    if (!datos.Lector.IsDBNull(4)) aux.Marca.Id = datos.Lector.GetInt32(4);
                    if (!datos.Lector.IsDBNull(5)) aux.Marca.Descripcion = datos.Lector.GetString(5);

                    //Instancio la categoria
                    aux.Categoria = new Categoria();
                    if (!datos.Lector.IsDBNull(6)) aux.Categoria.Id = datos.Lector.GetInt32(6);
                    if (!datos.Lector.IsDBNull(7)) aux.Categoria.Descripcion = datos.Lector.GetString(7);

                    if (!datos.Lector.IsDBNull(8)) aux.UrlImagen = datos.Lector.GetString(8);

                    lista.Add(aux);

                }

                return lista;
                }
                catch (Exception ex)
                {
    
                 throw ex;
                }
                finally
                {
                 datos.CerrarConexion();
            }
        }


    }
}
