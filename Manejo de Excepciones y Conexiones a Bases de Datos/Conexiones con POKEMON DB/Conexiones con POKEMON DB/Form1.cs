namespace Conexiones_con_POKEMON_DB
{
    public partial class frmPokemons : Form
    {
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void dgvPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemons.DataSource = negocio.ObtenerPokemones();

        }
    }
}
