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
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).BeginInit();
            SuspendLayout();
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(1147, 45);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(606, 539);
            pbxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPokemon.TabIndex = 0;
            pbxPokemon.TabStop = false;
            // 
            // dgvPokemons
            // 
            dgvPokemons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPokemons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPokemons.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPokemons.Location = new Point(12, 45);
            dgvPokemons.MultiSelect = false;
            dgvPokemons.Name = "dgvPokemons";
            dgvPokemons.RowHeadersWidth = 51;
            dgvPokemons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPokemons.Size = new Size(1129, 812);
            dgvPokemons.TabIndex = 1;
            dgvPokemons.SelectionChanged += dgvPokemons_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 863);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 61);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmPokemon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 951);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPokemons);
            Controls.Add(pbxPokemon);
            Name = "frmPokemon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Desplegables ";
            Load += frmPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxPokemon;
        private DataGridView dgvPokemons;
        private Button btnAgregar;
    }
}
