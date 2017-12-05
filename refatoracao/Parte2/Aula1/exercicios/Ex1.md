Você desenvolveu, numa aplicação de compras online, uma classe para cálculo de impostos:

```
class Programa
{
    void Main()
    {
        var valorImposto = Imposto.CalcularValor(1000, "ISENTO");
    }
}

class Imposto
{
    public static decimal CalcularValor(decimal valorProdutos, string tipoCliente)
    {
        if (tipoCliente == "ISENTO")
        {
            return 0;
        }
        return valorProdutos * 0.15m;
    }
}
```

Porém, depois de executar com sucesso, agora você percebe que é necessário refatorar essa classe.
Que tipo de refatoração seria mais adequada no momento? Escolha a melhor resposta

A. Substituir as expressões `0.15m` e `"ISENTO"` pelas constantes: `ALIQUOTA_IMPOSTO_PADRAO` e `TIPO_CLIENTE_ISENTO`, respectivamente.

Isso mesmo! `0.15m` e `"ISENTO"` são **número mágico** e **string mágica**, respectivamente.
Um número mágico é um valor numérico ou string literal encontrado no meio do código fonte, mas sem nenhum significado óbvio. Este "anti-pattern" torna o programa mais difícil de entender e de refatorar.
Vários problemas podem surgir quando você altera este número mágico. O comando de Localizar e Substituir não funciona adequadamente: o mesmo número pode ser utilizado com propósitos diferentes em lugares diferentes do programa, o que significa que você tem que verificar cada linha de código que utiliza esse número.

B. Substituir as expressões `0.15m` e `tipoCliente == "ISENTO"` por variáveis temporárias.
Ops! Armazenar a expressão `tipoCliente == "ISENTO"` em variável não irá eliminar a string mágica `ISENTO`.

C. Substituir as expressões `valorProdutos * 0.15m` e `"ISENTO"` por uma constante.
Ops! Uma constante não pode armazenar expressão com variável, como em `valorProdutos`.

D. Substituir as expressões `valorProdutos * 0.15m` e `tipoCliente == "ISENTO"` por variáveis temporárias.
Ops! Armazenar a expressão `valorProdutos * 0.15m` em variável não irá eliminar o número mágico `0.15m`.

E. Substituir as expressões `0.15m`, `0` e `"ISENTO"` pelas constantes: `ALIQUOTA_IMPOSTO_PADRAO`, `IMPOSTO_ZERO` e `TIPO_CLIENTE_ISENTO`, respectivamente.
Quase! Não é necessário uma constante para o valor `0`, pois seu significado é óbvio (imposto zero).