namespace Date_Time___Ejemplo_2
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
            dtpFecha = new DateTimePicker();
            calCalendario = new MonthCalendar();
            btnPrueba1 = new Button();
            btnPrueba2 = new Button();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(148, 90);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(440, 34);
            dtpFecha.TabIndex = 0;
            // 
            // calCalendario
            // 
            calCalendario.Location = new Point(157, 186);
            calCalendario.Name = "calCalendario";
            calCalendario.TabIndex = 1;
            // 
            // btnPrueba1
            // 
            btnPrueba1.Location = new Point(627, 90);
            btnPrueba1.Name = "btnPrueba1";
            btnPrueba1.Size = new Size(130, 60);
            btnPrueba1.TabIndex = 2;
            btnPrueba1.Text = "Prueba 1";
            btnPrueba1.UseVisualStyleBackColor = true;
            btnPrueba1.Click += btnPrueba1_Click;
            // 
            // btnPrueba2
            // 
            btnPrueba2.Location = new Point(549, 331);
            btnPrueba2.Name = "btnPrueba2";
            btnPrueba2.Size = new Size(144, 62);
            btnPrueba2.TabIndex = 3;
            btnPrueba2.Text = "Prueba 2";
            btnPrueba2.UseVisualStyleBackColor = true;
            btnPrueba2.Click += btnPrueba2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 586);
            Controls.Add(btnPrueba2);
            Controls.Add(btnPrueba1);
            Controls.Add(calCalendario);
            Controls.Add(dtpFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private MonthCalendar calCalendario;
        private Button btnPrueba1;
        private Button btnPrueba2;
    }
}
