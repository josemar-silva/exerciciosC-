using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            lblDataAtual.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }


        private void btnCalcularCategoria_Click(object sender, EventArgs e)
        {
           

            TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataDeNascimento.Value;  // calcaular idade
            int idade = (tsQuantidadeDias.Days / 365);

            var nome = txtNome.Text;
           
            if (idade >= 5 && idade <= 7)
            {
                txtCategoriaAplicada.Text = "Infantil A";
            }
            else if (idade <= 10)
            {
                txtCategoriaAplicada.Text = "Infantil B";
            }
            else if (idade <= 13)
            {
                txtCategoriaAplicada.Text = "juvenil A";
            }
            else if (idade <= 17)
            {
                txtCategoriaAplicada.Text = "juvenil B";
            }
            else if (idade >= 18)
            {
                txtCategoriaAplicada.Text = "Adulto";
            }
            else
            {
                txtCategoriaAplicada.Text = "Não existe categoria";

            }
        }
    }
}
