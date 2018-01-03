Numa aplicação de vendas online, você se depara com o código da classe `Pagamento` abaixo:

```
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

Você então decide aplica a técnica de refatoração **Introduzir Objeto Nulo**.
Qual o benefício desse tipo de refatoração?

A- Elimina verificação de objeto frequentes
Isso mesmo! **Introduzir Objeto Null** elimina checagem excessiva de objeto para descobrir se ele é nulo ou não.

B- Elimina indentação excessiva de código
Ops! Esse benefício é alcançado com a técnica **Substituir Condições Aninhadas com Cláusulas de Guarda**.

C- Remove código duplicado
Ops! A técnica **Introduzir Objeto Null** não nos ajudaria a eliminar código duplicado no trecho acima.

D- Evita que pressupostos errados possam parar o programa ou corromper dados na aplicação
Ops! Pressupostos errado podem ser evitados através da técnica **Introduzir Asserção**.




