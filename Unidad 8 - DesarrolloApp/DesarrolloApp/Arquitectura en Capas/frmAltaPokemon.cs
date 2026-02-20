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
            // El bloque try-catch envuelve TODO el proceso de guardado. 
            // Si la base de datos se desconecta o el disco duro falla al guardar la foto, 
            // el programa no explota, sino que salta directo al 'catch' de abajo.
            try
            {
                // =========================================================
                // 1. VALIDACIONES DE ENTRADA (LOS ESCUDOS PROTECTORES)
                // =========================================================

                // A. Validar campos de texto vacíos
                // string.IsNullOrWhiteSpace revisa dos cosas: que la caja no esté vacía ("") 
                // y que el usuario no haya puesto solo espacios en blanco ("   ").
                if (string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Corta la ejecución. No sigue leyendo el código de abajo.
                }

                // B. Validar formato numérico (El escudo anti-letras)
                // int.TryParse intenta convertir el texto del txtNumero a un número entero.
                // Si lo logra, guarda el número en la variable 'numeroPokemon' y devuelve true.
                // Si el usuario escribió letras (ej: "25a"), devuelve false. El '!' invierte ese false a true para entrar al error.
                if (!int.TryParse(txtNumero.Text, out int numeroPokemon))
                {
                    MessageBox.Show("El campo 'Número' solo acepta valores numéricos.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Corta la ejecución para que no explote la base de datos.
                }

                // C. Validar selecciones de ComboBox
                // Nos aseguramos de que el usuario haya elegido una opción válida y no haya dejado el desplegable en blanco.
                if (cbxTipo.SelectedItem == null || cbxDebilidad.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione Tipo y Debilidad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // =========================================================
                // 2. EXTRACCIÓN Y MAPEO DE DATOS
                // =========================================================

                // Usamos la palabra reservada 'as' para intentar convertir el ítem seleccionado en un objeto tipo 'Elemento'.
                // El operador '??' (Null-coalescing) significa: "Si la conversión da null, entonces instanciame un Elemento nuevo y vacío por las dudas".
                Elemento tipo = cbxTipo.SelectedItem as Elemento ?? new Elemento();
                Elemento debilidad = cbxDebilidad.SelectedItem as Elemento ?? new Elemento();

                // ---------------------------------------------------------
                // ¿ES UN ALTA O UNA MODIFICACIÓN? (La magia de la memoria global)
                // ---------------------------------------------------------
                // Si la variable global 'pokemon' sigue en null, significa que llegamos a esta ventana 
                // haciendo clic en "Agregar". Por lo tanto, creamos una instancia desde cero en la memoria.
                if (pokemon == null)
                {
                    pokemon = new Pokemon();
                }

                // Si la variable NO era null, significa que llegamos por el botón "Modificar" y ya tiene un ID cargado.
                // Sea nuevo o viejo, le inyectamos todos los valores que el usuario escribió en la pantalla.
                pokemon.Numero = numeroPokemon; // Usamos la variable segura que nos generó el TryParse
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.Tipo = tipo;
                pokemon.Debilidad = debilidad;
                pokemon.UrlImagen = tbxUrlImagen.Text ?? string.Empty; // Si no hay ruta, guardamos un texto vacío.

                // =========================================================
                // 3. INTERACCIÓN CON LA BASE DE DATOS (CAPA NEGOCIO)
                // =========================================================

                PokemonNegocio negocio = new PokemonNegocio();

                // Evaluamos el Id. Si es distinto de 0, significa que este objeto vino de la base de datos.
                if (pokemon.Id != 0)
                {
                    // Ejecuta el UPDATE en SQL
                    negocio.ModificarPokemon(pokemon);
                    MessageBox.Show("Pokémon modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Si el Id es 0, es un objeto recién creado (New Pokemon()).
                {
                    // Ejecuta el INSERT en SQL
                    negocio.AgregarPokemon(pokemon);
                    MessageBox.Show("Pokémon agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // =========================================================
                // 4. GUARDADO FÍSICO DE LA IMAGEN LOCAL
                // =========================================================

                // Verificamos dos cosas antes de intentar copiar un archivo:
                // 1. Que el usuario haya usado la ventana de explorar archivos (archivo != null).
                // 2. Que el texto de la caja NO sea un link de internet (!Contains("HTTP")).
                if (archivo != null && !(tbxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    // File.Copy(Origen, Destino, SobrescribirSiExiste)
                    // Origen: La ruta completa del archivo en Descargas/Imágenes del usuario.
                    // Destino: La carpeta de nuestro proyecto (leída del App.config) + el nombre original del archivo.
                    // true: Si ya hay un Pikachu.jpg en nuestra carpeta, lo pisa con el nuevo sin dar error.
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName, true);
                }

                // Todo salió perfecto. Cerramos la ventana actual para volver a la grilla principal.
                Close();
            }
            catch (Exception ex)
            {
                // Si algo explotó (ej: el servidor SQL se apagó, el disco D: no existe), 
                // mostramos el error exacto (ex.Message) de forma elegante sin que el programa se cuelgue.
                MessageBox.Show("Ocurrió un error al guardar el Pokémon: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();
            try
            {
                // 1. Traemos la lista cruda de la base de datos
                List<Elemento> listaElementos = negocio.listar();

                // 2. LA MAGIA DE LINQ (Filtro, limpieza y orden)
                List<Elemento> listaLimpia = listaElementos
                    .GroupBy(x => x.Descripcion) // Agrupamos los que tengan el mismo nombre (quita duplicados)
                    .Select(g => g.First())      // Nos quedamos solo con el primero de cada grupo repetido
                    .OrderBy(x => x.Descripcion) // Ordenamos de la A a la Z
                    .ToList();                   // Lo volvemos a convertir en una lista normal

                // 3. Cargamos el ComboBox de TIPO
                // Truco WinForms: Le pasamos un "new List" para que no compartan la misma referencia en memoria y se bugueen
                cbxTipo.DataSource = new List<Elemento>(listaLimpia);
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";

                // --- AUTOCOMPLETADO TIPO ---
                cbxTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxTipo.AutoCompleteSource = AutoCompleteSource.ListItems;

                // 4. Cargamos el ComboBox de DEBILIDAD
                cbxDebilidad.DataSource = new List<Elemento>(listaLimpia);
                cbxDebilidad.ValueMember = "Id";
                cbxDebilidad.DisplayMember = "Descripcion";

                // --- AUTOCOMPLETADO DEBILIDAD ---
                cbxDebilidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxDebilidad.AutoCompleteSource = AutoCompleteSource.ListItems;

                // 5. Si hay un pokemon cargado (MODIFICAR)
                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    tbxUrlImagen.Text = pokemon.UrlImagen;

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
