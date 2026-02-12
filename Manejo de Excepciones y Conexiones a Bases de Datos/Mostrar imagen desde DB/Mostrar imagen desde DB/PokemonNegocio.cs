using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Mostrar_imagen_desde_DB
{
    internal class PokemonNegocio
    {

        public List<Pokemon> ObtenerPokemones()
        {
            List<Pokemon> listaPokemons = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true; TrustServerCertificate=True";

                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "SELECT Numero, Nombre, Descripcion, UrlImagen FROM dbo.POKEMONS";

                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = lector.GetString(3);
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
    }
}
