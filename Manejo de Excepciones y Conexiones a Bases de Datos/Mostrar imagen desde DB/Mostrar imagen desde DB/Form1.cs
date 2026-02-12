namespace Mostrar_imagen_desde_DB
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemons; // Variable para almacenar la lista de pokemones
        public frmPokemon()
        {
            InitializeComponent();
        }



        private void frmPokemon_Load_1(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                listaPokemons = negocio.ObtenerPokemones();
                dgvPokemons.DataSource = listaPokemons;
                pbxPokemon.Load(listaPokemons[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la lista: " + ex.Message);

            }
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            pbxPokemon.Load(seleccionado.UrlImagen);
        }
    }
}
