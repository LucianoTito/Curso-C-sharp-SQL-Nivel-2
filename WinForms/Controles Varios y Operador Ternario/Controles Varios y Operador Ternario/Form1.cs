namespace Controles_Varios_y_Operador_Ternario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnArgegar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lvElementos.Items.Add(elemento);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbVerano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cbComidaFavorita.Items.Add("Italiana");
            cbComidaFavorita.Items.Add("China");
            cbComidaFavorita.Items.Add("Coreana");
            cbComidaFavorita.Items.Add("India");
            cbComidaFavorita.Items.Add("Francesa");
            cbComidaFavorita.Items.Add("Argentina");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            //Operador ternario
            string sosDeBoca = cbxBoca.Checked ? "Es de Boca" : "Descendió alguna vez";

            string temporadaFavorita;
            if (rbVerano.Checked)
            {
                temporadaFavorita = "Verano";
            }
            else 
            {
                temporadaFavorita = "Invierno";
            }

            string comidaFavorita = cbComidaFavorita.SelectedItem.ToString();

            string cantidadDescensos = numContadorDescensos.Value.ToString();

            MessageBox.Show($"Nombre: {nombre}\n" +
                $"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}\n" +
                $"Temporada Favorita: {temporadaFavorita}\n" +
                $"Comida Favorita: {comidaFavorita}\n" +
                $"{sosDeBoca}\n" +
                $"Cantidad de Descensos: {cantidadDescensos}");

        }
    }
}
