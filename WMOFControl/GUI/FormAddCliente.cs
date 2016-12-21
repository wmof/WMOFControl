using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMOFControl.Object;
using WMOFControl.Data;
using WMOFControl.Validation;

namespace WMOFControl.GUI
{
    public partial class FormAddCliente : Form
    {
        public FormAddCliente()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            textNome.Text = "";
            textTelefone.Text = "";
            textEmail.Text = "";
            textCnpj.Text = "";
            textCpf.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textNome.Text;
                cliente.Telefone = textTelefone.Text;
                cliente.Email = textEmail.Text;
                cliente.Tipo = comboTipo.Text;
                cliente.Cpf = textCpf.Text;
                cliente.Cnpj = textCnpj.Text;
                ValidationCliente valida = new ValidationCliente();
                valida.validaInsertCliente(cliente);
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t \t Erro \n \n " + ex.Message);
            }            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboTipo.Text == "Juridica")
            {
                textCnpj.Enabled = true;
                textCpf.Enabled = false;
                textCpf.Text = "";
            }
            else
            {
                textCnpj.Enabled = false;
                textCpf.Enabled = true;
                textCnpj.Text = "";
            }
            if (comboTipo.Text == "")
            {
                textCnpj.Enabled = false;
                textCpf.Enabled = false;
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboTipo_CursorChanged(object sender, EventArgs e)
        {
           
        }

        private void comboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboTipo.Text = "";
        }
    }
}
