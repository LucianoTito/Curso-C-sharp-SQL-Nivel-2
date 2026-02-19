using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Arquitectura_en_Capas
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemons = new List<Pokemon>();

        public frmPokemon()
        {
            InitializeComponent();

            // --- Ajustes de visualización ---
            // Alto de las filas (valor inicial / mínimo)
            dgvPokemons.RowTemplate.Height = 100;


            // Permitir que las filas ajusten su altura automáticamente según el contenido
            dgvPokemons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        // ---------------------------------------------------------
        // MÉTODO CARGAR POKEMON 
        // ---------------------------------------------------------
        private void cargarPokemon()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                // Evitar asignar null a la lista
                listaPokemons = negocio.ObtenerPokemones() ?? new List<Pokemon>();

                // Asegurarse de que el control existe antes de manipularlo
                if (dgvPokemons == null)
                    return;

                // Enlazamos la grilla
                dgvPokemons.DataSource = listaPokemons;

                // Que la columna Descripcion ocupe todo el espacio disponible
                var colDescripcion = dgvPokemons.Columns["Descripcion"];
                if (colDescripcion != null)
                {
                    colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    // Permitir salto de línea en la celda específica de Descripcion
                    colDescripcion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }


                // Ocultamos la columna de Url
                var colUrl = dgvPokemons.Columns["UrlImagen"];
                if (colUrl != null)
                {
                    colUrl.Visible = false;
                }
                var colId = dgvPokemons.Columns["Id"];
                if (colId != null)
                    { colId.Visible = false; }



                // Cargar imagen del primer pokemon por defecto
                if (listaPokemons != null && listaPokemons.Count > 0 && listaPokemons[0] != null)
                {
                    cargarImagen(listaPokemons[0].UrlImagen);
                }
                else
                {
                    cargarImagen(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ---------------------------------------------------------
        // EVENTO LOAD
        // ---------------------------------------------------------
        private void frmPokemon_Load(object sender, EventArgs e)
        {
            cargarPokemon();
        }

        // ---------------------------------------------------------
        // EVENTO SELECTION 
        // ---------------------------------------------------------
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            // Usar operadores seguros: CurrentRow puede ser null y DataBoundItem también
            if (dgvPokemons?.CurrentRow?.DataBoundItem is Pokemon seleccionado)
            {
                cargarImagen(seleccionado.UrlImagen);
            }
            else
            {
                cargarImagen(null);
            }
        }

        // ---------------------------------------------------------
        // BOTÓN AGREGAR
        // ---------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();

            cargarPokemon();


        }

        // ---------------------------------------------------------
        // MÉTODO CARGAR IMAGEN
        // ---------------------------------------------------------
        private void cargarImagen(string? imagen)
        {
            const string fallback = "https://static.vecteezy.com/system/resources/thumbnails/008/695/917/small/no-image-available-icon-simple-two-colors-template-for-no-image-or-picture-coming-soon-and-placeholder-illustration-isolated-on-white-background-vector.jpg";
            try
            {
                if (pbxPokemon == null)
                    return;

                if (string.IsNullOrEmpty(imagen))
                {
                    pbxPokemon.Load(fallback);
                }
                else
                {
                    pbxPokemon.Load(imagen);
                }
            }
            catch (Exception)
            {
                if (pbxPokemon != null)
                    pbxPokemon.Load(fallback);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Esta linea lo que hace es obtener el objeto Pokemon asociado a la fila seleccionada en el DataGridView, utilizando la propiedad DataBoundItem que devuelve el objeto vinculado a esa fila. Luego, se crea una instancia del formulario frmAltaPokemon para modificar los datos del Pokemon seleccionado y se muestra como un diálogo modal. Finalmente, se recarga la lista de Pokemons para reflejar cualquier cambio realizado.
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem; // Usar DataBoundItem para obtener el objeto Pokemon asociado a la fila seleccionada

            frmAltaPokemon modificarPokemon = new frmAltaPokemon(seleccionado); //LINEA QUE NO ENTIENDO
            modificarPokemon.ShowDialog();
            cargarPokemon();
;        }
    }
}