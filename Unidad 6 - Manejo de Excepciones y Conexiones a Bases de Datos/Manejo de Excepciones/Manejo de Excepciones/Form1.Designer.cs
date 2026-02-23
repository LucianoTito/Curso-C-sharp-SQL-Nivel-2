namespace Manejo_de_Excepciones
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
            PrimerNumero = new TextBox();
            label1 = new Label();
            SegundoNumero = new TextBox();
            label2 = new Label();
            btnCalculo = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // PrimerNumero
            // 
            PrimerNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrimerNumero.ForeColor = SystemColors.ControlText;
            PrimerNumero.Location = new Point(396, 96);
            PrimerNumero.Name = "PrimerNumero";
            PrimerNumero.Size = new Size(125, 34);
            PrimerNumero.TabIndex = 0;
            PrimerNumero.TextAlign = HorizontalAlignment.Center;
            PrimerNumero.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 102);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un Número";
            // 
            // SegundoNumero
            // 
            SegundoNumero.ForeColor = SystemColors.ControlText;
            SegundoNumero.Location = new Point(396, 151);
            SegundoNumero.Name = "SegundoNumero";
            SegundoNumero.Size = new Size(125, 34);
            SegundoNumero.TabIndex = 2;
            SegundoNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 157);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 3;
            label2.Text = "Ingrese un Número";
            // 
            // btnCalculo
            // 
            btnCalculo.BackColor = Color.FromArgb(255, 224, 192);
            btnCalculo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculo.ForeColor = SystemColors.MenuHighlight;
            btnCalculo.Location = new Point(290, 222);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(201, 57);
            btnCalculo.TabIndex = 4;
            btnCalculo.Text = "CALCULAR";
            btnCalculo.UseVisualStyleBackColor = false;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(315, 322);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(146, 28);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "El resultado es: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnCalculo);
            Controls.Add(label2);
            Controls.Add(SegundoNumero);
            Controls.Add(label1);
            Controls.Add(PrimerNumero);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manejo de Excepciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PrimerNumero;
        private Label label1;
        private TextBox SegundoNumero;
        private Label label2;
        private Button btnCalculo;
        private Label lbResultado;
    }
}
