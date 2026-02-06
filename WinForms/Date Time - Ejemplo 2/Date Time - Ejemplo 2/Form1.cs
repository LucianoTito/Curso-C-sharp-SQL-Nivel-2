namespace Date_Time___Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value.ToString("dd/MM/yyyy"));

            //Si quiero capturar la fecha y guardarla en alguna variable
            DateTime fecha1;
            fecha1 = dtpFecha.Value;

        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "La fecha seleccionada es: " + calCalendario.SelectionStart);
        }
    }
}
