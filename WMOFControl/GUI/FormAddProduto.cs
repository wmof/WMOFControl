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
using WMOFControl.Validation;

namespace WMOFControl.GUI
{
    public partial class FormAddProduto : Form
    {
        public FormAddProduto()
        {
            InitializeComponent();
        }
        Produto produto = new Produto();
        BdProduto bdProd = new BdProduto();
        BdCliente bdCliente = new BdCliente();
        List<Cliente> listCliente = new List<Cliente>();
        Cliente cliente = new Cliente();
        public void mostrarCliente()
        {
            cliente = null;
            listCliente = bdCliente.selectCliente(cliente);
            comboCliente.Items.Clear();
            for (int i = 0; i < listCliente.Count; i++)
            {
                comboCliente.Items.Add(listCliente.ElementAt(i).Nome);
            }
        }
        public void limpar()
        {
            textDescricao.Text = "";
            textSolicitado.Text = "";
            textEntrega.Text = "";
            maskedTextBox1.Text = "";
            textTitulo.Text = "";
            checkEntregue.Checked = false;


        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                produto.Descricao = textDescricao.Text;
                produto.Titulo = textTitulo.Text;
                produto.Data_entrega = textEntrega.Text;
                produto.Data_solicitacao = textSolicitado.Text;
                try
                {
                    produto.Valor = Convert.ToSingle(maskedTextBox1.Text.Replace("R$", "").Replace(",", "."));

                }
                catch
                {
                    MessageBox.Show("Informe um valor");
                    return;
                }
                try
                {
                    Cliente cli = new Cliente();
                    cli.Codigo = listCliente.ElementAt(comboCliente.SelectedIndex).Codigo;
                    produto.Cliente = cli;
                }
                catch
                {
                    MessageBox.Show("Selecione um cliente");
                }

                if (checkEntregue.Checked == true)
                {
                    produto.Data_entrega = textEntrega.Text;
                }

                ValidationProduto valida = new ValidationProduto();
                valida.ValidaInsereProduto(produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddProduto_Load(object sender, EventArgs e)
        {
            produto.Situacao = "Pendente";
            produto.Data_entrega = "";
            mostrarCliente();

        }

        private void checkPago_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEntregue.Checked == true)
            {
                produto.Situacao = "Entregue";
                textEntrega.Enabled = true;
            }
            if (checkEntregue.Checked == false)
            {
                produto.Situacao = "Pendente";
                textEntrega.Enabled = false;
                textEntrega.Text = "";
            }
        }
    }
}
