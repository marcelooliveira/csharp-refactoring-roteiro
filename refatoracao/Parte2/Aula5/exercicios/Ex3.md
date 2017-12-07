Como refatorar? 

```<language>
public void Pagar()		 
{		 
    if (cartao != null) // temos que verificar nulo várias vezes		 
    {		 
        cartao.EfetuarPagamento(valor, parcelas);		 
    }		 
    else		 
    {
        AbrirCaixaRegistradora();		           
        EfetuarPagamentoEmDinheiro(valor);
        FecharCaixaRegistradora();	
    }
}		 
 		 
public void Estornar()
{		 
    if (cartao != null)
    {		 
        cartao.EstornarPagamento(valor, parcelas);		 
    }		 
    else		 
    {
        AbrirCaixaRegistradora();
        EstornarPagamentoEmDinheiro(valor);
        FecharCaixaRegistradora();
    }
}

```