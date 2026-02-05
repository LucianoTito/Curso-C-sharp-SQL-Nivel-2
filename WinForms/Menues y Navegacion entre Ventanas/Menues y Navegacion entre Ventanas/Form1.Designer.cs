namespace Menues_y_Navegacion_entre_Ventanas
{
    partial class Form1
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
            lbPerfil = new Label();
            lbNombre = new Label();
            lbFechaNacimiento = new Label();
            lbComidaFavorita = new Label();
            lbCantidadDescensos = new Label();
            cbxBoca = new CheckBox();
            gbEstacionFavorita = new GroupBox();
            rbInvierno = new RadioButton();
            rbVerano = new RadioButton();
            btnVerPerfil = new Button();
            textBox2 = new TextBox();
            cbComidaFavorita = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtNombre = new TextBox();
            numContadorDescensos = new NumericUpDown();
            btnAgregar = new Button();
            gbEstacionFavorita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContadorDescensos).BeginInit();
            SuspendLayout();
            // 
            // lbPerfil
            // 
            lbPerfil.AutoSize = true;
            lbPerfil.Location = new Point(332, 35);
            lbPerfil.Name = "lbPerfil";
            lbPerfil.Size = new Size(55, 28);
            lbPerfil.TabIndex = 0;
            lbPerfil.Text = "Perfil";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(100, 88);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(94, 28);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre: ";
            // 
            // lbFechaNacimiento
            // 
            lbFechaNacimiento.AutoSize = true;
            lbFechaNacimiento.Location = new Point(100, 150);
            lbFechaNacimiento.Name = "lbFechaNacimiento";
            lbFechaNacimiento.Size = new Size(172, 28);
            lbFechaNacimiento.TabIndex = 2;
            lbFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lbComidaFavorita
            // 
            lbComidaFavorita.AutoSize = true;
            lbComidaFavorita.Location = new Point(100, 319);
            lbComidaFavorita.Name = "lbComidaFavorita";
            lbComidaFavorita.Size = new Size(159, 28);
            lbComidaFavorita.TabIndex = 3;
            lbComidaFavorita.Text = "Comida Favorita:";
            // 
            // lbCantidadDescensos
            // 
            lbCantidadDescensos.AutoSize = true;
            lbCantidadDescensos.Location = new Point(100, 263);
            lbCantidadDescensos.Name = "lbCantidadDescensos";
            lbCantidadDescensos.Size = new Size(217, 28);
            lbCantidadDescensos.TabIndex = 4;
            lbCantidadDescensos.Text = "Cantidad de Descensos:";
            // 
            // cbxBoca
            // 
            cbxBoca.AutoSize = true;
            cbxBoca.Location = new Point(100, 210);
            cbxBoca.Name = "cbxBoca";
            cbxBoca.Size = new Size(168, 32);
            cbxBoca.TabIndex = 5;
            cbxBoca.Text = "Hincha de Boca";
            cbxBoca.UseVisualStyleBackColor = true;
            // 
            // gbEstacionFavorita
            // 
            gbEstacionFavorita.Controls.Add(rbInvierno);
            gbEstacionFavorita.Controls.Add(rbVerano);
            gbEstacionFavorita.Location = new Point(80, 370);
            gbEstacionFavorita.Name = "gbEstacionFavorita";
            gbEstacionFavorita.Size = new Size(408, 133);
            gbEstacionFavorita.TabIndex = 6;
            gbEstacionFavorita.TabStop = false;
            gbEstacionFavorita.Text = "Estacion Favorita del Año";
            // 
            // rbInvierno
            // 
            rbInvierno.AutoSize = true;
            rbInvierno.Location = new Point(159, 62);
            rbInvierno.Name = "rbInvierno";
            rbInvierno.Size = new Size(104, 32);
            rbInvierno.TabIndex = 1;
            rbInvierno.TabStop = true;
            rbInvierno.Text = "Invierno";
            rbInvierno.UseVisualStyleBackColor = true;
            // 
            // rbVerano
            // 
            rbVerano.AutoSize = true;
            rbVerano.Location = new Point(6, 62);
            rbVerano.Name = "rbVerano";
            rbVerano.Size = new Size(94, 32);
            rbVerano.TabIndex = 0;
            rbVerano.TabStop = true;
            rbVerano.Text = "Verano";
            rbVerano.UseVisualStyleBackColor = true;
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(80, 509);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(114, 47);
            btnVerPerfil.TabIndex = 7;
            btnVerPerfil.Text = "Ver Perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 589);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 34);
            textBox2.TabIndex = 9;
            // 
            // cbComidaFavorita
            // 
            cbComidaFavorita.FormattingEnabled = true;
            cbComidaFavorita.Location = new Point(265, 316);
            cbComidaFavorita.Name = "cbComidaFavorita";
            cbComidaFavorita.Size = new Size(223, 36);
            cbComidaFavorita.TabIndex = 11;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(290, 150);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 34);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 34);
            txtNombre.TabIndex = 13;
            // 
            // numContadorDescensos
            // 
            numContadorDescensos.Location = new Point(332, 261);
            numContadorDescensos.Name = "numContadorDescensos";
            numContadorDescensos.Size = new Size(143, 34);
            numContadorDescensos.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(86, 675);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 43);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 761);
            Controls.Add(btnAgregar);
            Controls.Add(numContadorDescensos);
            Controls.Add(txtNombre);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cbComidaFavorita);
            Controls.Add(textBox2);
            Controls.Add(btnVerPerfil);
            Controls.Add(gbEstacionFavorita);
            Controls.Add(cbxBoca);
            Controls.Add(lbCantidadDescensos);
            Controls.Add(lbComidaFavorita);
            Controls.Add(lbFechaNacimiento);
            Controls.Add(lbNombre);
            Controls.Add(lbPerfil);
            Name = "Form1";
            Text = "Menues y Navegación entre Ventanas";
            Load += Form1_Load;
            gbEstacionFavorita.ResumeLayout(false);
            gbEstacionFavorita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContadorDescensos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPerfil;
        private Label lbNombre;
        private Label lbFechaNacimiento;
        private Label lbComidaFavorita;
        private Label lbCantidadDescensos;
        private CheckBox cbxBoca;
        private GroupBox gbEstacionFavorita;
        private RadioButton rbInvierno;
        private RadioButton rbVerano;
        private Button btnVerPerfil;
        private TextBox textBox2;
        private ComboBox cbComidaFavorita;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNombre;
        private NumericUpDown numContadorDescensos;
        private Button btnAgregar;
    }
}
