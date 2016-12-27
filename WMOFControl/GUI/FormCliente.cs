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
        List<Cliente> listCliente;
        List<Pagamento> listPagamento = new List<Pagamento>();
        Cliente pesquisa;
        public FormCliente()
        {
            InitializeComponent();
            pesquisa = null;
        }
        public void mostrarPagamento()
        {

            BdPagamento bdPag = new BdPagamento();
            Pagamento pag = new Pagamento();
            Cliente cc = new Cliente();
            cc.Codigo = listCliente.ElementAt(listViewCliente.FocusedItem.Index).Codigo;

            pag.Cliente = cc;
            pag.Situacao = "";
            pag.Data_realizado = "";
            pag.Data_vencimento = "";

            listPagamento = bdPag.selectPagamento(pag);

            listViewPagamentos.Items.Clear();
            for (int i = 0; i < listPagamento.Count; i++)
            {
                ListViewItem item = listViewPagamentos.Items.Add(listPagamento.ElementAt(i).Data_vencimento);
                item.SubItems.Add(listPagamento.ElementAt(i).Data_realizado);
                item.SubItems.Add(Convert.ToString(listPagamento.ElementAt(i).Valor));
                item.SubItems.Add(listPagamento.ElementAt(i).Situacao);
            }
        }
        private void mostrarCliente()
        {
            BdCliente mostrar = new BdCliente();

            listCliente = mostrar.selectCliente(pesquisa);
            if (listCliente.Count() == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado");
                return;
            }
            listViewCliente.Items.Clear();
            for (int i = 0; i < listCliente.Count; i++)
            {
                ListViewItem item = listViewCliente.Items.Add(Convert.ToString(listCliente.ElementAt(i).Codigo));
                item.SubItems.Add(listCliente.ElementAt(i).Nome);
                item.SubItems.Add("(" + listCliente.ElementAt(i).Telefone.Substring(0, 2) + ") " + listCliente.ElementAt(i).Telefone.Substring(2, 5) + "-" + listCliente.ElementAt(i).Telefone.Substring(7, 4));
                item.SubItems.Add(listCliente.ElementAt(i).Email);
                if (listCliente.ElementAt(i).Tipo == "Fisica")
                {//Carrega CPF apenas com mascara
                    item.SubItems.Add(listCliente.ElementAt(i).Cpf.Substring(0, 3) + "." + listCliente.ElementAt(i).Cpf.Substring(3, 3) + "." + listCliente.ElementAt(i).Cpf.Substring(6, 3) + "-" + listCliente.ElementAt(i).Cpf.Substring(9, 2));
                }
                if (listCliente.ElementAt(i).Tipo == "Juridica")
                {//Carrega CNPJ apenas com mascara
                    item.SubItems.Add(listCliente.ElementAt(i).Cnpj.Substring(0, 2) + "." + listCliente.ElementAt(i).Cnpj.Substring(2, 3) + "." + listCliente.ElementAt(i).Cnpj.Substring(5, 3) + "/" + listCliente.ElementAt(i).Cnpj.Substring(8, 4) + "-" + listCliente.ElementAt(i).Cnpj.Substring(12, 2));
                }

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
            mostrarCliente();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            try
            {

                Cliente cliente = new Cliente();
                cliente.Codigo = listCliente.ElementAt(listViewCliente.FocusedItem.Index).Codigo;
                BdCliente open = new BdCliente();
                open.deleteCliente(cliente);
                MessageBox.Show("Cliente deletado com sucesso");
                btDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            btDelete.Enabled = true;
            btDelete.Text = "Deletar " + listCliente.ElementAt(listViewCliente.FocusedItem.Index).Codigo;
            mostrarPagamento();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void btPgCadastrar_Click(object sender, EventArgs e)
        {
            FormAddPagamento abrir = new FormAddPagamento();
            abrir.ShowDialog();
            mostrarPagamento();
        }

        private void btPgDelete_Click(object sender, EventArgs e)
        {
            try
            {

                Pagamento pagamento = new Pagamento();
                pagamento.Codigo = listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Codigo;
                BdPagamento open = new BdPagamento();
                open.deletePagamento(pagamento);
                MessageBox.Show("Pagamento deletado com sucesso");
                btPgDelete.Enabled = false;
                mostrarPagamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btPgDetalhes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pagamento: " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Codigo
            + "\n Referente a: " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Descricao
            + "\n Codigo de Barras: " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Codigo_barras
            + "\n Valor: " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Valor
            + "\n Data de Vencimento: " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Data_vencimento
            + "\n Data que foi Pago: " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Data_realizado
            + "\n Situação:  " + listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Situacao
            + "\n Cliente: " + listCliente.ElementAt(listViewCliente.FocusedItem.Index).Nome);
        }

        private void listViewPagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btPgDelete.Enabled = true;
            btPgDetalhes.Enabled = true;
            if (listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Situacao == "Pendente")
            {
                btPg.Enabled = true;

            }
            else
            {
                btPg.Enabled = false;
            }
        }

        private void btPg_Click(object sender, EventArgs e)
        {
            BdPagamento bdpag = new BdPagamento();
            Pagamento pag = new Pagamento();
            pag.Codigo = listPagamento.ElementAt(listViewPagamentos.FocusedItem.Index).Codigo;
            bdpag.updatePago(pag);
            MessageBox.Show("Pagamento Efetuado");
            mostrarPagamento();
            btPg.Enabled = false;


        }
    }
}
