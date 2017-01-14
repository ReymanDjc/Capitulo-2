namespace Grados
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
            this.RadianestextBox = new System.Windows.Forms.TextBox();
            this.GradosTextBox = new System.Windows.Forms.TextBox();
            this.RadianesLabel = new System.Windows.Forms.Label();
            this.GradoLabel = new System.Windows.Forms.Label();
            this.CalcularBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadianestextBox
            // 
            this.RadianestextBox.Location = new System.Drawing.Point(199, 16);
            this.RadianestextBox.Name = "RadianestextBox";
            this.RadianestextBox.Size = new System.Drawing.Size(96, 20);
            this.RadianestextBox.TabIndex = 9;
            // 
            // GradosTextBox
            // 
            this.GradosTextBox.Location = new System.Drawing.Point(59, 18);
            this.GradosTextBox.Name = "GradosTextBox";
            this.GradosTextBox.Size = new System.Drawing.Size(76, 20);
            this.GradosTextBox.TabIndex = 8;
            // 
            // RadianesLabel
            // 
            this.RadianesLabel.AutoSize = true;
            this.RadianesLabel.Location = new System.Drawing.Point(141, 21);
            this.RadianesLabel.Name = "RadianesLabel";
            this.RadianesLabel.Size = new System.Drawing.Size(52, 13);
            this.RadianesLabel.TabIndex = 7;
            this.RadianesLabel.Text = "Radianes";
            // 
            // GradoLabel
            // 
            this.GradoLabel.AutoSize = true;
            this.GradoLabel.Location = new System.Drawing.Point(12, 23);
            this.GradoLabel.Name = "GradoLabel";
            this.GradoLabel.Size = new System.Drawing.Size(41, 13);
            this.GradoLabel.TabIndex = 6;
            this.GradoLabel.Text = "Grados";
            // 
            // CalcularBotton
            // 
            this.CalcularBotton.Location = new System.Drawing.Point(118, 59);
            this.CalcularBotton.Name = "CalcularBotton";
            this.CalcularBotton.Size = new System.Drawing.Size(75, 35);
            this.CalcularBotton.TabIndex = 5;
            this.CalcularBotton.Text = "Calcular";
            this.CalcularBotton.UseVisualStyleBackColor = true;
            this.CalcularBotton.Click += new System.EventHandler(this.CalcularBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 113);
            this.Controls.Add(this.RadianestextBox);
            this.Controls.Add(this.GradosTextBox);
            this.Controls.Add(this.RadianesLabel);
            this.Controls.Add(this.GradoLabel);
            this.Controls.Add(this.CalcularBotton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RadianestextBox;
        private System.Windows.Forms.TextBox GradosTextBox;
        private System.Windows.Forms.Label RadianesLabel;
        private System.Windows.Forms.Label GradoLabel;
        private System.Windows.Forms.Button CalcularBotton;
    }
}

