using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Arquitectura_en_Capas
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                //Validamos que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Validar selecciones en combobox para evitar asignaciones nulas
                if (cbxTipo.SelectedItem == null || cbxDebilidad.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione Tipo y Debilidad.");
                    return;
                }

                // Obtener los Elemento de forma segura
                Elemento tipo = cbxTipo.SelectedItem as Elemento ?? new Elemento();
                Elemento debilidad = cbxDebilidad.SelectedItem as Elemento ?? new Elemento();

                //Creamos el nuevo Pokémon con los datos ingresados
                Pokemon nuevoPokemon = new Pokemon
                {
                    Numero = int.Parse(txtNumero.Text),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Tipo = tipo,
                    Debilidad = debilidad,
                    UrlImagen = tbxUrlImagen.Text ?? string.Empty,
                };
                //Lógica para guardar el nuevo Pokémon (Es una llamada a la capa de negocio)
                PokemonNegocio negocio = new PokemonNegocio();
                negocio.AgregarPokemon(nuevoPokemon);
                MessageBox.Show("Pokémon agregado exitosamente.");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();
            try
            {
                cbxTipo.DataSource = negocio.listar();
                cbxDebilidad.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }

        //Método para cargar la imagen del Pokémon, con manejo de errores y una imagen de fallback
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
    }
}
