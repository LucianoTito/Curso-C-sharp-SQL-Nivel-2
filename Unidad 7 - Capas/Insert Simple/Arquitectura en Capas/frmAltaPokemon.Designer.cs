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
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(40, 66);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(88, 28);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDecripcion
            // 
            lblDecripcion.AutoSize = true;
            lblDecripcion.Location = new Point(40, 201);
            lblDecripcion.Name = "lblDecripcion";
            lblDecripcion.Size = new Size(118, 28);
            lblDecripcion.TabIndex = 2;
            lblDecripcion.Text = "Descripción:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(212, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 34);
            txtNumero.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 34);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(212, 201);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(153, 34);
            txtDescripcion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(297, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 55);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(99, 334);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(132, 55);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAltaPokemon
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 451);
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
    }
}