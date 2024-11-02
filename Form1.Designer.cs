namespace Calculadora
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
            label1 = new Label();
            numero1TextBox = new TextBox();
            label2 = new Label();
            numero2TextBox = new TextBox();
            somarButton = new Button();
            SubtrairButton = new Button();
            multiplicarButton = new Button();
            DividirButton = new Button();
            label3 = new Label();
            respostaLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // numero1TextBox
            // 
            numero1TextBox.Location = new Point(99, 17);
            numero1TextBox.Name = "numero1TextBox";
            numero1TextBox.Size = new Size(125, 27);
            numero1TextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // numero2TextBox
            // 
            numero2TextBox.Location = new Point(99, 58);
            numero2TextBox.Name = "numero2TextBox";
            numero2TextBox.Size = new Size(125, 27);
            numero2TextBox.TabIndex = 3;
            // 
            // somarButton
            // 
            somarButton.Location = new Point(34, 112);
            somarButton.Name = "somarButton";
            somarButton.Size = new Size(94, 29);
            somarButton.TabIndex = 4;
            somarButton.Text = "Somar";
            somarButton.UseVisualStyleBackColor = true;
            somarButton.Click += somarButton_Click;
            // 
            // SubtrairButton
            // 
            SubtrairButton.Location = new Point(134, 112);
            SubtrairButton.Name = "SubtrairButton";
            SubtrairButton.Size = new Size(94, 29);
            SubtrairButton.TabIndex = 5;
            SubtrairButton.Text = "Subtrair";
            SubtrairButton.UseVisualStyleBackColor = true;
            SubtrairButton.Click += SubtrairButton_Click;
            // 
            // multiplicarButton
            // 
            multiplicarButton.Location = new Point(234, 112);
            multiplicarButton.Name = "multiplicarButton";
            multiplicarButton.Size = new Size(94, 29);
            multiplicarButton.TabIndex = 6;
            multiplicarButton.Text = "Multiplicar";
            multiplicarButton.UseVisualStyleBackColor = true;
            multiplicarButton.Click += multiplicarButton_Click;
            // 
            // DividirButton
            // 
            DividirButton.Location = new Point(334, 112);
            DividirButton.Name = "DividirButton";
            DividirButton.Size = new Size(94, 29);
            DividirButton.TabIndex = 7;
            DividirButton.Text = "Dividir";
            DividirButton.UseVisualStyleBackColor = true;
            DividirButton.Click += DividirButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 178);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Resposta";
            // 
            // respostaLabel
            // 
            respostaLabel.AutoSize = true;
            respostaLabel.Location = new Point(134, 178);
            respostaLabel.Name = "respostaLabel";
            respostaLabel.Size = new Size(17, 20);
            respostaLabel.TabIndex = 9;
            respostaLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 255);
            Controls.Add(respostaLabel);
            Controls.Add(label3);
            Controls.Add(DividirButton);
            Controls.Add(multiplicarButton);
            Controls.Add(SubtrairButton);
            Controls.Add(somarButton);
            Controls.Add(numero2TextBox);
            Controls.Add(label2);
            Controls.Add(numero1TextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numero1TextBox;
        private Label label2;
        private TextBox numero2TextBox;
        private Button somarButton;
        private Button SubtrairButton;
        private Button multiplicarButton;
        private Button DividirButton;
        private Label label3;
        private Label respostaLabel;
    }
}
