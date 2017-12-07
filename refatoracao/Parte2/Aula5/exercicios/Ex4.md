Observe o código abaixo. Ele pressupõe que os objetos `contaCorrente` e `poupanca` são não-nulos:

```<language>
class Programa
{
    //..
    void AplicarNaPoupanca(ContaBancaria contaCorrente,
        ContaBancaria poupanca, decimal valor)
    {
        contaCorrente.Sacar(valor);
        poupanca.Depositar(valor);
    }
    //..
}
```

Desenvolva os passos necessários para garantir que esse pressuposto não provoque
um erro no programa, aplicando a técnica de refatoração **Introduzir Asserção**.

## Resposta

Podemos criar um método chamado `ContasNaoNulas`, que verifica os pressupostos
e impõe uma condição no início do método. Se a condição não for satisfeita, uma  
exceção é lançada e o programa aborta antes que a transação bancária seja efetuada.

```<language>
void AplicarNaPoupanca(ContaBancaria contaCorrente,
    ContaBancaria poupanca, decimal valor)
{
    if (ContasNaoNulas(contaCorrente, poupanca))
    {
        throw new ArgumentNullException("Conta Corrente e " +
            "Poupança não podem ser nulos");
    }

    contaCorrente.Sacar(valor);
    poupanca.Depositar(valor);
}

private static bool ContasNaoNulas(ContaBancaria contaCorrente, 
    ContaBancaria poupanca)
{
    return contaCorrente == null || poupanca == null;
}
```