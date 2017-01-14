using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dinero_Convertir
{

    public partial class Form1 : Form
    {
        float cantidadDolar;
        float tasaEuro;
        float monedaCovertida;
        public TransformarDolarEuros()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            cantidadDolar = float.Parse(CantidadDolartextBox.Text);
            tasaEuro = float.Parse(TasaEurotextBox1.Text);

            monedaCovertida = cantidadDolar * tasaEuro;
            MonedaCovertidatextBox1.Text = monedaCovertida.ToString();
        }
    }
}
