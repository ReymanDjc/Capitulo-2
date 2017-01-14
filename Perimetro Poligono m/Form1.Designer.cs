namespace Perimetro_Poligono_m
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
            this.ResultadoPerimetrotextBox3 = new System.Windows.Forms.TextBox();
            this.LongitudPoligonotextBox2 = new System.Windows.Forms.TextBox();
            this.CantidadLadotextBox1 = new System.Windows.Forms.TextBox();
            this.ResultadPerimetroLbel3 = new System.Windows.Forms.Label();
            this.LongitudPoligonoLabel2 = new System.Windows.Forms.Label();
            this.CantidadLadoLabel1 = new System.Windows.Forms.Label();
            this.CalcularBotton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultadoPerimetrotextBox3
            // 
            this.ResultadoPerimetrotextBox3.Location = new System.Drawing.Point(89, 71);
            this.ResultadoPerimetrotextBox3.Name = "ResultadoPerimetrotextBox3";
            this.ResultadoPerimetrotextBox3.Size = new System.Drawing.Size(134, 20);
            this.ResultadoPerimetrotextBox3.TabIndex = 13;
            // 
            // LongitudPoligonotextBox2
            // 
            this.LongitudPoligonotextBox2.Location = new System.Drawing.Point(126, 113);
            this.LongitudPoligonotextBox2.Name = "LongitudPoligonotextBox2";
            this.LongitudPoligonotextBox2.Size = new System.Drawing.Size(100, 20);
            this.LongitudPoligonotextBox2.TabIndex = 12;
            // 
            // CantidadLadotextBox1
            // 
            this.CantidadLadotextBox1.Location = new System.Drawing.Point(110, 28);
            this.CantidadLadotextBox1.Name = "CantidadLadotextBox1";
            this.CantidadLadotextBox1.Size = new System.Drawing.Size(113, 20);
            this.CantidadLadotextBox1.TabIndex = 11;
            // 
            // ResultadPerimetroLbel3
            // 
            this.ResultadPerimetroLbel3.AutoSize = true;
            this.ResultadPerimetroLbel3.Location = new System.Drawing.Point(28, 78);
            this.ResultadPerimetroLbel3.Name = "ResultadPerimetroLbel3";
            this.ResultadPerimetroLbel3.Size = new System.Drawing.Size(55, 13);
            this.ResultadPerimetroLbel3.TabIndex = 10;
            this.ResultadPerimetroLbel3.Text = "Resultado";
            // 
            // LongitudPoligonoLabel2
            // 
            this.LongitudPoligonoLabel2.AutoSize = true;
            this.LongitudPoligonoLabel2.Location = new System.Drawing.Point(28, 120);
            this.LongitudPoligonoLabel2.Name = "LongitudPoligonoLabel2";
            this.LongitudPoligonoLabel2.Size = new System.Drawing.Size(92, 13);
            this.LongitudPoligonoLabel2.TabIndex = 9;
            this.LongitudPoligonoLabel2.Text = "Longitud Poligono";
            // 
            // CantidadLadoLabel1
            // 
            this.CantidadLadoLabel1.AutoSize = true;
            this.CantidadLadoLabel1.Location = new System.Drawing.Point(28, 35);
            this.CantidadLadoLabel1.Name = "CantidadLadoLabel1";
            this.CantidadLadoLabel1.Size = new System.Drawing.Size(76, 13);
            this.CantidadLadoLabel1.TabIndex = 8;
            this.CantidadLadoLabel1.Text = "Cantidad Lado";
            // 
            // CalcularBotton1
            // 
            this.CalcularBotton1.Location = new System.Drawing.Point(89, 155);
            this.CalcularBotton1.Name = "CalcularBotton1";
            this.CalcularBotton1.Size = new System.Drawing.Size(75, 38);
            this.CalcularBotton1.TabIndex = 7;
            this.CalcularBotton1.Text = "Calcula";
            this.CalcularBotton1.UseVisualStyleBackColor = true;
            this.CalcularBotton1.Click += new System.EventHandler(this.CalcularBotton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 214);
            this.Controls.Add(this.ResultadoPerimetrotextBox3);
            this.Controls.Add(this.LongitudPoligonotextBox2);
            this.Controls.Add(this.CantidadLadotextBox1);
            this.Controls.Add(this.ResultadPerimetroLbel3);
            this.Controls.Add(this.LongitudPoligonoLabel2);
            this.Controls.Add(this.CantidadLadoLabel1);
            this.Controls.Add(this.CalcularBotton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultadoPerimetrotextBox3;
        private System.Windows.Forms.TextBox LongitudPoligonotextBox2;
        private System.Windows.Forms.TextBox CantidadLadotextBox1;
        private System.Windows.Forms.Label ResultadPerimetroLbel3;
        private System.Windows.Forms.Label LongitudPoligonoLabel2;
        private System.Windows.Forms.Label CantidadLadoLabel1;
        private System.Windows.Forms.Button CalcularBotton1;
    }
}

