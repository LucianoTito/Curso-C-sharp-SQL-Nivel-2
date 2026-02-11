namespace Manejo_de_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCalculo_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;
            try
            {    
                numero1 = int.Parse(PrimerNumero.Text);
                numero2 = int.Parse(SegundoNumero.Text);
                resultado = numero1 / numero2;
                //resultado = numero1 + numero2; // <-- Para probar el manejo de excepciones, puedes cambiar la operación a suma, resta o multiplicación, y luego volver a división para probar cada caso.
                lbResultado.Text = " = " + resultado;
            }
            catch (FormatException ex)//Genera un objeto de tipo excepción, y lo guarda en la variable ex, para luego mostrar el mensaje de error.
            {
                MessageBox.Show("Ingrese un número válido", "Error"  );
                MessageBox.Show(ex.ToString());

            }
            catch(DivideByZeroException ex )
            {
                MessageBox.Show("No se puede dividir por cero", "Error");
                MessageBox.Show(ex.ToString());


            }
            catch (OverflowException ex)
            {
                MessageBox.Show("El número es demasiado grande o demasiado pequeño", "Error");
                MessageBox.Show(ex.ToString());

            }

            catch (Exception ex) // <--- LA RED FINAL: Captura cualquier otro tipo de excepción que no haya sido manejada por los catch anteriores. BUENA PRACTICA.
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error Crítico");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Proceso finalizado");
            }
        }
    }
}
