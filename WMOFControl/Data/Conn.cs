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

namespace WMOFControl.Data
{

    class Conn
    {
        public MySqlConnection conexao;
        public DataSet conexaoDataSet;
        string script = "Server=179.188.16.150; Database=wmofdata; Uid=wmofdata; Pwd=lefera1209";
        public MySqlConnection conect()
        {
            {
                conexaoDataSet = new DataSet();
                conexao = new MySqlConnection(script);
                try
                {
                    conexao.Open();
                    return conexao;
                }

                catch (Exception e)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados" + e.Message);
                    conexao.Close();
                    return null;
                }
            }
        }
        public void teste()
        {
            var connection = new MySqlConnection(script);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO TABELA1 (CAMPO1) VALUES ('VALOR1')";
                command.ExecuteNonQuery();
                MessageBox.Show("teste OK");
            }
            catch
            {

            }
    } }
}
