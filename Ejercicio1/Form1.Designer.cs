namespace Ejercicio1
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
            btnRectangulo = new Button();
            btnCirculo = new Button();
            panel1 = new Panel();
            title = new Label();
            panelRectangulo = new Panel();
            txtAltura = new TextBox();
            label2 = new Label();
            txtBase = new TextBox();
            label1 = new Label();
            panelCirculo = new Panel();
            txtRadio = new TextBox();
            label3 = new Label();
            btnCalcularArea = new Button();
            panel1.SuspendLayout();
            panelRectangulo.SuspendLayout();
            panelCirculo.SuspendLayout();
            SuspendLayout();
            // 
            // btnRectangulo
            // 
            btnRectangulo.Location = new Point(75, 83);
            btnRectangulo.Name = "btnRectangulo";
            btnRectangulo.Size = new Size(133, 37);
            btnRectangulo.TabIndex = 0;
            btnRectangulo.Text = "Rectángulo";
            btnRectangulo.UseVisualStyleBackColor = true;
            btnRectangulo.Click += btnRectangulo_Click;
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(309, 83);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(133, 37);
            btnCirculo.TabIndex = 1;
            btnCirculo.Text = "Círculo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(title);
            panel1.Controls.Add(btnCirculo);
            panel1.Controls.Add(btnRectangulo);
            panel1.Location = new Point(137, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 327);
            panel1.TabIndex = 2;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(112, 33);
            title.Name = "title";
            title.Size = new Size(279, 21);
            title.TabIndex = 2;
            title.Text = "Selecciona la figura que deseas:";
            // 
            // panelRectangulo
            // 
            panelRectangulo.Controls.Add(txtAltura);
            panelRectangulo.Controls.Add(label2);
            panelRectangulo.Controls.Add(txtBase);
            panelRectangulo.Controls.Add(label1);
            panelRectangulo.Location = new Point(137, 192);
            panelRectangulo.Name = "panelRectangulo";
            panelRectangulo.Size = new Size(255, 108);
            panelRectangulo.TabIndex = 3;
            panelRectangulo.Visible = false;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(112, 62);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Altura (cm):";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(110, 19);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Base (cm):";
            // 
            // panelCirculo
            // 
            panelCirculo.Controls.Add(txtRadio);
            panelCirculo.Controls.Add(label3);
            panelCirculo.Location = new Point(397, 192);
            panelCirculo.Name = "panelCirculo";
            panelCirculo.Size = new Size(255, 108);
            panelCirculo.TabIndex = 4;
            panelCirculo.Visible = false;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(114, 40);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 43);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Radio (cm):";
            // 
            // btnCalcularArea
            // 
            btnCalcularArea.Location = new Point(326, 325);
            btnCalcularArea.Name = "btnCalcularArea";
            btnCalcularArea.Size = new Size(133, 37);
            btnCalcularArea.TabIndex = 3;
            btnCalcularArea.Text = "Calcular área";
            btnCalcularArea.UseVisualStyleBackColor = true;
            btnCalcularArea.Visible = false;
            btnCalcularArea.Click += btnCalcularArea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcularArea);
            Controls.Add(panelCirculo);
            Controls.Add(panelRectangulo);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRectangulo.ResumeLayout(false);
            panelRectangulo.PerformLayout();
            panelCirculo.ResumeLayout(false);
            panelCirculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRectangulo;
        private Button btnCirculo;
        private Panel panel1;
        private Label title;
        private Panel panelRectangulo;
        private TextBox txtAltura;
        private Label label2;
        private TextBox txtBase;
        private Label label1;
        private Panel panelCirculo;
        private TextBox txtRadio;
        private Label label3;
        private Button btnCalcularArea;
    }
}