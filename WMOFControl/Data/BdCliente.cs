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
        Conn bdbb = new Conn();
        MySqlConnection bd = new MySqlConnection();
        public List<Cliente> selectCliente()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand("SELECT * FROM cliente ORDER BY codigo;", bdbb.conect());

                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                foreach (DataRow linha in dataset.Tables[0].Rows)
                {
                    Cliente cc = new Cliente();

                    cc.Codigo = Convert.ToInt32(linha["codigo"]);
                    cc.Nome = Convert.ToString(linha["nome"]);
                    cc.Telefone = Convert.ToString(linha["telefone"]);
                    clientes.Add(cc);
                }
                return clientes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
