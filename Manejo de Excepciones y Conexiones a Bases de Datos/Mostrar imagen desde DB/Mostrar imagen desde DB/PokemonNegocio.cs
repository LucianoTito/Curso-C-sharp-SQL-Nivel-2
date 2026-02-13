using System;
using System.Collections.Generic;
using System.Text;
// Librería necesaria para conectarse a SQL Server
using Microsoft.Data.SqlClient;

namespace Mostrar_imagen_desde_DB
{
    internal class PokemonNegocio
    {
        // Método que va a la base de datos y devuelve la lista de pokemons
        public List<Pokemon> ObtenerPokemones()
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                // 1. Configuración de la cadena de conexión
                
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true; TrustServerCertificate=True";

                // 2. Definimos que vamos a escribir una consulta SQL a mano
                comando.CommandType = System.Data.CommandType.Text;

                // 3. Escribimos la consulta
                comando.CommandText = "SELECT Numero, Nombre, Descripcion, UrlImagen FROM dbo.POKEMONS";

                // 4. Conectamos el comando a la conexión
                comando.Connection = conexion;

                // 5. Abrimos la conexión (Aquí puede fallar si el server está apagado)
                conexion.Open();

                // 6. Ejecutamos la lectura
                lector = comando.ExecuteReader();

                // 7. Recorremos fila por fila lo que trajo la base de datos
                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    // Mapeo de datos: DB -> Objeto C#
                    aux.Numero = lector.GetInt32(0); // Columna 0 (Numero)
                    aux.Nombre = (string)lector["Nombre"]; // Usar nombre de columna es más seguro
                    aux.Descripcion = (string)lector["Descripcion"];

                    // VALIDACIÓN IMPORTANTE:
                    // Verificamos si la columna UrlImagen no es Nula en la base de datos antes de leerla
                    // DBNull.Value es como SQL representa el NULL
                    if (!(lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    }

                    listaPokemons.Add(aux);
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
                // El finally se ejecuta SIEMPRE. Cerramos la conexión para no saturar el servidor.
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}