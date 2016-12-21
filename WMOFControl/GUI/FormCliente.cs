﻿using System;
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
                item.SubItems.Add("("+lista.ElementAt(i).Telefone.Substring(0,2)+") " + lista.ElementAt(i).Telefone.Substring(2, 5)+"-"+ lista.ElementAt(i).Telefone.Substring(7, 4));
                item.SubItems.Add(lista.ElementAt(i).Email);
                if (lista.ElementAt(i).Tipo == "Fisica")
                {
                    item.SubItems.Add(lista.ElementAt(i).Cpf.Substring(0,3) + "." + lista.ElementAt(i).Cpf.Substring(3, 3)+"."+ lista.ElementAt(i).Cpf.Substring(6, 3)+ "-" + lista.ElementAt(i).Cpf.Substring(9, 2));
                }
                if (lista.ElementAt(i).Tipo == "Juridica")
                {
                    item.SubItems.Add(lista.ElementAt(i).Cnpj.Substring(0,2)+"."+ lista.ElementAt(i).Cnpj.Substring(2, 3)+"."+ lista.ElementAt(i).Cnpj.Substring(5, 3)+"/"+ lista.ElementAt(i).Cnpj.Substring(8, 4)+"-"+ lista.ElementAt(i).Cnpj.Substring(12, 2));
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
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            
            try
            {

                Cliente cliente = new Cliente();
                cliente.Codigo = lista.ElementAt(listView1.FocusedItem.Index).Codigo;
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
            btDelete.Text = "Deletar " + lista.ElementAt(listView1.FocusedItem.Index).Codigo;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
        }
    }
}