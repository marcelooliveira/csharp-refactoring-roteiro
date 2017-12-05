```
class Programa
{
    void Main()
    {
        var valorImposto = ICMS.CalcularValor(1000, "SP");
    }
}

class ICMS
{
    public static decimal CalcularValor(decimal valorProdutos, string uf)
    {
        if (uf == "SP")
        {
            return valorProdutos * 0.18m;
        }
        return valorProdutos * 0.15m;
    }
}
```

# RESPOSTA

1) Extrair constante
```
private const decimal ICMS_SP_PARA_SP = 0.18m;
```

2) Extrair constante
```
private const decimal ICMS_PADRAO = 0.15m;
```

3) Extrair constante
```
private const string SAO_PAULO = "SP";
```
