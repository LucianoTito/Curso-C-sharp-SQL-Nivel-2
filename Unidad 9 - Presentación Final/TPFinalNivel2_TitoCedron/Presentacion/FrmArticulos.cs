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
             string imagenDefault = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png";
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

                try
                {
                    pbxArticulo.Load(imagenDefault);
                }
                catch (Exception)
                {

                    pbxArticulo.Image = null;
                }
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
    }
}