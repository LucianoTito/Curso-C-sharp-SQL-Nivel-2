using System;
using System.Collections.Generic;
using System.Text;
//Librería necesaria para conectarse a SQL Server.
using Microsoft.Data.SqlClient;

namespace Lectura_de_datos_de_Diferentes_tablas_DB
{
    internal class PokemonNegocio
    {
        //Método que va a la base de datos y devuelve la lista de pokemons

        public List<Pokemon> ObtenerPokemones()
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //1. Configuración de la cadena de conexión
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true; TrustServerCertificate=True";

                //2.Definimos que vamos a escribir una consulta SQL a mano
                comando.CommandType = System.Data.CommandType.Text;

                //3.Escribimos la consulta
                // Aseguramos que la columna Numero se seleccione en la consulta (coincide con la propiedad Pokemon.Numero)
                comando.CommandText = "SELECT P.Numero, P.Nombre, P.Descripcion, P.UrlImagen,E.Descripcion AS Tipo, D.Descripcion AS Debilidad FROM dbo.ELEMENTOS E, POKEMONS P, ELEMENTOS D  WHERE E.Id = P.IdTipo And D.Id = P.IdDebilidad";

                //4.Conectamos el comando a la conexión
                comando.Connection = conexion;

                //5.Abrimos la conexión
                conexion.Open();

                //6.Ejecutamos la lectura
                lector = comando.ExecuteReader();

                //7. Recorremos fila por fila lo que trajo la base de datos
                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    //Mapeo de datos: DB --> Objeto c#
                    //Usar métodos Get* y comprobar IsDBNull para evitar excepciones y advertencias de nulabilidad
                    if (!lector.IsDBNull(0))
                        aux.Numero = lector.GetInt32(0); //Columna 0 -> Numero

                    if (!lector.IsDBNull(1))
                        aux.Nombre = lector.GetString(1);

                    if (!lector.IsDBNull(2))
                        aux.Descripcion = lector.GetString(2);

                    //Validación para UrlImagen
                    if (!lector.IsDBNull(3))
                    {
                        aux.UrlImagen = lector.GetString(3);
                    }
                    aux.Tipo = new Elemento();

                    if (!lector.IsDBNull(4))
                    { 
                        aux.Tipo.Decripcion = (String)lector.GetString(4);
                    }

                    listaPokemons.Add(aux);

                    aux.Debilidad = new Elemento();

                    if (!lector.IsDBNull(5))
                    {
                        aux.Debilidad.Decripcion = (String)lector.GetString(5);
                    }

                }
                return listaPokemons;
            }
            catch (Exception ex)
            {
                // Si hay error, lo mostramos en la consola de salida y lo relanzamos
                // para que el Formulario se entere y le avise al usuario.

                Console.WriteLine("Error al obtener pokemones: " + ex.Message);
                throw;

            }
            finally
            {

                if (conexion.State == System.Data.ConnectionState.Open)

                {
                    conexion.Close();
                }

            }
        }
    }
}
