namespace Arquitectura_en_Capas
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
            pbxPokemon = new PictureBox();
            dgvPokemons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).BeginInit();
            SuspendLayout();
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(830, 63);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(544, 463);
            pbxPokemon.TabIndex = 0;
            pbxPokemon.TabStop = false;
            // 
            // dgvPokemons
            // 
            dgvPokemons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemons.Location = new Point(12, 45);
            dgvPokemons.Name = "dgvPokemons";
            dgvPokemons.RowHeadersWidth = 51;
            dgvPokemons.Size = new Size(812, 744);
            dgvPokemons.TabIndex = 1;
            dgvPokemons.SelectionChanged += dgvPokemons_SelectionChanged;
            // 
            // frmPokemon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 841);
            Controls.Add(dgvPokemons);
            Controls.Add(pbxPokemon);
            Name = "frmPokemon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arquitectura en capas";
            Load += frmPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxPokemon;
        private DataGridView dgvPokemons;
    }
}
