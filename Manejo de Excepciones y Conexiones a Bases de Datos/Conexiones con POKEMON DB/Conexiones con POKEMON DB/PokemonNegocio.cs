using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//Incluyo la libreria para manejar la conexión a la base de datos
 using Microsoft.Data.SqlClient;


namespace Conexiones_con_POKEMON_DB
{
    internal class PokemonNegocio
    {
        //Método para obtener la lista de Pokémon desde la base de datos
        public List<Pokemon> ObtenerPokemones ()
        { 
            List<Pokemon> listaPokemones = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                //Configuro la conexión a la base de datos
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=PokemonDB; integrated security=true; TrustServerCertificate=True";
                //Configuro el comando SQL para obtener los datos de la tabla de Pokémon
                comando.CommandType = System.Data.CommandType.Text;
                //Escribo la consulta SQL para obtener el número de pokedex, el nombre y el tipo del Pokémon
                comando.CommandText = "SELECT PokedexNo, PokemonName, Type1 FROM dbo.PokemonTbl";
                //Asigno la conexión al comando
                comando.Connection = conexion;

                //Abro la conexión a la base de datos
                conexion.Open();

                //Ejecuto el comando y obtengo un lector de datos
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    //Creo un objeto Pokemon auxiliar para almacenar los datos de cada Pokémon obtenido del lector
                    Pokemon auxiliar = new Pokemon();
                    //Obtengo los datos de cada columna del lector y los asigno a las propiedades del objeto auxiliar
                    auxiliar.PokedexNumero = lector.GetInt32(0); //Obtengo el número de pokedex (columna 0)
                    auxiliar.Nombre = (string)lector["PokemonName"]; //Obtengo el nombre del Pokémon (columna "PokemonName")"];
                    auxiliar.Tipo = (string)lector["Type1"]; //Obtengo el tipo del Pokémon (columna "Type1")"];

                    listaPokemones.Add(auxiliar);
                }

                //conexion.Close();
                return listaPokemones;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener pokemones: " + ex.Message);
                throw; // relanza manteniendo el stack trace

            }
            finally
            {
                // Se ejecuta siempre, haya o no excepción
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }


        }
    }
}
