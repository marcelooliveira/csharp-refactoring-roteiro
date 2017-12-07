Como refatorar? 

```<language>
public double GetPagamento()
{
    double result;

    if (ehFalecido)
    {
        result = ValorFalecido;
    }
    else
    {
        if (ehSeparado)
        {
            result = ValorSeparado;
        }
        else
        {
            if (ehAposentado)
            {
                result = ValorAposentado;
            }
            else
            {
                result = ValorNormal;
            }
        }
    }

    return result;
}
```