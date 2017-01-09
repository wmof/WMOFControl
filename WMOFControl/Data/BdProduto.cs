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
    class BdProduto
    {
        Conn bd = new Conn();
        DataSet dataset = new DataSet();
        public List<Produto> selectProduto(Produto pesquisa)
        {
            List<Produto> listProduto = new List<Produto>();
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "SELECT * FROM produto WHERE codigo = codigo";
                if (pesquisa != null)
                {

                    if (pesquisa.Data_entrega.Trim() != "")
                    {
                        sql = sql + " AND data_entrega = LIKE '" + pesquisa.Data_entrega + "'";
                    }
                    if (pesquisa.Data_solicitacao.Trim() != "")
                    {
                        sql = sql + " AND data_solicitacao = LIKE '" + pesquisa.Data_solicitacao + "'";
                    }
                    if (pesquisa.Situacao.Trim() != "")
                    {
                        sql = sql + " AND situacao = LIKE '" + pesquisa.Situacao + "'";
                    }
                    if (pesquisa.Cliente != null)
                    {
                        sql = sql + " AND cliente_codigo = " + pesquisa.Cliente.Codigo;
                    }
                }
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);

                foreach (DataRow linha in dataset.Tables[0].Rows)
                {
                    Produto produto = new Produto();

                    produto.Codigo = Convert.ToInt32(linha["codigo"]);
                    produto.Descricao = Convert.ToString(linha["descricao"]);
                    produto.Valor = Convert.ToSingle(linha["valor"]);
                    produto.Titulo = Convert.ToString(linha["titulo"]);
                    produto.Data_solicitacao = Convert.ToString(linha["data_solicitacao"]);
                    produto.Data_entrega = Convert.ToString(linha["data_entregue"]);
                    produto.Situacao = Convert.ToString(linha["situacao"]);
                    Cliente cli = new Cliente();
                    cli.Codigo = Convert.ToInt32(linha["cliente_codigo"]);
                    produto.Cliente = cli;

                    listProduto.Add(produto);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listProduto;
        }

        public void insertProduto(Produto produto)
        {
            try
            {
                string valor = Convert.ToString(produto.Valor).Replace(",", ".");
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "INSERT INTO produto (descricao, valor, data_solicitacao, data_entregue, situacao, cliente_codigo, titulo)"
                + " VALUES ('" + produto.Descricao + "', '" + valor + "', '" + produto.Data_solicitacao + "','" + produto.Data_entrega + "','" + produto.Situacao + "','" + produto.Cliente.Codigo + "','" + produto.Titulo + "')";
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());

                adapter.Fill(dataset);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteProduto(Produto produto)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "DELETE FROM produto WHERE codigo = " + produto.Codigo;
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateEntregue(Produto produto)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "UPDATE produto SET situacao = 'Entregue', data_entregue = '" + DateTime.Now.ToShortDateString() + "' WHERE codigo = " + produto.Codigo;
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
