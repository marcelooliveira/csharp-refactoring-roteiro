Como refatorar?

```
public decimal GetValorTotal(DateTime data, int dias)
{
    if (data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO))
        return dias * _taxaInverno + _taxaServicoInverno;

    return dias * _taxaVerao; //early return
}
```