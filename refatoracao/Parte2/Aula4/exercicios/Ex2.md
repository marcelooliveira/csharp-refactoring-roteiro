Como refatorar?

```
public decimal ValorSeguroAReceber()
{
    if (cumprindoCarencia) return 0; // early return
    if (mensalidadesAtrasadas > 1) return 0; // early return
    if (mesesSemSinistro < 12) return 0; // early return

    decimal resultado = 0;

    //
    //Aqui é calculado o valor do seguro...
    //
    return resultado;
}
```