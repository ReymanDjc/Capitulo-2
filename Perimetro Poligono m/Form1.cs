using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perimetro_Poligono_m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularBotton1_Click(object sender, EventArgs e)
        {
            int cantidadLado, longitudPoligono, resultadoPerimetro;

            cantidadLado = int.Parse(CantidadLadotextBox1.Text);
            longitudPoligono = int.Parse(LongitudPoligonotextBox2.Text);

            resultadoPerimetro = cantidadLado * longitudPoligono;

            ResultadoPerimetrotextBox3.Text = resultadoPerimetro.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
