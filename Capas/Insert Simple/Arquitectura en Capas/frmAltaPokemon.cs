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
                //Creamos el nuevo Pokémon con los datos ingresados
                Pokemon nuevoPokemon = new Pokemon
                {
                    Numero = int.Parse(txtNumero.Text),
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
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
    }
}
