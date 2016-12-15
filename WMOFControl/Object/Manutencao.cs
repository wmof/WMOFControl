using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMOFControl.Object
{
    class Manutencao
    {
        int codigo;
        string titulo;
        string descricao;
        string data;
        string hora;
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
