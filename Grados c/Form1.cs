using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grados_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double GradosCentigrado, GradosFahrenhit, Resueltado;

            GradosCentigrado = double.Parse(GradoCentigradoTextBox.Text);

            GradosFahrenhit = GradosCentigrado * 5 / 9 + 32;
            Resueltado = GradosFahrenhit + 32;
            GradoFahrenheitTextBox.Text = Resueltado.ToString();

        }
    }
}
