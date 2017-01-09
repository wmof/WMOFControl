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
    class ValidationProduto
    {

        public void ValidaInsereProduto(Produto produto)
        {
            string erro = "";

            if (produto.Descricao.Trim() == "")
            {
                erro = erro + "\n Informe a descrição do pagamento";
            }
            if (produto.Data_solicitacao.Trim().Replace("/", "") == "" || produto.Data_solicitacao.Trim().Replace("/", "").Count() != 8)
            {
                erro = erro + "\n Informe uma data de solicitação valida";
            }



            if (produto.Data_entrega.Trim().Replace("/", "") == "" && produto.Data_entrega.Trim().Replace("/", "").Count() != 8 && produto.Data_entrega.Trim().Replace("/", "").Count() != 0)
            {
                erro = erro + "\n Informe uma data de entrega valida";
            }
            if (produto.Data_entrega.Trim().Replace("/", "").Replace(" ", "") == "")
            {
                produto.Data_entrega = produto.Data_entrega.Trim().Replace("/", "");
            }
            produto.Valor = Convert.ToSingle(Convert.ToString(produto.Valor).Substring(0, Convert.ToString(produto.Valor).Count() - 2) + "," + Convert.ToString(produto.Valor).Substring(Convert.ToString(produto.Valor).Count() - 2, 2));
            if (erro != "")
            {
                throw new Exception(erro);
            }

            if (erro == "")
            {
                BdProduto bdprod = new BdProduto();
                bdprod.insertProduto(produto);

                MessageBox.Show("Produto Registrado");
            }
        }

    }
}
