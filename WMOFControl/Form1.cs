using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMOFControl.Data;
using WMOFControl.Object;

namespace WMOFControl
{
    public partial class Form1 : Form
    {
        List<Cliente> lista;
        Cliente pesquisa;
        public Form1()
        {
            InitializeComponent();
            pesquisa = null;
        }
        
        private void mostrarCliente()
        {
            BdCliente mostrar = new BdCliente();
            
            lista = mostrar.selectCliente(pesquisa);
            if (lista.Count() == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado");
                return;
            }
            listView1.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                ListViewItem item = listView1.Items.Add(Convert.ToString(lista.ElementAt(i).Codigo));
                item.SubItems.Add(lista.ElementAt(i).Nome);
                item.SubItems.Add(lista.ElementAt(i).Telefone);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conn c = new Conn();
            //c.teste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarCliente();
        }
    }
}
