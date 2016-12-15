using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMOFControl.Object
{
    class Funcionario
    {
        int codigo;
        string nome;
        string cpf;
        string telefone;
        string email;
        string data_contratacao;
        Funcionario supervisor; //salvo apenas o codigo no Banco de dados

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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Data_contratacao
        {
            get
            {
                return data_contratacao;
            }

            set
            {
                data_contratacao = value;
            }
        }

        internal Funcionario Supervisor
        {
            get
            {
                return supervisor;
            }

            set
            {
                supervisor = value;
            }
        }
    }
}
