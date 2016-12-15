using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMOFControl.Object
{
    class Produto
    {
        int codigo;
        string titulo;
        string descricao;
        float valor;
        string data_solicitacao;
        string situacao;
        string data_entrega;
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

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
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

        public string Data_solicitacao
        {
            get
            {
                return data_solicitacao;
            }

            set
            {
                data_solicitacao = value;
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

        public string Data_entrega
        {
            get
            {
                return data_entrega;
            }

            set
            {
                data_entrega = value;
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
