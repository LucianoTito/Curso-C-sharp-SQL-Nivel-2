namespace Conexiones_con_POKEMON_DB
{
    partial class frmPokemons
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
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).BeginInit();
            SuspendLayout();
            // 
            // dgvPokemons
            // 
            dgvPokemons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemons.Location = new Point(121, 52);
            dgvPokemons.Name = "dgvPokemons";
            dgvPokemons.RowHeadersWidth = 51;
            dgvPokemons.Size = new Size(663, 449);
            dgvPokemons.TabIndex = 0;
            dgvPokemons.CellContentClick += dgvPokemons_CellContentClick;
            // 
            // frmPokemons
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 525);
            Controls.Add(dgvPokemons);
            Name = "frmPokemons";
            Text = "Pokemons";
            Load += frmPokemons_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPokemons;
    }
}
