Você está desenvolvendo uma aplicação bancária.

Numa classe `ContaCorrente`, você desenvolve um método para obter
o valor do saldo do início de cada ano: 

```
class ContaCorrente
{
    private static int ultimoId = 0;
    private int id;
    private decimal saldo;
    private IDictionary<int, decimal> saldosIniciais 
        = new Dictionary<int, decimal>();

    .
    .
    .

    public decimal GetSaldoInicioAno(int ano)
    {
        try
        {
            return saldosIniciais[ano];
        }
        catch (IndexOutOfRangeException)
        {
            return 0;
        }
    }
}
```

O código funciona e passa em todos os testes, sem erros. Mas,
durante a revisão de código, você nota que pode aumentar a qualidade
do código da classe `ContaCorrente` acima: Note que a linha
`return saldosIniciais[ano];` pode gerar uma exceção se o 
dicionário `saldosIniciais` não contiver um valor para a chave `ano`. 

Por isso, você decide utilizar a técnica de refatoração 
**Substituir Exceção por Teste**.

Quais os passos necessários para aplicar essa técnica ao código acima?

#RESPOSTA

Essa é uma refatoração bem simples. Em vez de envolver a linha
`return saldosIniciais[ano];` num bloco `try-catch`, você
pode simplesmente antecipar e evitar o lançamento da exceção
se criar um teste simples no início do método, verificando se
o dicionário `saldosIniciais` possui a chave `ano`.

```
public decimal GetSaldoInicioAno(int ano)
{
    if (!saldosIniciais.ContainsKey(ano))
    {
        return 0;
    }
    return saldosIniciais[ano];
}
```