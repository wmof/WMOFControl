using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMOFControl.Data;
using WMOFControl.Object;
using WMOFControl.GUI;
using System.Windows.Forms;

namespace WMOFControl.Validation
{
    class ValidationPagamento
    {
        public void ValidaInserePagamento(Pagamento pagamento)
        {
            string erro = "";

            if (pagamento.Descricao.Trim() == "")
            {
                erro = erro + "\n Informe a descrição do pagamento";
            }
            if (pagamento.Data_vencimento.Trim().Replace("/","") == "" || pagamento.Data_vencimento.Trim().Replace("/","").Count() != 8)
            {
                erro = erro + "\n Informe uma data de vencimento valida";
            }

            
            
            if (pagamento.Data_realizado.Trim().Replace("/", "") == "" && pagamento.Data_realizado.Trim().Replace("/", "").Count() != 8 && pagamento.Data_realizado.Trim().Replace("/", "").Count() != 0)
            {
                erro = erro + "\n Informe uma data de pagamento valida";
            }
            if (pagamento.Data_realizado.Trim().Replace("/", "").Replace(" ","") == "")
            {
                pagamento.Data_realizado = pagamento.Data_realizado.Trim().Replace("/", "");
            }
            pagamento.Valor = Convert.ToSingle(Convert.ToString(pagamento.Valor).Substring(0, Convert.ToString(pagamento.Valor).Count()-2) + "," + Convert.ToString(pagamento.Valor).Substring(Convert.ToString(pagamento.Valor).Count() - 2, 2));
            if (erro != "")
            {
                throw new Exception(erro);
            }

            if (erro == "")
            {
                BdPagamento bdpag = new BdPagamento();
                bdpag.insertPagamento(pagamento);

                MessageBox.Show("Pagamento Registrado");
            }
        }
    }
}
