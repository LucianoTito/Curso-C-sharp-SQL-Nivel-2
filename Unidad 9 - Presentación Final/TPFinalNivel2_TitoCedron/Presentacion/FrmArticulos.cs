using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;  
using Dominio;

namespace Presentacion
{
    public partial class FrmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public FrmArticulos()
        {
            InitializeComponent();
            dgvArticulos.RowTemplate.Height = 100;

            dgvArticulos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }



        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            CargarArticulos();

        }

        private void CargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulos.DataSource = listaArticulos;

                ocultarColumnas();
     
                dgvArticulos.Columns["Descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                 
                dgvArticulos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";

                if (listaArticulos != null && listaArticulos.Count > 0)
                {
                    cargarImagen(listaArticulos[0].ImagenUrl);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el catálogo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ocultarColumnas()
        {
            if (dgvArticulos.Columns["ImagenUrl"] != null)
                dgvArticulos.Columns["ImagenUrl"].Visible = false;

            if (dgvArticulos.Columns["Id"] != null)
                dgvArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            const string imagenDefault = "https://cdn-icons-png.flaticon.com/512/11542/11542598.png";
            try
            {
                if (string.IsNullOrEmpty(imagen))
                {
                    pbxArticulo.Load(imagenDefault);

                }
                else
                {
                    pbxArticulo.Load(imagen);
                }

            }
            catch (Exception)
            {

                if (pbxArticulo != null)
                    pbxArticulo.Load(imagenDefault);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }

        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = txtFiltroRapido.Text;

            if(filtro == "")
            {
                listaFiltrada = listaArticulos;
            }
            else
            {
                listaFiltrada = listaArticulos.FindAll(    
                x =>
                x.Nombre.ToLower().Contains(filtro.ToLower()) ||
                x.Descripcion.ToLower().Contains(filtro.ToLower()) ||
                x.Marca.Descripcion.ToLower().Contains(filtro.ToLower()) ||
                x.Categoria.Descripcion.ToLower().Contains(filtro.ToLower())
                   );
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            ocultarColumnas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
            CargarArticulos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un artículo de la grilla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
                
            }
            try
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                
                FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
                modificar.ShowDialog();

                CargarArticulos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al cargar el formulario de modificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un artículo de la grilla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Atrapamos el artículo seleccionado
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                //Confirmamos la eliminación
                DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar el artículo '{seleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(seleccionado.Id);
                    CargarArticulos();
                    MessageBox.Show("Artículo eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}