using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, resultado;
            num1 = Convert.ToDouble(txtNota1.Text);
            num2 = Convert.ToDouble(txtNota2.Text);
            num3 = Convert.ToDouble(txtNota3.Text);
            resultado = (num1 + num2 + num3) / 3 ;
            txtResultado.Text = resultado.ToString("0.00");

            if (resultado < 5)
                MessageBox.Show("Aluno está reprovado.");
            else if (resultado >= 7)
                MessageBox.Show("Aluno está aprovado.");
            else
                MessageBox.Show("Aluno está de recuperação.");
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
