using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMOFControl.Object
{
    class Pagamento
    {
        int codigo;
        string descricao;
        float valor;
        string codigo_barras;
        string data_vencimento;
        string data_realizado;
        string situacao;
        Cliente cliente; //salvo apenas o codigo no Banco de dados

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

        public float Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string Codigo_barras
        {
            get
            {
                return codigo_barras;
            }

            set
            {
                codigo_barras = value;
            }
        }

        public string Data_vencimento
        {
            get
            {
                return data_vencimento;
            }

            set
            {
                data_vencimento = value;
            }
        }

        public string Data_realizado
        {
            get
            {
                return data_realizado;
            }

            set
            {
                data_realizado = value;
            }
        }

        public string Situacao
        {
            get
            {
                return situacao;
            }

            set
            {
                situacao = value;
            }
        }

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }
    }
}
