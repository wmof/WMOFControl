using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMOFControl.Object
{
    class Andamento
    {
        int codigo;
        string descricao;
        string data;
        string hora;
        Funcionario funcionario; //salvo apenas o codigo no Banco de dados
        Manutencao manutencao; //salvo apenas o codigo no Banco de dados

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        internal Funcionario Funcionario
        {
            get
            {
                return funcionario;
            }

            set
            {
                funcionario = value;
            }
        }

        internal Manutencao Manutencao
        {
            get
            {
                return manutencao;
            }

            set
            {
                manutencao = value;
            }
        }
    }
}
