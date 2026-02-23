using Dominio;
using Negocio;
namespace Arquitectura_en_Capas
    
{
    public partial class frmPokemon : Form

    {
        private List <Pokemon> listaPokemons = new List<Pokemon> ();
        public frmPokemon()
        {
            InitializeComponent();
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            //Usamos navegación seguro y 'as' para evitar desreferencias nulas
            var seleccionado = dgvPokemons?.CurrentRow?.DataBoundItem as Pokemon;

            //Verificamos que el objeto convertido no sea nulo antes de leer sus propiedades
            if (seleccionado != null)
            {
                cargarImagen(seleccionado.UrlImagen);
            }
            else
            {
                //Si no hay, cargamos imagen por defecto
                cargarImagen(null);
            }

        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                listaPokemons = negocio.ObtenerPokemones();

                //Protegemos accesos a controles que podrían ser null
                if (dgvPokemons != null)
                {
                    dgvPokemons.DataSource = listaPokemons;

                    if (dgvPokemons.Columns["UrlImagen"] != null)
                    {
                        dgvPokemons.Columns["UrlImagen"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la lista: " + ex.Message);
              
            }
        }

        private void cargarImagen (string? imagen)
        {
            //Url por defecto si la proporcionada es nula o vacía
            const string imagenPorDefecto = "https://static.vecteezy.com/system/resources/thumbnails/008/695/917/small/no-image-available-icon-simple-two-colors-template-for-no-image-or-picture-coming-soon-and-placeholder-illustration-isolated-on-white-background-vector.jpg";
            string url = string.IsNullOrWhiteSpace(imagen) ? imagenPorDefecto : imagen!;

            try
            {
                pbxPokemon?.Load(url);
            }
            catch (Exception)
            {

                //Carga imagen de error si falla URL
                pbxPokemon?.Load(imagenPorDefecto);
            }
        }
    }
}
