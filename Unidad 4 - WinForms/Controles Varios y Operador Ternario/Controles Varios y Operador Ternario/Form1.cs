namespace Controles_Varios_y_Operador_Ternario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }



        private void btnArgegar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            lvElementos.Items.Add(elemento);
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

            // Intenta convertir a string. Si es nulo, guarda "Ninguna".
            string comidaFavorita = cbComidaFavorita.SelectedItem?.ToString() ?? "Ninguna"; //El doble signo de interrogación es para valores nulos.
                                                                                            //Ese doble signo de interrogación ?? se llama Operador de Coalescencia Nula (Null-Coalescing Operator).



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
