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
Isso mesmo! Podemos evitar a criação de códigos de erro especiais (0 e 1)
lançando uma exceção quando houver uma violação da regra que diz que o valor não
pode ser maior que o saldo.
B- Substituir Exceção por Código de Erro
Ops! O trecho acima já está usando Código de Erro.
C- Remover Números Mágicos
Quase! Números mágicos são um problema, porém não são o principal
problema do trecho acima. Se lançarmos uma exceção quando a regra for
violada, nem precisaremos mais desses códigos de erro.
D- Substituir Exceção por Teste
Ops! O trecho acima não está está lançando exceção nenhuma.

