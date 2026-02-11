using System;
using System.Collections.Generic;
using System.Text;
//Incluyo la libreria para manejar la conexión a la base de datos
using System.Data.SqlClient; 

namespace Conexiones_con_POKEMON_DB
{
    internal class PokemonNegocio
    {
        //Método para obtener la lista de Pokémon desde la base de datos
        public List<Pokemon> ObtenerPokemones ()
        { 
            List<Pokemon> pokemones = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=PokemonDB; integrated security=true";

                return pokemones;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
