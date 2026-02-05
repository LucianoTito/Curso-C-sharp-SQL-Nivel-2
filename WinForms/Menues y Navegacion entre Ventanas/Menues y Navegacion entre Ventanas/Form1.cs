namespace Menues_y_Navegacion_entre_Ventanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            string comidaFavorita = cbComidaFavorita.SelectedItem?.ToString() ?? "Ninguna";

            string cantidadDescensos = numContadorDescensos.Value.ToString();

            MessageBox.Show($"Nombre: {nombre}\n" +
                $"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}\n" +
                $"Temporada Favorita: {temporadaFavorita}\n" +
                $"Comida Favorita: {comidaFavorita}\n" +
                $"{sosDeBoca}\n" +
                $"Cantidad de Descensos: {cantidadDescensos}");
        }

        // Añadido: manejador esperado por el Designer para evitar CS0103.
        private void cbComidaFavorita_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comportamiento sugerido: reflejar la selección en textBox2 si existe.
            if (cbComidaFavorita.SelectedItem != null)
            {
                textBox2.Text = cbComidaFavorita.SelectedItem.ToString();
            }
            else
            {
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbComidaFavorita.Items.Add("Italiana");
            cbComidaFavorita.Items.Add("China");
            cbComidaFavorita.Items.Add("Coreana");
            cbComidaFavorita.Items.Add("India");
            cbComidaFavorita.Items.Add("Francesa");
            cbComidaFavorita.Items.Add("Argentina");
        }
    }
}
