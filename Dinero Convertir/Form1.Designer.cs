namespace Dinero_Convertir
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.MonedaCovertidatextBox1 = new System.Windows.Forms.TextBox();
            this.TasaEurolabel = new System.Windows.Forms.Label();
            this.TasaEurotextBox1 = new System.Windows.Forms.TextBox();
            this.CantidadDolartextBox = new System.Windows.Forms.TextBox();
            this.CantidadMonedaslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Elegir Moneda";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dolares EUR",
            "Euros USD"});
            this.comboBox1.Location = new System.Drawing.Point(96, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Moneda Covertida";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(84, 153);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 36);
            this.CalcularButton.TabIndex = 14;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // MonedaCovertidatextBox1
            // 
            this.MonedaCovertidatextBox1.Location = new System.Drawing.Point(112, 105);
            this.MonedaCovertidatextBox1.Name = "MonedaCovertidatextBox1";
            this.MonedaCovertidatextBox1.Size = new System.Drawing.Size(162, 20);
            this.MonedaCovertidatextBox1.TabIndex = 13;
            // 
            // TasaEurolabel
            // 
            this.TasaEurolabel.AutoSize = true;
            this.TasaEurolabel.Location = new System.Drawing.Point(12, 76);
            this.TasaEurolabel.Name = "TasaEurolabel";
            this.TasaEurolabel.Size = new System.Drawing.Size(75, 13);
            this.TasaEurolabel.TabIndex = 12;
            this.TasaEurolabel.Text = "Tasa Del Euro";
            // 
            // TasaEurotextBox1
            // 
            this.TasaEurotextBox1.Location = new System.Drawing.Point(93, 69);
            this.TasaEurotextBox1.Name = "TasaEurotextBox1";
            this.TasaEurotextBox1.Size = new System.Drawing.Size(100, 20);
            this.TasaEurotextBox1.TabIndex = 11;
            // 
            // CantidadDolartextBox
            // 
            this.CantidadDolartextBox.Location = new System.Drawing.Point(109, 34);
            this.CantidadDolartextBox.Name = "CantidadDolartextBox";
            this.CantidadDolartextBox.Size = new System.Drawing.Size(87, 20);
            this.CantidadDolartextBox.TabIndex = 10;
            // 
            // CantidadMonedaslabel
            // 
            this.CantidadMonedaslabel.AutoSize = true;
            this.CantidadMonedaslabel.Location = new System.Drawing.Point(12, 41);
            this.CantidadMonedaslabel.Name = "CantidadMonedaslabel";
            this.CantidadMonedaslabel.Size = new System.Drawing.Size(91, 13);
            this.CantidadMonedaslabel.TabIndex = 9;
            this.CantidadMonedaslabel.Text = "Cantidad Moneda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.MonedaCovertidatextBox1);
            this.Controls.Add(this.TasaEurolabel);
            this.Controls.Add(this.TasaEurotextBox1);
            this.Controls.Add(this.CantidadDolartextBox);
            this.Controls.Add(this.CantidadMonedaslabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox MonedaCovertidatextBox1;
        private System.Windows.Forms.Label TasaEurolabel;
        private System.Windows.Forms.TextBox TasaEurotextBox1;
        private System.Windows.Forms.TextBox CantidadDolartextBox;
        private System.Windows.Forms.Label CantidadMonedaslabel;
    }
}

