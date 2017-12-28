Você está desenvolvendo uma aplicação bancária.

Numa classe `ContaCorrente`, você desenvolve um método para sacar
um valor a partir da conta corrente: 

```
private void Sacar(decimal valor)
{
    if (valor > saldo)
    {
        throw new ArgumentException("Saldo insuficiente.");
    }
    saldo -= valor;
    RegistrarSaldo();
}
```

O código funciona e passa em todos os testes, sem erros. Mas,
durante a revisão de código, você nota que pode aumentar a qualidade
do código da classe `ContaCorrente` acima se usar a técnica 
de refatoração **Substituir Exceção por Teste**.

Quais os passos necessários para aplicar essa técnica ao código acima?

#RESPOSTA

