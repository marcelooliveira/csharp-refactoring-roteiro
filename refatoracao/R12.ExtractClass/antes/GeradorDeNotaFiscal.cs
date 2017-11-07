using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R12.ExtractClass.antes
{
    public class GeradorDeNotaFiscal
    {
        public NotaFiscal Gera(Fatura fatura)
        {
            // calcula valor do imposto
            decimal valor = fatura.GetValorMensal();
            decimal imposto = 0;
            if (valor < 200)
            {
                imposto = valor * 0.03m;
            }
            else if (valor > 200 && valor <= 1000)
            {
                imposto = valor * 0.06m;
            }
            else
            {
                imposto = valor * 0.07m;
            }

            NotaFiscal nf = new NotaFiscal(valor, imposto);

            // envia email
            String msgDoEmail = "Caro cliente,<br/>";
            msgDoEmail += "É com prazer que lhe avisamos que sua nota fiscal foi "
                        + "gerada no valor de " + nf.GetValorLiquido() + ".<br/>";
            msgDoEmail += "Acesse o site da prefeitura e faça o download.<br/><br/>";
            msgDoEmail += "Obrigado!";

            Console.WriteLine(msgDoEmail);

            // salva no banco
            String sql = "insert into notafiscal (cliente, valor)" +
                         "values (?," + nf.GetValorLiquido() + ")";

            Console.WriteLine("Salvando no banco" + sql);

            return nf;
        }
    }

    public class Fatura
    {
        internal decimal GetValorMensal()
        {
            throw new NotImplementedException();
        }
    }

    public class NotaFiscal
    {
        decimal valor;
        decimal imposto;

        public NotaFiscal(decimal valor, decimal imposto)
        {
            this.valor = valor;
            this.imposto = imposto;
        }

        internal string GetValorLiquido()
        {
            throw new NotImplementedException();
        }
    }
}
