namespace Grados_c
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GradoFahrenheitLabel = new System.Windows.Forms.Label();
            this.GradoFahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.GradoCentigradoTextBox = new System.Windows.Forms.TextBox();
            this.GradoCentigradoLabel = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GradoFahrenheitLabel
            // 
            this.GradoFahrenheitLabel.AutoSize = true;
            this.GradoFahrenheitLabel.Location = new System.Drawing.Point(12, 75);
            this.GradoFahrenheitLabel.Name = "GradoFahrenheitLabel";
            this.GradoFahrenheitLabel.Size = new System.Drawing.Size(89, 13);
            this.GradoFahrenheitLabel.TabIndex = 9;
            this.GradoFahrenheitLabel.Text = "Grado Fahrenheit";
            // 
            // GradoFahrenheitTextBox
            // 
            this.GradoFahrenheitTextBox.Location = new System.Drawing.Point(15, 91);
            this.GradoFahrenheitTextBox.Name = "GradoFahrenheitTextBox";
            this.GradoFahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.GradoFahrenheitTextBox.TabIndex = 8;
            // 
            // GradoCentigradoTextBox
            // 
            this.GradoCentigradoTextBox.Location = new System.Drawing.Point(15, 37);
            this.GradoCentigradoTextBox.Name = "GradoCentigradoTextBox";
            this.GradoCentigradoTextBox.Size = new System.Drawing.Size(100, 20);
            this.GradoCentigradoTextBox.TabIndex = 7;
            // 
            // GradoCentigradoLabel
            // 
            this.GradoCentigradoLabel.AutoSize = true;
            this.GradoCentigradoLabel.Location = new System.Drawing.Point(12, 21);
            this.GradoCentigradoLabel.Name = "GradoCentigradoLabel";
            this.GradoCentigradoLabel.Size = new System.Drawing.Size(95, 13);
            this.GradoCentigradoLabel.TabIndex = 6;
            this.GradoCentigradoLabel.Text = "Grados Centigrado";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(26, 132);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 32);
            this.CalcularButton.TabIndex = 5;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 198);
            this.Controls.Add(this.GradoFahrenheitLabel);
            this.Controls.Add(this.GradoFahrenheitTextBox);
            this.Controls.Add(this.GradoCentigradoTextBox);
            this.Controls.Add(this.GradoCentigradoLabel);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GradoFahrenheitLabel;
        private System.Windows.Forms.TextBox GradoFahrenheitTextBox;
        private System.Windows.Forms.TextBox GradoCentigradoTextBox;
        private System.Windows.Forms.Label GradoCentigradoLabel;
        private System.Windows.Forms.Button CalcularButton;
    }
}

