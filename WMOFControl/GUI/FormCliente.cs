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

namespace WMOFControl.GUI
{
    public partial class FormCliente : Form
    {
        List<Cliente> lista;
        Cliente pesquisa;
        public FormCliente()
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
                item.SubItems.Add(lista.ElementAt(i).Email);
                item.SubItems.Add(lista.ElementAt(i).Cpf + lista.ElementAt(i).Cnpj); // juntar os dois em apenas uma coluna da tabela, pois nunca terá os dois;

            }

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            mostrarCliente();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddCliente open = new FormAddCliente();
            open.ShowDialog();
        }
    }
}
