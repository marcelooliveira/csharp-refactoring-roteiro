Você desenvolveu há alguns anos uma aplicação de vendas online, que possui a classe `CalculadoraDePrecos()`
para obter o desconto dado a um produto de acordo com o desconto inicial e o tempo de cadastro do cliente.
Com o tempo essa aplicação foi sendo modificada, porém continua funcionando sem problemas. Hoje você teve a oportunidade de
revisar o código. O método `GetDescontoFinal` atualmente tem esta aparência:

```<language>
public decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos, bool clienteNegativado)
{
    if (clienteNegativado)
    {
        return 0;
    }

    var result = descontoInicial;
    if (descontoInicial > LIMITE_MAXIMO_DESCONTO_INICIAL)
    {
        result = DESCONTO_MAXIMO;
    }
    if (clienteHaQuantosAnos > LIMITE_MINIMO_ANOS_CLIENTE)
    {
        result += INCREMENTO_DESCONTO_POR_TEMPO;
    }
    return result;
}
```

Que refatoração pode ser aplicada a esse método? Escolha a melhor resposta.

A- Remover Parâmetro
Isso mesmo! O parâmetro `quantidade` não está sendo mais utilizado no corpo do código,
portanto ele pode ser eliminado da lista de parâmetros do método.

B- Adicionar Parâmetro
Ops! Não precisamos adicionar parâmetro, pois estamos numa sessão de revisão de código e nenhuma funcionalidae nova é necessária.

C- Substituir Número Mágico
Ops! O único número literal está na linha `return 0;`, porém o número `0` é um caso
especial que não precisa ser substituído por constante, pois seu significado é óbvio.

D- Extrair método
Ops! O código não tem um trecho de código que precise ser agrupado num novo método.