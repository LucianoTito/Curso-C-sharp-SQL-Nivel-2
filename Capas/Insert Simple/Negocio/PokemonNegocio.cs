using Dominio;

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;



namespace Negocio
{
    public class PokemonNegocio
    {
        //Método que va a la base de datos y devuelve la lista de pokemons

        public List<Pokemon> ObtenerPokemones()
        {

            // 1. La Lista Contenedora:
            // Preparamos la caja vacía donde guardaremos los objetos que traigamos de la DB para retornarlos al final.
            List<Pokemon> listaPokemons = new List<Pokemon>();

            // 2. El Objeto Conexión (El Puente):
            // Es el encargado de establecer el vínculo físico con SQL Server.
            // Se declara aquí para poder configurarlo en el 'try' y cerrarlo en el 'finally'.
            SqlConnection conexion = new SqlConnection();

            // 3. El Objeto Comando (El Mensajero):
            // Es el objeto que transportará nuestra consulta SQL (SELECT, INSERT, etc.) a través de la conexión.
            SqlCommand comando = new SqlCommand();

            // 4. El Objeto Lector (El Cursor):
            // Es quien recibe el resultado de la consulta. Funciona como un flujo de datos de solo lectura y avance rápido.
            // Nota: No se hace 'new SqlDataReader()' porque quien lo instancia es el comando.ExecuteReader().
            SqlDataReader lector;

            try
            {
                //1. Configuración de la cadena de conexión
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true; TrustServerCertificate=True";

                //2.Definimos que vamos a escribir una consulta SQL a mano
                comando.CommandType = System.Data.CommandType.Text;

                //3.Escribimos la consulta
                // Consulta actualizada con INNER JOIN (Estándar ANSI-92)
                comando.CommandText = "SELECT P.Numero, P.Nombre, P.Descripcion, P.UrlImagen,E.Descripcion AS Tipo, D.Descripcion AS Debilidad FROM dbo.ELEMENTOS E, POKEMONS P, ELEMENTOS D WHERE E.Id = P.IdTipo And D.Id = P.IdDebilidad";

                //4.Conectamos el comando a la conexión
                comando.Connection = conexion;

                //5.Abrimos la conexión
                conexion.Open();

                //6.Ejecutamos la lectura
                lector = comando.ExecuteReader();

                //7.Recorremos fila por fila lo que trajo la base de datos
                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    //Mapeo de datos: DB --> Objeto C#
                    //Usamos métodos Get* y comprobar IsDBNull para evitar excepciones y advertencias de nulabilidad
                    if (!lector.IsDBNull(0))
                        aux.Numero = lector.GetInt32(0); //Columna 0
                    if (!lector.IsDBNull(1))
                        aux.Nombre = lector.GetString(1);
                    if (!lector.IsDBNull(2))
                        aux.Descripcion = lector.GetString(2);
                    if (!lector.IsDBNull(3))
                        aux.UrlImagen = lector.GetString(3);
                    if (!lector.IsDBNull(4))
                        aux.Tipo.Descripcion = (String)lector.GetString(4);
                    if (!lector.IsDBNull(5))
                        aux.Debilidad.Descripcion = (String)lector.GetString(5);

                    // Agregamos el objeto 'aux' ya cargado con datos a la lista final.
                    listaPokemons.Add(aux);
                }
                return listaPokemons;
            }
            catch (Exception ex)
            {

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
    
    public void AgregarPokemon(Pokemon nuevoPokemon)
        {
            Acceso_a_datos datos = new Acceso_a_datos();
            try
            {
                datos.SetearConsulta("INSERT INTO POKEMONS (Numero, Nombre, Descripcion, Activo) VALUES ("+ nuevoPokemon.Numero+ ", '" + nuevoPokemon.Nombre + "', '" + nuevoPokemon.Descripcion + "', 1)");
                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void ModificarPokemon(Pokemon pokemonModificado)
        {
            // Implementación para modificar un Pokémon existente en la base de datos
            // Similar a ObtenerPokemones pero con una consulta UPDATE y parámetros
        }
    } 
}
