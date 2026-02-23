using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexiones_con_POKEMON_DB
{
    public partial class frmPokemons : Form
    {
        public frmPokemons()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta apenas se abre la ventana
        private void frmPokemons_Load(object sender, EventArgs e)
        {
            // Opcional: Colocar un try-catch aquí también es excelente práctica
            // para mostrar un MessageBox si la base de datos falló.
            try
            {
                // 1. Instanciamos la clase de negocio (nuestro "delivery" de datos)
                PokemonNegocio negocio = new PokemonNegocio();

                // 2. Llamamos al método obtener y lo asignamos a la grilla
                // El DataSource detecta las propiedades de la clase Pokemon y crea las columnas automáticamente.
                dgvPokemons.DataSource = negocio.ObtenerPokemones();
            }
            catch (Exception ex)
            {
                // Aquí atrapamos el 'throw' que lanzó el negocio si hubo error
                MessageBox.Show("Ocurrió un error al cargar la lista: " + ex.Message);
            }
        }

        private void dgvPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este evento por ahora no lo usamos
        }
    }
}