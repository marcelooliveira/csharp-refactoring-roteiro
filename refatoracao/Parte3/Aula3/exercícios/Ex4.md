REPLACEEXCEPTIONWITHTEST

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