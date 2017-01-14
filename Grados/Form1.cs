using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularBotton_Click(object sender, EventArgs e)
        {
            double Grados, Radianes;
            Grados = double.Parse(GradosTextBox.Text);
            Radianes = Grados * (3.14 / 180);

            RadianestextBox.Text = Radianes.ToString();
        }
    }
}
