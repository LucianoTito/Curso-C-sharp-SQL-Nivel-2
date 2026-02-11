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
                resultado = numero1 + numero2;
                lbResultado.Text = " = " + resultado;
            }
            catch (FormatException ex)//Genera un objeto de tipo excepción, y lo guarda en la variable ex, para luego mostrar el mensaje de error.
            {
                MessageBox.Show("Ingrese un número válido", "Error"  );
                MessageBox.Show(ex.ToString());

            }
            catch(DivideByZeroException )
            {
                MessageBox.Show("No se puede dividir por cero", "Error");
              
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número es demasiado grande o demasiado pequeño", "Error");
            }
            finally
            {
                MessageBox.Show("Proceso finalizado");
            }
        }
    }
}
