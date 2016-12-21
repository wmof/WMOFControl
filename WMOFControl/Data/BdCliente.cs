using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using WMOFControl.Object;

namespace WMOFControl.Data
{
    class BdCliente
    {
        Conn bd = new Conn();
        DataSet dataset = new DataSet();
        public List<Cliente> selectCliente(Cliente pesquisa)
        {
            List<Cliente> listCliente = new List<Cliente>();
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "SELECT * FROM cliente ORDER BY nome";
                if (pesquisa != null)
                {
                    sql = sql + "WHERE 1 = 1";
                    if (pesquisa.Nome != "")
                    {
                        sql = sql = "AND WHERE nome = LIKE '%" + pesquisa.Nome + "'%";
                    }
                    if (pesquisa.Cpf != "")
                    {
                        sql = sql = "AND WHERE cpf = LIKE '%" + pesquisa.Cpf + "'%";
                    }
                    if (pesquisa.Cnpj != "")
                    {
                        sql = sql = "AND WHERE cnpj = LIKE '%" + pesquisa.Cnpj + "'%";
                    }
                    if (pesquisa.Tipo != "")
                    {
                        sql = sql = "AND WHERE tipo = '" + pesquisa.Tipo + "'";
                    }
                }
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);

                foreach (DataRow linha in dataset.Tables[0].Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.Codigo = Convert.ToInt32(linha["codigo"]);
                    cliente.Nome = Convert.ToString(linha["nome"]);
                    cliente.Telefone = Convert.ToString(linha["telefone"]);
                    cliente.Email = Convert.ToString(linha["email"]);
                    cliente.Tipo = Convert.ToString(linha["tipo"]);
                    /*if (cliente.Tipo == "Fisica")
                    {
                        cliente.Cpf = Convert.ToString(linha["cpf"]);
                    }
                    if (cliente.Tipo == "Juridica")
                    {
                        cliente.Cnpj = Convert.ToString(linha["cnpj"]);
                    }*/
                    cliente.Cpf = Convert.ToString(linha["cpf"]);
                    cliente.Cnpj = Convert.ToString(linha["cnpj"]);
                    cliente.Senha = Convert.ToString(linha["senha"]);

                    listCliente.Add(cliente);
                }
            }
                    
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listCliente;
        }
        public void insertCliente(Cliente cliente)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "";
                if (cliente.Tipo == "Fisica")
                {
                    sql = "INSERT INTO  cliente (nome, telefone, email, cpf, tipo)"
                + "VALUES ('" + cliente.Nome + "', '" + cliente.Telefone + "', '" + cliente.Email + "','" + cliente.Cpf + "','" + cliente.Tipo + "')";
                }
                if (cliente.Tipo == "Juridica")
                {
                    sql = "INSERT INTO  cliente (nome, telefone, email, cnpj, tipo)"
                + "VALUES ('" + cliente.Nome + "', '" + cliente.Telefone + "', '" + cliente.Email + "','" + cliente.Cnpj + "','" + cliente.Tipo + "')";
                }
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                
                adapter.Fill(dataset);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteCliente(Cliente cliente)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "DELETE FROM cliente WHERE codigo = " + cliente.Codigo;
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateCliente(Cliente cliente)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "UPDATE cliente SET nome = '" + cliente.Nome + "', telefone = '" + cliente.Telefone + "', email = '" + cliente.Email + "' WHERE codigo = " + cliente.Codigo;
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateSenha(Cliente cliente)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "UPDATE senha SET = '" + cliente.Senha + "' WHERE codigo = " + cliente.Codigo;
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
