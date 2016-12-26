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
    class BdPagamento
    {
        Conn bd = new Conn();
        DataSet dataset = new DataSet();
        public List<Pagamento> selectPagamento(Pagamento pesquisa)
        {
            List<Pagamento> listPagamento = new List<Pagamento>();
            try
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "SELECT * FROM pagamento WHERE codigo = codigo";
                if (pesquisa != null)
                {
                    
                    if (pesquisa.Data_realizado.Trim() != "")
                    {
                        sql = sql + " AND data_realizado = LIKE '" + pesquisa.Data_realizado + "'";
                    }
                    if (pesquisa.Data_vencimento.Trim() != "")
                    {
                        sql = sql + " AND data_vencimento = LIKE '" + pesquisa.Data_vencimento + "'";
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
                    Pagamento pagamento = new Pagamento();

                    pagamento.Codigo = Convert.ToInt32(linha["codigo"]);
                    pagamento.Descricao = Convert.ToString(linha["descricao"]);
                    pagamento.Valor = Convert.ToSingle(linha["valor"]);
                    pagamento.Codigo_barras = Convert.ToString(linha["codigo_barras"]);
                    pagamento.Data_realizado = Convert.ToString(linha["data_realizado"]);
                    pagamento.Data_vencimento = Convert.ToString(linha["data_vencimento"]);
                    pagamento.Situacao = Convert.ToString(linha["situacao"]);
                    Cliente cli = new Cliente();
                    cli.Codigo = Convert.ToInt32(linha["cliente_codigo"]);
                    pagamento.Cliente = cli;

                    listPagamento.Add(pagamento);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return listPagamento;
        }
        public void insertPagamento(Pagamento pagamento)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "INSERT INTO pagamento (descricao, valor, data_vencimento, data_realizado, situacao, cliente_codigo, codigo_barras)"
                + " VALUES ('" + pagamento.Descricao + "', '" + pagamento.Valor + "', '" + pagamento.Data_vencimento + "','" + pagamento.Data_realizado + "','" + pagamento.Situacao + "','" + pagamento.Cliente.Codigo + "','" + pagamento.Codigo_barras + "')";

                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());

                adapter.Fill(dataset);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deletePagamento(Pagamento pagamento)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "DELETE FROM pagamento WHERE codigo = " + pagamento.Codigo;
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updatePagamento(Pagamento pagamento)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "UPDATE pagamento SET descricao = '" + pagamento.Descricao + "', valor = '" + pagamento.Valor + "', data_vencimento = '" + pagamento.Data_vencimento + "', data_realizado = '" + pagamento.Data_realizado + "', situacao = '" + pagamento.Situacao + "' WHERE codigo = " + pagamento.Codigo;
                adapter.SelectCommand = new MySqlCommand(sql, bd.conect());
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updatePago(Pagamento pagamento)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "UPDATE pagamento SET situacao = 'Pago', data_realizado = '" + pagamento.Data_realizado + "' WHERE codigo = " + pagamento.Codigo;
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
