using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Menues_y_Navegacion_entre_Ventanas
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Voy a crear un objeto (una instancia) de la clase Form1 y guardarlo en una variable de tipo Form1
            Form1 ventanaPerfil = new Form1();
            ventanaPerfil.ShowDialog();//Muestro la ventana, permite abrir una sola ventana a la vez.
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventanaPerfil = new Form1();

            ventanaPerfil.ShowDialog();
        }
    }
}
