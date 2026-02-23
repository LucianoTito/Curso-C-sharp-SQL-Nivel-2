namespace Finally_y_Throw_en_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;
            try
            {
                // 1. REGLA DE NEGOCIO (El uso del throw)
                // Revisamos si alguno de los TextBox está vacío
                if (txtNum1.Text == "" || txtNum2.Text == "")
                {
                    // Si están vacíos, lanzamos nuestra propia excepción y el código se detiene aquí.
                    //No intentará hacer el int.Parse. Salta directo al catch.
                    throw new Exception("¡Atención! Por favor, completa los dos números antes de calcular.");
                }

                // 2. Si pasó la barrera de arriba, el código sigue normalmente
                numero1 = int.Parse(txtNum1.Text);
                numero2 = int.Parse(txtNum2.Text);

                resultado = numero1 / numero2;
                lbResultado.Text = "= " + resultado;
            }
            catch (Exception ex)
            {
                // Si nuestro throw se activó, el mensaje que escribimos arriba
                // viajará hasta aquí y se guardará en "ex.Message".
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // El bloque finally se ejecuta siempre, haya o no una excepción. 
                // Sirve para liberar recursos, cerrar conexiones, etc.
                MessageBox.Show("Proceso terminado");
            }
        }
    }
}