namespace Finally_y_Throw_en_Excepciones
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            lbNum2 = new Label();
            txtNum2 = new TextBox();
            btnCalcular = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(203, 56);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(183, 28);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Ingrese un Número:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(388, 50);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 34);
            txtNum1.TabIndex = 1;
            // 
            // lbNum2
            // 
            lbNum2.AutoSize = true;
            lbNum2.Location = new Point(198, 140);
            lbNum2.Name = "lbNum2";
            lbNum2.Size = new Size(188, 28);
            lbNum2.TabIndex = 2;
            lbNum2.Text = "Ingrese un Número: ";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(388, 134);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 34);
            txtNum2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(348, 238);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 60);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(331, 348);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(102, 28);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum2);
            Controls.Add(lbNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Finally y Throw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private Label lbNum2;
        private TextBox txtNum2;
        private Button btnCalcular;
        private Label lbResultado;
    }
}
