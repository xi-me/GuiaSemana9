namespace Ejercicio3
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
            panel1 = new Panel();
            btnAgregaryMostrar = new Button();
            txtNota4 = new TextBox();
            label7 = new Label();
            txtNota3 = new TextBox();
            label8 = new Label();
            txtNota2 = new TextBox();
            label6 = new Label();
            txtNota1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtEdad = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(btnAgregaryMostrar);
            panel1.Controls.Add(txtNota4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtNota3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtNota2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNota1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 537);
            panel1.TabIndex = 0;
            // 
            // btnAgregaryMostrar
            // 
            btnAgregaryMostrar.Location = new Point(194, 436);
            btnAgregaryMostrar.Name = "btnAgregaryMostrar";
            btnAgregaryMostrar.Size = new Size(296, 45);
            btnAgregaryMostrar.TabIndex = 14;
            btnAgregaryMostrar.Text = "Agregar Alumno y Mostrar Promedios";
            btnAgregaryMostrar.UseVisualStyleBackColor = true;
            btnAgregaryMostrar.Click += btnAgregaryMostrar_Click;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(498, 330);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(125, 27);
            txtNota4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(376, 333);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 12;
            label7.Text = "Nota 4 (25%):";
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(183, 330);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(125, 27);
            txtNota3.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 333);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 10;
            label8.Text = "Nota 3 (25%):";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(498, 271);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 274);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 8;
            label6.Text = "Nota 2 (25%):";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(183, 271);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 274);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 6;
            label5.Text = "Nota 1 (25%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 217);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 5;
            label4.Text = "Calificaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 142);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 142);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 61);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Registro de alumno";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(529, 139);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(94, 27);
            txtEdad.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private TextBox txtNota1;
        private Label label5;
        private TextBox txtNota4;
        private Label label7;
        private TextBox txtNota3;
        private Label label8;
        private TextBox txtNota2;
        private Label label6;
        private Button btnAgregaryMostrar;
        private TextBox txtEdad;
    }
}