using System;
using System.Linq;
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

                ajustarFilas();
                ocultarColumnas();

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
        //MÉTODO PARA OCULTAR COLUMNAS URL y ID
        private void ocultarColumnas()
        {

            // Ocultamos la columna de Url y Id
            var colUrl = dgvPokemons.Columns["UrlImagen"];
            if (colUrl != null)
            {
                colUrl.Visible = false;
            }
            var colId = dgvPokemons.Columns["Id"];
            if (colId != null)
            { colId.Visible = false; }


        }

        //MÉTODO PARA AJUSTAR EL TAMAÑO DE LAS FILAS SEGÚN EL CONTENIDO DE LA COLUMNA DESCRIPCIÓN

        void ajustarFilas()
        {

            // Que la columna Descripcion ocupe todo el espacio disponible
            var colDescripcion = dgvPokemons.Columns["Descripcion"];
            if (colDescripcion != null)
            {
                colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                // Permitir salto de línea en la celda específica de Descripcion
                colDescripcion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        // ---------------------------------------------------------
        // EVENTO LOAD
        // ---------------------------------------------------------
        private void frmPokemon_Load(object sender, EventArgs e)
        {
            cargarPokemon();

            // CARGA MANUAL DE COMBOBOX:
            // A diferencia de la grilla que usa un DataSource conectado a la base de datos,
            // aquí estamos metiendo las opciones "a mano" (Hardcodeadas) porque son pocas y fijas.
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Tipo");
            cboCampo.Items.Add("Debilidad");
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
            ;
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar(logico: false);
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(logico: true);

        }

        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                // Validamos que haya una fila seleccionada antes de intentar hacer nada
                if (dgvPokemons.CurrentRow != null)
                {
                    // Extraemos el objeto
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    // PEDIMOS CONFIRMACIÓN AL USUARIO
                    // Esto abre una ventanita con los botones "Sí" y "No"
                    DialogResult respuesta = MessageBox.Show(
                        "¿Estás seguro que deseas eliminar el Pokémon " + seleccionado.Nombre + "?",
                        "Eliminando",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    // Si el usuario presiona "Sí", entonces eliminamos
                    if (respuesta == DialogResult.Yes)
                    {
                        if (logico)
                        {
                            negocio.EliminarLogico(seleccionado.Id);
                        }
                        else
                            negocio.EliminarPokemon(seleccionado.Id);
                        cargarPokemon(); // Recargamos la grilla para que desaparezca visualmente
                    }
                }
                else
                {
                    // Si el usuario hizo clic en eliminar pero la grilla estaba vacía
                    MessageBox.Show("Por favor, seleccione un Pokémon de la grilla para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ---------------------------------------------------------
        // BOTÓN FILTRAR
        // ---------------------------------------------------------
        // 1. PRIMERO AGREGAMOS AL GUARDIA DE SEGURIDAD (Cópialo justo arriba de tu botón filtrar)
        private bool validarFiltro()
        {
            // Validamos que haya seleccionado un Campo
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true; // Retorna true indicando que HUBO un error
            }

            // Validamos que haya seleccionado un Criterio
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }

            // Validamos que si eligió "Número", la nueva caja de texto no esté vacía
            if (cboCampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar un número en el filtro avanzado.");
                    return true;
                }
            }

            return false; // Retorna false si todo está perfecto y podemos buscar
        }

        // 2. BOTÓN FILTRAR
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                // Llamamos al guardia. Si devuelve true, cortamos la ejecución para que no explote SQL
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();

                // ¡AQUÍ ESTÁ LA CORRECCIÓN! Usamos la caja avanzada
                string filtro = txtFiltroAvanzado.Text;

                // Enviamos todo a la base de datos
                dgvPokemons.DataSource = negocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

            // 1. LA CAJA RECEPTORA:
            // Creamos una lista temporal que solo va a existir mientras dure este clic.
            // Aquí guardaremos los Pokémones que pasen la prueba del filtro.
            List<Pokemon> listaFiltrada;

            // 2. CAPTURAMOS EL TEXTO:
            // Guardamos lo que el usuario escribió en la caja de texto en una variable.
            string filtro = txtFiltro.Text;

            // 3. LA DECISIÓN: ¿Hay texto o está vacío?
            if (filtro == "")
            {
                // Si el usuario borró todo y le dio a filtrar (o no escribió nada),
                // le decimos a nuestra lista filtrada que sea igual a la lista original completa.
                // Es nuestra forma de "reiniciar" la grilla.
                listaFiltrada = listaPokemons;
            }
            else
            {
                // 4. EL MOTOR DE BÚSQUEDA (La Magia):
                // Usamos FindAll para decirle a la lista: "Tráeme a TODOS los que cumplan esta condición".
                listaFiltrada = listaPokemons.FindAll(e =>
                    // Condición A: Compara el Nombre.
                    // Pasa el nombre original a minúsculas (.ToLower()) y se fija si CONTIENE (.Contains) 
                    // el texto del filtro también pasado a minúsculas. Así "Pikachu" y "pika" coinciden.
                    e.Nombre.ToLower().Contains(filtro.ToLower())

                    || // Este operador significa "O" (Con que se cumpla la Condición A o la B, es válido).

                    // Condición B: Compara la Descripción del Tipo.
                    // Hace exactamente lo mismo, pero buscando si el filtro coincide con "Fuego", "Agua", etc.
                    e.Tipo.Descripcion.ToLower().Contains(filtro.ToLower())
                );
            }

            // 5. EL RESETEO FORZADO DE LA GRILLA:
            // Le quitamos la lista anterior dejándola en null para que la grilla "olvide" lo que tenía.
            dgvPokemons.DataSource = null;

            // 6. LA RECARGA VISUAL:
            // Le enchufamos la nueva lista (ya sea la completa o la filtrada).
            dgvPokemons.DataSource = listaFiltrada;

            // 7. RESTAURAR FORMATO:
            // Como al poner DataSource en null la grilla se "desarmó", 
            // volvemos a llamar a nuestros métodos de diseño para ocultar columnas y acomodar los textos.
            ajustarFilas();
            ocultarColumnas();

        }

        // Este evento se dispara AUTOMÁTICAMENTE cada vez que el usuario hace clic 
        // en el primer ComboBox (cboCampo) y elige una opción diferente.
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var opcion = cboCampo.SelectedItem as string;
            if (string.IsNullOrEmpty(opcion))
            {
                cboCriterio.Items.Clear();
                return;
            }

            cboCriterio.Items.Clear();

            if (opcion == "Número")
            {
                cboCriterio.Items.Add("Mayor a...");
                cboCriterio.Items.Add("Menor a...");
                cboCriterio.Items.Add("Igual a...");
            }
            // 3. LÓGICA DE TEXTO:
            // Usamos el operador lógico OR (||) porque el criterio de búsqueda es el mismo 
            // sin importar si busca por Nombre o por Descripción.
            else if (opcion == "Nombre" || opcion == "Descripción")
            {
                cboCriterio.Items.Clear(); // Vaciamos por seguridad
                cboCriterio.Items.Add("Contiene...");
                cboCriterio.Items.Add("Comienza con...");
                cboCriterio.Items.Add("Termina con...");
            }
            // 4. LÓGICA DE LISTAS CERRADAS:
            // Tipo y Debilidad también son textos, pero no tiene sentido buscar si un tipo "comienza con...".
            // Lo ideal es buscar coincidencias exactas ("Igual a...").
            else if (opcion == "Tipo" || opcion == "Debilidad")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Igual a...");
            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos las cajas de texto (Filtro rápido y avanzado)
            txtFiltro.Text = "";
            txtFiltroAvanzado.Text = "";

            // 2. Reseteamos los ComboBoxes dejándolos sin selección
            // El índice -1 significa "nada seleccionado"
            cboCampo.SelectedIndex = -1;

            // Como el Criterio depende del Campo, simplemente lo vaciamos
            cboCriterio.Items.Clear();

            // 3. Volvemos a cargar la grilla original desde la base de datos
            cargarPokemon();
        }
    }
}