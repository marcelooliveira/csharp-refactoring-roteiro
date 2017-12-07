Como refatorar?

```<language>
void AplicarNaPoupanca(ContaBancaria contaCorrente,
    ContaBancaria poupanca, decimal valor)
{
    contaCorrente.Sacar(valor);
    poupanca.Depositar(valor);
}
```