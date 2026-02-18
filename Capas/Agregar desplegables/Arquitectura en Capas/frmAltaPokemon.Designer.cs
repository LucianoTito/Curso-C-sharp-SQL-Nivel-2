namespace Arquitectura_en_Capas
{
    partial class frmAltaPokemon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumero = new Label();
            lblNombre = new Label();
            lblDecripcion = new Label();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblTipo = new Label();
            lblDebilidad = new Label();
            cbxTipo = new ComboBox();
            cbxDebilidad = new ComboBox();
            lblUrlImagen = new Label();
            tbxUrlImagen = new TextBox();
            pbxPokemon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(31, 37);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(88, 28);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDecripcion
            // 
            lblDecripcion.AutoSize = true;
            lblDecripcion.Location = new Point(12, 145);
            lblDecripcion.Name = "lblDecripcion";
            lblDecripcion.Size = new Size(118, 28);
            lblDecripcion.TabIndex = 2;
            lblDecripcion.Text = "Descripción:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(134, 37);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(242, 34);
            txtNumero.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 34);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(134, 142);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(242, 34);
            txtDescripcion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(242, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 55);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(45, 369);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(132, 55);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(55, 193);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(55, 28);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo:";
            // 
            // lblDebilidad
            // 
            lblDebilidad.AutoSize = true;
            lblDebilidad.Location = new Point(29, 240);
            lblDebilidad.Name = "lblDebilidad";
            lblDebilidad.Size = new Size(101, 28);
            lblDebilidad.TabIndex = 10;
            lblDebilidad.Text = "Debilidad:";
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(136, 190);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(240, 36);
            cbxTipo.TabIndex = 11;
            // 
            // cbxDebilidad
            // 
            cbxDebilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDebilidad.FormattingEnabled = true;
            cbxDebilidad.Location = new Point(136, 237);
            cbxDebilidad.Name = "cbxDebilidad";
            cbxDebilidad.Size = new Size(240, 36);
            cbxDebilidad.TabIndex = 12;
            // 
            // lblUrlImagen
            // 
            lblUrlImagen.AutoSize = true;
            lblUrlImagen.Location = new Point(-2, 286);
            lblUrlImagen.Name = "lblUrlImagen";
            lblUrlImagen.Size = new Size(139, 28);
            lblUrlImagen.TabIndex = 13;
            lblUrlImagen.Text = "Url de Imagen:";
            // 
            // tbxUrlImagen
            // 
            tbxUrlImagen.Location = new Point(136, 286);
            tbxUrlImagen.Name = "tbxUrlImagen";
            tbxUrlImagen.Size = new Size(240, 34);
            tbxUrlImagen.TabIndex = 14;
            // 
            // pbxPokemon
            // 
            pbxPokemon.Location = new Point(437, 26);
            pbxPokemon.Name = "pbxPokemon";
            pbxPokemon.Size = new Size(572, 475);
            pbxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPokemon.TabIndex = 15;
            pbxPokemon.TabStop = false;
            // 
            // frmAltaPokemon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 726);
            Controls.Add(pbxPokemon);
            Controls.Add(tbxUrlImagen);
            Controls.Add(lblUrlImagen);
            Controls.Add(cbxDebilidad);
            Controls.Add(cbxTipo);
            Controls.Add(lblDebilidad);
            Controls.Add(lblTipo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtNumero);
            Controls.Add(lblDecripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblNumero);
            Name = "frmAltaPokemon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Pokemon";
            Load += frmAltaPokemon_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblNombre;
        private Label lblDecripcion;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTipo;
        private Label lblDebilidad;
        private ComboBox cbxTipo;
        private ComboBox cbxDebilidad;
        private Label lblUrlImagen;
        private TextBox tbxUrlImagen;
        private PictureBox pbxPokemon;
    }
}