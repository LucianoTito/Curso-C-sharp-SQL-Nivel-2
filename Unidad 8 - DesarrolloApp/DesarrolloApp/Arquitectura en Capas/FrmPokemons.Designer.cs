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
            btnModificar = new Button();
            btnEliminarFisico = new Button();
            btnElimnarLogica = new Button();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            btnFiltrar = new Button();
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
            // btnModificar
            // 
            btnModificar.Location = new Point(153, 865);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(125, 61);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Location = new Point(303, 865);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new Size(184, 61);
            btnEliminarFisico.TabIndex = 4;
            btnEliminarFisico.Text = "Eliminar Fisico";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnElimnarLogica
            // 
            btnElimnarLogica.Location = new Point(488, 865);
            btnElimnarLogica.Name = "btnElimnarLogica";
            btnElimnarLogica.Size = new Size(184, 61);
            btnElimnarLogica.TabIndex = 5;
            btnElimnarLogica.Text = "Eliminar Lógico";
            btnElimnarLogica.UseVisualStyleBackColor = true;
            btnElimnarLogica.Click += btnEliminarLogico_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(138, 14);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(67, 28);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = SystemColors.Menu;
            txtFiltro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = Color.Black;
            txtFiltro.Location = new Point(224, 8);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(247, 34);
            txtFiltro.TabIndex = 7;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(488, 8);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(129, 35);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "BUSCAR";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // frmPokemon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 951);
            Controls.Add(btnFiltrar);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnElimnarLogica);
            Controls.Add(btnEliminarFisico);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPokemons);
            Controls.Add(pbxPokemon);
            Name = "frmPokemon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DesarrolloApp";
            Load += frmPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPokemons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pbxPokemon;
        private DataGridView dgvPokemons;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminarFisico;
        private Button btnElimnarLogica;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Button btnFiltrar;
    }
}
