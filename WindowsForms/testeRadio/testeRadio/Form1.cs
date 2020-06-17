using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeRadio
{
    public partial class Form1 : Form
    {

        public Form1()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Mensagem();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Mensagem();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Mensagem();
        }
        private void Mensagem()
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Homem");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Mulher");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Sexo não Informado!");
            }
            else
            {
                MessageBox.Show("Favor selecionar uma das opções!");
            }
        }
    }
}
