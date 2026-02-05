namespace Controles_Varios_y_Operador_Ternario
{
    partial class FormPrincipal
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
            txtNombre = new TextBox();
            btnArgegar = new Button();
            lvElementos = new ListView();
            lblNombre = new Label();
            lblFecha = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cbxBoca = new CheckBox();
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            rbInvierno = new RadioButton();
            rbVerano = new RadioButton();
            cbComidaFavorita = new ComboBox();
            lblComidaFavorita = new Label();
            numContadorDescensos = new NumericUpDown();
            lblCantidadDescensos = new Label();
            btnVerPerfil = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContadorDescensos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(330, 150);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 34);
            txtNombre.TabIndex = 0;
            // 
            // btnArgegar
            // 
            btnArgegar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArgegar.Location = new Point(100, 917);
            btnArgegar.Margin = new Padding(1);
            btnArgegar.Name = "btnArgegar";
            btnArgegar.Size = new Size(151, 49);
            btnArgegar.TabIndex = 1;
            btnArgegar.Text = "Agregar";
            btnArgegar.UseVisualStyleBackColor = true;
            btnArgegar.Click += btnArgegar_Click;
            // 
            // lvElementos
            // 
            lvElementos.Location = new Point(100, 646);
            lvElementos.Margin = new Padding(4);
            lvElementos.Name = "lvElementos";
            lvElementos.Size = new Size(265, 217);
            lvElementos.TabIndex = 2;
            lvElementos.UseCompatibleStateImageBehavior = false;
            lvElementos.View = View.List;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.DarkGoldenrod;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonFace;
            lblNombre.Location = new Point(202, 153);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.DarkGoldenrod;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(80, 216);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(211, 28);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(329, 210);
            dtpFechaNacimiento.Margin = new Padding(4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(397, 34);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // cbxBoca
            // 
            cbxBoca.AutoSize = true;
            cbxBoca.BackColor = SystemColors.Highlight;
            cbxBoca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxBoca.ForeColor = Color.Yellow;
            cbxBoca.Location = new Point(330, 283);
            cbxBoca.Margin = new Padding(4);
            cbxBoca.Name = "cbxBoca";
            cbxBoca.Padding = new Padding(7, 0, 4, 0);
            cbxBoca.Size = new Size(192, 32);
            cbxBoca.TabIndex = 6;
            cbxBoca.Text = "Hincha de Boca";
            cbxBoca.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(446, 27);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(142, 46);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "PERFIL ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbInvierno);
            groupBox1.Controls.Add(rbVerano);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(100, 480);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(769, 137);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estación Favorita del Año";
            // 
            // rbInvierno
            // 
            rbInvierno.AutoSize = true;
            rbInvierno.Location = new Point(458, 52);
            rbInvierno.Margin = new Padding(4);
            rbInvierno.Name = "rbInvierno";
            rbInvierno.Size = new Size(123, 35);
            rbInvierno.TabIndex = 1;
            rbInvierno.TabStop = true;
            rbInvierno.Text = "Invierno";
            rbInvierno.UseVisualStyleBackColor = true;
            // 
            // rbVerano
            // 
            rbVerano.AutoSize = true;
            rbVerano.Location = new Point(107, 52);
            rbVerano.Margin = new Padding(4);
            rbVerano.Name = "rbVerano";
            rbVerano.Size = new Size(112, 35);
            rbVerano.TabIndex = 0;
            rbVerano.TabStop = true;
            rbVerano.Text = "Verano";
            rbVerano.UseVisualStyleBackColor = true;
            // 
            // cbComidaFavorita
            // 
            cbComidaFavorita.FormattingEnabled = true;
            cbComidaFavorita.Location = new Point(329, 414);
            cbComidaFavorita.Margin = new Padding(4);
            cbComidaFavorita.Name = "cbComidaFavorita";
            cbComidaFavorita.Size = new Size(390, 36);
            cbComidaFavorita.TabIndex = 9;
            // 
            // lblComidaFavorita
            // 
            lblComidaFavorita.AutoSize = true;
            lblComidaFavorita.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComidaFavorita.ForeColor = SystemColors.ControlLightLight;
            lblComidaFavorita.Location = new Point(100, 414);
            lblComidaFavorita.Margin = new Padding(4, 0, 4, 0);
            lblComidaFavorita.Name = "lblComidaFavorita";
            lblComidaFavorita.Size = new Size(165, 28);
            lblComidaFavorita.TabIndex = 10;
            lblComidaFavorita.Text = "Comida Favorita";
            // 
            // numContadorDescensos
            // 
            numContadorDescensos.Location = new Point(330, 340);
            numContadorDescensos.Name = "numContadorDescensos";
            numContadorDescensos.Size = new Size(150, 34);
            numContadorDescensos.TabIndex = 11;
            // 
            // lblCantidadDescensos
            // 
            lblCantidadDescensos.AutoSize = true;
            lblCantidadDescensos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadDescensos.ForeColor = SystemColors.ButtonFace;
            lblCantidadDescensos.Location = new Point(65, 342);
            lblCantidadDescensos.Name = "lblCantidadDescensos";
            lblCantidadDescensos.Size = new Size(226, 28);
            lblCantidadDescensos.TabIndex = 12;
            lblCantidadDescensos.Text = "Cantidad de descensos";
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(829, 921);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(120, 45);
            btnVerPerfil.TabIndex = 13;
            btnVerPerfil.Text = "Ver Perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(1100, 1002);
            Controls.Add(btnVerPerfil);
            Controls.Add(lblCantidadDescensos);
            Controls.Add(numContadorDescensos);
            Controls.Add(lblComidaFavorita);
            Controls.Add(cbComidaFavorita);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(cbxBoca);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(lvElementos);
            Controls.Add(btnArgegar);
            Controls.Add(txtNombre);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Controles Varios y Operador ternario";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContadorDescensos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnArgegar;
        private ListView lvElementos;
        private Label lblNombre;
        private Label lblFecha;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox cbxBoca;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private RadioButton rbVerano;
        private RadioButton rbInvierno;
        private ComboBox cbComidaFavorita;
        private Label lblComidaFavorita;
        private NumericUpDown numContadorDescensos;
        private Label lblCantidadDescensos;
        private Button btnVerPerfil;
    }
}
