using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
namespace Presentacion
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        //Constructor para modificar un articulo, recibe un articulo como parametro
        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

            Text = "Modificar Artículo";
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                //Carga y autocompletado del comboBox de Marca
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                //Filtro rapido para el comboBox de Marca
                cboMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboMarca.AutoCompleteSource = AutoCompleteSource.ListItems;

                //Carga y autocompletado del comboBox de Categoria
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                //Filtro rapido para el comboBox de Categoria
                cboCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

                //Si no es null carga los datos del articulo a modificar
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.ImagenUrl;

                    txtPrecio.Text = articulo.Precio.ToString();

                    //Desplegables
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los desplegables: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                
                if (!decimal.TryParse(txtPrecio.Text, out decimal precioValido) || precioValido < 0)
                {
                    MessageBox.Show("Ingrese un precio numérico válido.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }

             
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

               
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Precio = precioValido; 

                // Asigno el Id de Marca y Categoria seleccionados en los comboBox
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                // Decido si insertar o actualizar en la BD
                if (articulo.Id != 0)
                {
                    negocio.ModificarArticulo(articulo);
                    MessageBox.Show("Artículo modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.AgregarArticulo(articulo);
                    MessageBox.Show("Artículo agregado exitosamente.", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
