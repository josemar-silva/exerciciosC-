using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascmento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE " + "NASCIMENTO com 4 digitos", "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtAnoNascmento.Focus();
            }

        }

private void txtUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUltimoAniversario.Text != String.Empty && Convert.ToInt32(txtUltimoAniversario.Text) <= Convert.ToInt32(txtAnoNascmento.Text))
            {
                MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO " + "deve ser superior ao do ANO DE NASCIMENTO.",
                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var idade = Convert.ToInt32(txtUltimoAniversario.Text) - Convert.ToInt32(txtAnoNascmento.Text);
            if (idade >=5 && idade <=7)
            {
                txtCategoria.Text = "Infantil A";
            }
            else if (idade <= 10)
            {
                txtCategoria.Text = "Infantil B";
            }
            else if (idade <= 13)
            {
                txtCategoria.Text = "juvenil A";
            }
            else if (idade <= 17)
            {
                txtCategoria.Text = "juvenil B";
            }
            else if (idade >= 18)
            {
                txtCategoria.Text = "Adulto";
            }
            else
            {
                txtCategoria.Text = "Não existe categoria";

            }
        }

    }

}
