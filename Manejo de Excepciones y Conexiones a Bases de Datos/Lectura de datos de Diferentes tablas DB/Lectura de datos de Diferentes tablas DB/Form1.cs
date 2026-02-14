namespace Lectura_de_datos_de_Diferentes_tablas_DB
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemons = new List<Pokemon>();
        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                listaPokemons = negocio.ObtenerPokemones();

                //Protegemos accesos a controles que podrían ser null según el compilador
                if (dgvPokemons != null)
                {
                    dgvPokemons.DataSource = listaPokemons;

                    if (dgvPokemons.Columns["UrlImagen"] != null)
                    {
                        dgvPokemons.Columns["UrlImagen"].Visible = false;
                    }
                }
                //Verificamos que la lista no sea nula y que tenga al menos un elemento
                if (listaPokemons != null && listaPokemons.Count > 0)
                {
                    cargarImagen(listaPokemons[0].UrlImagen);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la lista: " + ex.Message);
            }
        }

        //voy a crear un metodo de cargar imagen
        private void cargarImagen(string? imagen)
        {
            //Url por defecto si la proporcionada es nula o vacía
            const string imagenPorDefecto = "https://static.vecteezy.com/system/resources/thumbnails/008/695/917/small/no-image-available-icon-simple-two-colors-template-for-no-image-or-picture-coming-soon-and-placeholder-illustration-isolated-on-white-background-vector.jpg";

            string url = string.IsNullOrWhiteSpace(imagen) ? imagenPorDefecto : imagen!;

            try
            {
                //Usamos el operador condicoinal para evitar la llamada si pbxPokemon es null
                pbxPokemon?.Load(url);
            }
            catch (Exception)
            {
                //Carga imagen de error ir falla la URL
                pbxPokemon?.Load(imagenPorDefecto);

            }
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            // Usamos navegación segura y 'as' para evitar desreferencias nulas
            var seleccionado = dgvPokemons?.CurrentRow?.DataBoundItem as Pokemon;

            // Verificamos que el objeto convertido no sea nulo antes de leer sus propiedades
            if (seleccionado != null)
            {
                cargarImagen(seleccionado.UrlImagen);

            }
            else
            {
                //Si no hay, cargarmos imagen por defecto
                cargarImagen(null);
            }

        }
    }
}
