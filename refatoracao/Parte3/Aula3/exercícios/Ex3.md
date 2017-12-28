Você está desenvolvendo uma aplicação bancária.

Numa classe `ContaCorrente`, você desenvolve um método para sacar
um valor a partir da conta corrente: 

```
public int Sacar(decimal valor)
{
    if (valor > Saldo)
    {
        return -1;
    }

    this.saldo -= valor;
    return 0;
}
```

O código funciona corretamente e passa em todos os testes. Porém,
durante a revisão de código, você percebe que pode melhorar a qualidade
do código acima aplicando uma técnica de refatoração.

Que técnica de refatoração você aplicaria? Escolha a melhor opção.

A- Substituir Código de Erro por Exceção
B- Substituir Exceção por Código de Erro
C- Remover Números Mágicos
D- Substituir Exceção por Teste


