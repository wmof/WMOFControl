using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMOFControl.GUI;

namespace WMOFControl.GUI
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente abrir = new FormCliente();
            abrir.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddCliente abrir = new FormAddCliente();
            abrir.ShowDialog();
        }
    }
}
