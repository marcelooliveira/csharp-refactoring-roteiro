REPLACEERRORCODEWITHEXCEPTION

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