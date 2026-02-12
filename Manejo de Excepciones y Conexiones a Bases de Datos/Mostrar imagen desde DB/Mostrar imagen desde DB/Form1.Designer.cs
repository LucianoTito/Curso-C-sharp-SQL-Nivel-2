namespace Mostrar_imagen_desde_DB
{
    partial class frmPokemon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPokemons = new DataGridView();
            pbxPokemon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemons
            // 
            dgvPokemons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemons.Location = new Point(26, 12);
            dgvPokemons.Name = "dgvPokemons";
            dgvPokemons.RowHeadersWidth = 51;
            dgvPokemons.Size = new Size(640, 714);
            dgvPokemons.TabIndex = 0;
            dgvPokemons.SelectionChanged += dgvPokemons_SelectionChanged;
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(672, 12);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(554, 714);
            pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPokemon.TabIndex = 1;
            pbxPokemon.TabStop = false;
            // 
            // frmPokemon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 738);
            Controls.Add(pbxPokemon);
            Controls.Add(dgvPokemons);
            Name = "frmPokemon";
            Text = "Cargar imagen en Pokemon DB";
            Load += frmPokemon_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPokemons;
        private PictureBox pbxPokemon;
    }
}
