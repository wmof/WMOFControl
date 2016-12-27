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
using WMOFControl.Validation;
using WMOFControl.Object;
namespace WMOFControl.GUI
{

    public partial class FormAddPagamento : Form
    {

        Pagamento pagamento = new Pagamento();
        BdPagamento bdPag = new BdPagamento();
        BdCliente bdCliente = new BdCliente();
        List<Cliente> listCliente = new List<Cliente>();
        Cliente cliente = new Cliente();
        public FormAddPagamento()
        {
            InitializeComponent();
        }
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
            textVencimento.Text = "";
            textRealizado.Text = "";
            maskedTextBox1.Text = "";
            textCodigo.Text = "";
            checkPago.Checked = false;


        }
        private void FormAddPagamento_Load(object sender, EventArgs e)
        {
            pagamento.Situacao = "Pendente";
            pagamento.Data_realizado = "";
            mostrarCliente();
        }
       

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                pagamento.Descricao = textDescricao.Text;
                pagamento.Codigo_barras = textCodigo.Text;
                pagamento.Data_realizado = textRealizado.Text;
                pagamento.Data_vencimento = textVencimento.Text;
                try
                {
                    pagamento.Valor = Convert.ToSingle(maskedTextBox1.Text.Replace("R$", "").Replace(",", "."));

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
                    pagamento.Cliente = cli;
                }
                catch
                {
                    MessageBox.Show("Selecione um cliente");
                }

                if (checkPago.Checked == true)
                {
                    pagamento.Data_realizado = textRealizado.Text;
                }
               
                ValidationPagamento valida = new ValidationPagamento();
                valida.ValidaInserePagamento(pagamento);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void checkPago_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPago.Checked == true)
            {
                pagamento.Situacao = "Pago";
                textRealizado.Enabled = true;
            }
            if (checkPago.Checked == false)
            {
                pagamento.Situacao = "Pendente";
                textRealizado.Enabled = false;
                textRealizado.Text = "";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
