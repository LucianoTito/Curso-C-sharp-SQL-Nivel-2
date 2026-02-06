namespace Ventanas_Contenedoras
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnVerPerfil = new Button();
            SuspendLayout();
            // 
            // lbPerfil
            // 
            lbPerfil.AutoSize = true;
            lbPerfil.Location = new Point(348, 26);
            lbPerfil.Name = "lbPerfil";
            lbPerfil.Size = new Size(55, 28);
            lbPerfil.TabIndex = 0;
            lbPerfil.Text = "Perfil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.Location = new Point(70, 323);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(129, 59);
            btnVerPerfil.TabIndex = 5;
            btnVerPerfil.Text = "Ver Perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerPerfil);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbPerfil);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPerfil;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVerPerfil;
    }
}
