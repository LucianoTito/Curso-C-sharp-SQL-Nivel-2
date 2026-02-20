using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Dominio;
using Negocio;

namespace Arquitectura_en_Capas
{
    public partial class frmAltaPokemon : Form
    {
        // ---> LA MEMORIA DE LA VENTANA
        // Creamos una variable global para esta ventana. 
        // Arranca en 'null'. Si sigue en 'null', la ventana sabe que debe AGREGAR.
        // Si alguien le mete un objeto aquí, la ventana sabe que debe MODIFICAR.
        private Pokemon pokemon = null;

        // ---> AGREGAMOS ESTO: La memoria para guardar temporalmente la foto elegida
        private OpenFileDialog archivo = null;

        // ---> CONSTRUCTOR 1: AGREGAR
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        // ---> CONSTRUCTOR 2: MODIFICAR
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();

            // ---> LA LÍNEA QUE TE MAREÓ:
            // Tienes dos cosas llamadas "pokemon". 
            // 1. La variable de la clase (la memoria).
            // 2. El parámetro que llegó entre los paréntesis.
            // La palabra "this" significa "mi propia variable".
            // Traducción: "A MI variable privada (this.pokemon), asígnale el valor del parámetro que me acaban de enviar (pokemon)".
            this.pokemon = pokemon;
            Text = "Modificar Pokémon"; // Cambiamos el título de la ventana para que no confunda al usuario.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones 
                if (string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                if (cbxTipo.SelectedItem == null || cbxDebilidad.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione Tipo y Debilidad.");
                    return;
                }

                Elemento tipo = cbxTipo.SelectedItem as Elemento ?? new Elemento();
                Elemento debilidad = cbxDebilidad.SelectedItem as Elemento ?? new Elemento();

                // -----------------------------------------------------------------
                // 2. LA MAGIA DEL PROFE: ¿Creamos o Reutilizamos?
                // -----------------------------------------------------------------

                // Si es null, venimos de "Agregar". Creamos el objeto en blanco.
                // Si no es null, venimos de "Modificar". Usamos el que ya existe (y que ya tiene su Id).
                if (pokemon == null)
                {
                    pokemon = new Pokemon();
                }

                // Ahora, sea nuevo o sea viejo, le cargamos los datos de la pantalla
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.Tipo = tipo;
                pokemon.Debilidad = debilidad;
                pokemon.UrlImagen = tbxUrlImagen.Text ?? string.Empty;

                // -----------------------------------------------------------------
                // 3. DECISIÓN FINAL: ¿Insert o Update?
                // -----------------------------------------------------------------
                PokemonNegocio negocio = new PokemonNegocio();

                // Si el Id es distinto de 0, significa que este Pokémon ya existía en la BD.
                if (pokemon.Id != 0)
                {
                    negocio.ModificarPokemon(pokemon);
                    MessageBox.Show("Pokémon modificado exitosamente.");
                }
                // Si el Id es 0, es un Pokémon recién nacido.
                else
                {
                    negocio.AgregarPokemon(pokemon);
                    MessageBox.Show("Pokémon agregado exitosamente.");
                }
                // 4. GUARDAR LA IMAGEN LOCAL (SI ES QUE ELIGIÓ UNA)
                // Verificamos que 'archivo' no sea null (es decir, que sí tocó el botón de agregar imagen)
                // y que la ruta no sea una web (http) para que no explote el File.Copy
                if (archivo != null && !(tbxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    // Le agregamos un 'true' al final. Esto significa que si ya existe una foto con ese nombre, la sobrescriba sin dar error.
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName, true);
                }

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
                // 1. Cargamos el ComboBox de TIPO
                cbxTipo.DataSource = negocio.listar();
                cbxTipo.ValueMember = "Id"; // El valor que nos importa por detrás (El ID)
                cbxTipo.DisplayMember = "Descripcion"; // La palabra que verá el usuario (Ej: "Fuego")

                // 2. Cargamos el ComboBox de DEBILIDAD
                cbxDebilidad.DataSource = negocio.listar();
                cbxDebilidad.ValueMember = "Id";
                cbxDebilidad.DisplayMember = "Descripcion";

                // 3. Si hay un pokemon cargado (MODIFICAR)
                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    tbxUrlImagen.Text = pokemon.UrlImagen;

                    // ---> MAGIA 
                    // En lugar de SelectedItem y buscar el objeto completo, 
                    // le decimos directamente: "Selecciona el elemento cuyo ValueMember (Id) sea este".
                    cbxTipo.SelectedValue = pokemon.Tipo.Id;
                    cbxDebilidad.SelectedValue = pokemon.Debilidad.Id;

                    cargarImagen(pokemon.UrlImagen);
                }
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

        private void cargarImagen(string? imagen)
        {
            const string fallback = "https://static.vecteezy.com/system/resources/thumbnails/008/695/917/small/no-image-available-icon-simple-two-colors-template-for-no-image-or-picture-coming-soon-and-placeholder-illustration-isolated-on-white-background-vector.jpg";
            try
            {
                if (pbxPokemon == null) return;

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


        // EVENTO: Clic en el botón de agregar imagen local
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            // 1. CREAR LA VENTANA DE EXPLORADOR:
            // OpenFileDialog es el componente nativo de Windows que abre la típica ventanita de "Abrir archivo...".
            OpenFileDialog archivo = new OpenFileDialog();

            // 2. APLICAR EL FILTRO DE SEGURIDAD:
            // Le decimos a la ventana que solo muestre archivos con estas extensiones específicas.
            // El formato es: "Texto visible para el usuario | extensiones separadas por punto y coma"
            archivo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // 3. MOSTRAR LA VENTANA Y ESPERAR RESPUESTA:
            // .ShowDialog() detiene el programa y le muestra la ventana al usuario.
            // Si el usuario elige una foto y presiona "Aceptar", el resultado es DialogResult.OK y entra al 'if'.
            // Si presiona "Cancelar" o la 'X', simplemente no hace nada.
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                // 4. CAPTURAR LA RUTA:
                // .FileName devuelve la ruta absoluta del archivo que eligió el usuario. 
                // Ejemplo: "C:\Usuarios\Fotos\charizard.jpg"
                string rutaImagen = archivo.FileName;

                // 5. MOSTRAR LA RUTA EN PANTALLA:
                // Escribimos esa ruta larguísima en el TextBox para que el usuario (o la base de datos después) la vea.
                tbxUrlImagen.Text = rutaImagen;

                // 6. CARGAR LA VISTA PREVIA:
                // Llamamos al método que ya tenías creado para que el PictureBox dibuje la imagen en pantalla.
                cargarImagen(rutaImagen);

                // 7. GUARDAR UNA COPIA LOCAL (MAGIA DE SYSTEM.IO Y SYSTEM.CONFIGURATION):
                // File.Copy necesita dos cosas: (De dónde saco el archivo, A dónde lo pego).
                // - Origen: archivo.FileName (La foto original del usuario).
                // - Destino: ConfigurationManager.AppSettings["images-folder"] (Busca en el App.config la ruta de tu carpeta de imágenes D:\...)
                //            + archivo.SafeFileName (Le concatena solo el nombre de la foto, ej: "charizard.jpg").
                
            }
        }
    }
}
