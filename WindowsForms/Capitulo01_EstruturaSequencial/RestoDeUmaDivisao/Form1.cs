using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDeUmaDivisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRealizarDivisao_Click(object sender, EventArgs e)
        {
            var dividendo = Convert.ToInt32(txtDividendo.Text);
            var divisor = Convert.ToInt32(txtDivisor.Text);
            var resto = dividendo % divisor;
            txtRestoDaDivisao.Text = resto.ToString();
        }
    }
}
