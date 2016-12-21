using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMOFControl.Object;
using WMOFControl.Data;
using WMOFControl.GUI;
using System.Windows.Forms;

namespace WMOFControl.Validation
{
    class ValidationCliente
    {
        Cliente pesquisa = new Cliente();
        List<Cliente> lista = new List<Cliente>();
        BdCliente bd = new BdCliente();
        
        public void validaInsertCliente(Cliente cliente)
        {
            pesquisa = null;
            lista = bd.selectCliente(pesquisa);
            string erro = "";
            cliente.Cnpj = cliente.Cnpj.Replace("/", "").Replace(",", "").Replace("-","").Trim().Replace(" ", "");
            cliente.Cpf = cliente.Cpf.Replace("-", "").Replace(",", "").Replace(" ", "");
            cliente.Telefone = cliente.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Replace(" ","");
            //Fazer validação de CPF e CNPJ repetido
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista.ElementAt(i).Cpf == cliente.Cpf && cliente.Cpf != "")
                {
                    erro = erro + "\n  CPF ja registrado";
                }
                if (lista.ElementAt(i).Cnpj == cliente.Cnpj && cliente.Cnpj != "")
                {
                    erro = erro + "\n  CNPJ ja registrado";
                }
            }

            if (cliente.Cpf.Count() != 11 && cliente.Tipo == "Fisica")
            {
                erro = erro + "\n Informe um CPF valido :: " + cliente.Cpf;
            }

            if (cliente.Cnpj.Count() != 14 && cliente.Tipo == "Juridica")
            {
                erro = erro + "\n Informe um CNPJ valido :: "+cliente.Cnpj;
            }
            if (cliente.Telefone.Count() != 11)
            {
                erro = erro + "\n Informe um Telefone valido :: " + cliente.Telefone;
            }
           
            if (cliente.Nome.Where(c => char.IsNumber(c)).Count() > 0 || cliente.Nome.Count() < 4)
            {
                erro = erro + "\n Informe um Nome valido :: " + cliente.Nome;
            }
            if (cliente.Tipo.Count() < 2)
            {
                erro = erro + "\n Informe o Tipo do Cliente :: " +cliente.Tipo;
            }
            if (cliente.Email.Contains("@") == false && cliente.Email.Contains(".") == false)
            {
                erro = erro + "\n Informe um Email valido :: " + cliente.Email;
            }

            if (erro != "") 
            {
                throw new Exception(erro);
            }
            if (erro == "")
            {
                MessageBox.Show("Cliente adicionado com Sucesso!!!");
                BdCliente bd = new BdCliente();
                bd.insertCliente(cliente);
            }
        }

    }
}
