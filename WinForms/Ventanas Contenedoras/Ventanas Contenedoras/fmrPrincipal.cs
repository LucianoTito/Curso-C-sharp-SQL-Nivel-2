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
            Form1 ventanaPerfil = new Form1();
            ventanaPerfil.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 ventanaPerfil = new Form1();
            ventanaPerfil.ShowDialog();
        }
    }
}
