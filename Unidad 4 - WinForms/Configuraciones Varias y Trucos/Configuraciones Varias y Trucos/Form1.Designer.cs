namespace Configuraciones_Varias_y_Trucos
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
            lbCantidadDescensos = new Label();
            lbFechaNacimiento = new Label();
            label5 = new Label();
            cbxBoca = new CheckBox();
            numContadorDescensos = new NumericUpDown();
            txtNombre = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            gbEstacionFavorita = new GroupBox();
            rbInvierno = new RadioButton();
            rbVerano = new RadioButton();
            cbComidaFavorita = new ComboBox();
            btnVerPerfil = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)numContadorDescensos).BeginInit();
            gbEstacionFavorita.SuspendLayout();
            SuspendLayout();
            // 
            // lbPerfil
            // 
            lbPerfil.AutoSize = true;
            lbPerfil.Location = new Point(358, 29);
            lbPerfil.Name = "lbPerfil";
            lbPerfil.Size = new Size(55, 28);
            lbPerfil.TabIndex = 12;
            lbPerfil.Text = "Perfil";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(71, 69);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(89, 28);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre:";
            // 
            // lbCantidadDescensos
            // 
            lbCantidadDescensos.AutoSize = true;
            lbCantidadDescensos.Location = new Point(71, 199);
            lbCantidadDescensos.Name = "lbCantidadDescensos";
            lbCantidadDescensos.Size = new Size(217, 28);
            lbCantidadDescensos.TabIndex = 9;
            lbCantidadDescensos.Text = "Cantidad de Descensos:";
            // 
            // lbFechaNacimiento
            // 
            lbFechaNacimiento.AutoSize = true;
            lbFechaNacimiento.Location = new Point(71, 108);
            lbFechaNacimiento.Name = "lbFechaNacimiento";
            lbFechaNacimiento.Size = new Size(172, 28);
            lbFechaNacimiento.TabIndex = 11;
            lbFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 245);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 10;
            label5.Text = "Comida Favorita:";
            // 
            // cbxBoca
            // 
            cbxBoca.AutoSize = true;
            cbxBoca.Location = new Point(71, 155);
            cbxBoca.Name = "cbxBoca";
            cbxBoca.Size = new Size(168, 32);
            cbxBoca.TabIndex = 3;
            cbxBoca.Text = "Hincha de Boca";
            cbxBoca.UseVisualStyleBackColor = true;
            // 
            // numContadorDescensos
            // 
            numContadorDescensos.Location = new Point(294, 193);
            numContadorDescensos.Name = "numContadorDescensos";
            numContadorDescensos.Size = new Size(150, 34);
            numContadorDescensos.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(166, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 34);
            txtNombre.TabIndex = 0;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNacimiento.Location = new Point(249, 103);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(249, 34);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // gbEstacionFavorita
            // 
            gbEstacionFavorita.Controls.Add(rbInvierno);
            gbEstacionFavorita.Controls.Add(rbVerano);
            gbEstacionFavorita.Location = new Point(71, 374);
            gbEstacionFavorita.Name = "gbEstacionFavorita";
            gbEstacionFavorita.Size = new Size(450, 125);
            gbEstacionFavorita.TabIndex = 6;
            gbEstacionFavorita.TabStop = false;
            gbEstacionFavorita.Text = "Estacion Favorita del Año";
            // 
            // rbInvierno
            // 
            rbInvierno.AutoSize = true;
            rbInvierno.Location = new Point(256, 64);
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
            rbVerano.Location = new Point(30, 57);
            rbVerano.Name = "rbVerano";
            rbVerano.Size = new Size(94, 32);
            rbVerano.TabIndex = 0;
            rbVerano.TabStop = true;
            rbVerano.Text = "Verano";
            rbVerano.UseVisualStyleBackColor = true;
            // 
            // cbComidaFavorita
            // 
            cbComidaFavorita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbComidaFavorita.FormattingEnabled = true;
            cbComidaFavorita.Location = new Point(226, 245);
            cbComidaFavorita.Name = "cbComidaFavorita";
            cbComidaFavorita.Size = new Size(335, 36);
            cbComidaFavorita.TabIndex = 5;
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(75, 537);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(120, 61);
            btnVerPerfil.TabIndex = 7;
            btnVerPerfil.Text = "&Ver Perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(329, 642);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "A&gregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 720);
            Controls.Add(btnAgregar);
            Controls.Add(btnVerPerfil);
            Controls.Add(cbComidaFavorita);
            Controls.Add(gbEstacionFavorita);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNombre);
            Controls.Add(numContadorDescensos);
            Controls.Add(cbxBoca);
            Controls.Add(label5);
            Controls.Add(lbFechaNacimiento);
            Controls.Add(lbCantidadDescensos);
            Controls.Add(lbNombre);
            Controls.Add(lbPerfil);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(817, 769);
            MinimumSize = new Size(521, 616);
            Name = "Form1";
            Text = "Configuraciones Varias y Trucos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numContadorDescensos).EndInit();
            gbEstacionFavorita.ResumeLayout(false);
            gbEstacionFavorita.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPerfil;
        private Label lbNombre;
        private Label lbCantidadDescensos;
        private Label lbFechaNacimiento;
        private Label label5;
        private CheckBox cbxBoca;
        private NumericUpDown numContadorDescensos;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private GroupBox gbEstacionFavorita;
        private RadioButton rbInvierno;
        private RadioButton rbVerano;
        private ComboBox cbComidaFavorita;
        private Button btnVerPerfil;
        private Button btnAgregar;
    }
}
