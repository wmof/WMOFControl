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
        public void validaInsertCliente(Cliente cliente)
        {
            string erro = "";
            MessageBox.Show(cliente.Cpf);
            cliente.Cnpj = cliente.Cnpj.Replace("/", "").Replace(".", "").Replace("-","").Trim().Replace(" ", "");
            cliente.Cpf = cliente.Cpf.Replace("-", "").Replace(",", "").Replace(" ", "");
            cliente.Telefone = cliente.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Replace(" ","");
            //Fazer validação de CPF e CNPJ repetido

            if (cliente.Cpf.Count() != 11 && cliente.Tipo == "Fisica")
            {
                erro = erro + "\n Informe um CPF valido :: " + cliente.Cpf;
            }

            if (cliente.Cnpj.Count() != 13 && cliente.Tipo == "Juridica")
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
            if (cliente.Tipo == "")
            {
                erro = erro + "\n Informe o Tipo do Cliente :: " +cliente.Tipo;
            }
            if (cliente.Email.Contains("@") == false && cliente.Email.Contains(".") == false)
            {
                erro = erro + "\n Informe um Email valido :: " + cliente.Email;
            }

            if (erro != "") 
            {
                MessageBox.Show(erro);
            }
        }

    }
}
