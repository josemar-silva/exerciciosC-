using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class FrmTrocaDeValores : Form
    {
        public FrmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auxiliar = txtPrimeiroValor.Text;
            txtPrimeiroValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = auxiliar;
            MessageBox.Show("Troca de valores concluida!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
