using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_Básicos_y_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
           //MessageBox.Show("Bienvenido al programa de Controles Básicos y Eventos");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¡AGUANTE BOCAAAA!!");
            string nombre = txtBoxName.Text;
            lblSaludo.Text = "Hola, " + nombre + "! Bienvenido al programa de Controles Básicos y Eventos.";

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el programa de Controles Básicos y Evento. Recuerde que aguante BOCAAAA!");
        }

    }
}
