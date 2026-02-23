using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ventanas_Contenedoras
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Validación para que la ventana no se abra más de una vez
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(Form1))
                {
                    MessageBox.Show("La ventana ya está abierta");
                    return;
                }
            }
            Form1 ventanaPerfil = new Form1();
            ventanaPerfil.MdiParent = this;
            ventanaPerfil.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 ventanaPerfil = new Form1();
            ventanaPerfil.ShowDialog();
        }
    }
}
