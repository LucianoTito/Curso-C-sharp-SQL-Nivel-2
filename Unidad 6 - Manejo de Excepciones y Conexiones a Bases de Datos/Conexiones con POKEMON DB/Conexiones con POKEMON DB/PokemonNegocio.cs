using System;
using System.Collections.Generic;
using System.Text;
// IMPORTANTE: Librería para los objetos de SQL Server
using Microsoft.Data.SqlClient;

namespace Conexiones_con_POKEMON_DB
{
    internal class PokemonNegocio
    {
        // Método público que devolverá una lista llena de objetos Pokemon
        public List<Pokemon> ObtenerPokemones()
        {
            // 1. Preparamos la lista vacía donde guardaremos los datos que traiga la base
            List<Pokemon> listaPokemones = new List<Pokemon>();

            // 2. Declaramos los objetos de ADO .NET fuera del try para que existan en todo el método
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                // 3. CONFIGURACIÓN DE LA CONEXIÓN (La dirección del GPS)
                // server: Tu servidor (.\SQLEXPRESS suele ser el local).
                // database: El nombre exacto de tu base de datos.
                // integrated security: true (Usa tu usuario de Windows, no pide contraseña).
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=PokemonDB; integrated security=true; TrustServerCertificate=True";

                // 4. CONFIGURACIÓN DEL COMANDO
                // Le decimos qué tipo de orden le vamos a dar. Text significa "Consulta SQL escrita a mano".
                comando.CommandType = System.Data.CommandType.Text;

                // Escribimos la consulta SQL exacta. 
                // TIP: Siempre pruébala primero en SQL Server Management Studio.
                comando.CommandText = "SELECT PokedexNo, PokemonName, Type1 FROM dbo.PokemonTbl";

                // Conectamos el cable: Le decimos al comando qué conexión debe usar.
                comando.Connection = conexion;

                // 5. ABRIR CONEXIÓN
                // Aquí es donde realmente se intenta contactar al servidor. Es el punto crítico de fallo.
                conexion.Open();

                // 6. EJECUTAR CONSULTA
                // El ExecuteReader va a la base, corre el SELECT y vuelve con los datos en formato de tabla virtual.
                lector = comando.ExecuteReader();

                // 7. LEER Y MAPEAR (Transformar tabla a objetos)
                // El lector tiene un puntero. .Read() mueve el puntero a la siguiente fila.
                // Mientras haya filas para leer, el while sigue dando vueltas.
                while (lector.Read())
                {
                    // Por cada fila que leemos, creamos un objeto Pokemon nuevo
                    Pokemon auxiliar = new Pokemon();

                    // Mapeo manual: Leemos la columna de la DB y la guardamos en la propiedad del objeto

                    // Opción A: Leer por índice de columna (0 es la primera columna del Select)
                    // GetInt32 asegura que el dato sea un entero.
                    auxiliar.PokedexNumero = lector.GetInt32(0);

                    // Opción B: Leer por nombre de columna (Más seguro si cambias el orden)
                    // El (string) es un casteo explícito para decirle a C# "esto es texto".
                    auxiliar.Nombre = (string)lector["PokemonName"];

                    // Cargamos el tipo
                    auxiliar.Tipo = (string)lector["Type1"];

                    // Una vez que el objeto auxiliar está lleno de datos, lo agregamos a la lista final
                    listaPokemones.Add(auxiliar);
                }

                // Si llegamos aquí, todo salió bien. Retornamos la lista llena.
                return listaPokemones;
            }
            catch (Exception ex)
            {
                // Si algo explota (servidor apagado, tabla no existe, etc.), caemos aquí.
                // Es buena práctica dejar un log o aviso en consola.
                Console.WriteLine("Error al obtener pokemones: " + ex.Message);

                // 'throw' solo vuelve a lanzar el error hacia quien llamó al método (el Formulario)
                // para que el Formulario decida qué mensaje mostrarle al usuario.
                throw;
            }
            finally
            {
                // 8. CERRAR CONEXIÓN (Siempre)
                // El finally se ejecuta SIEMPRE. Es vital cerrar la conexión para no matar la memoria del servidor.
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}