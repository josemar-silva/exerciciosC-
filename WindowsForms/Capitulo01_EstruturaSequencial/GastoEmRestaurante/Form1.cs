using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
	

namespace GastoEmRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotalComDesconto.Text = (Convert.ToDouble(txtValorDaespesa.Text) * 1.10).ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
