****PAREI AQUI
****PAREI AQUI
****PAREI AQUI

Você está trabalhando num sistema, e uma das funções é calcular
o valor do Imposto de Circulação de Mercadorias e Serviços (ICMS).

A classe `Programa` contém o seguinte código:

```<language>
class Programa
{
    void Main()
    {
        var nf = new NotaFiscal(1000, "SP");
        var valorProdutos = nf.ValorProdutos;
        var uf = nf.Uf;
        var valorImposto = ICMS.CalcularValor(valorProdutos, uf);
    }
}
```

Note que o valor do imposto é obtido através do método estático `CalculaValor`
da classe `ICMS`. O método calcula o valor do imposto a partir do valor dos produtos
e do estado (uf) do consumidor.

Que tal melhorar a qualidade desse código? Proponha uma refatoração escolhendo a melhor alternativa:

A- 

```<language>
class Programa
{
    void Main()
    {
        var nf = new NotaFiscal(1000, "SP");
        var valorImposto = ICMS.CalcularValor(nf);
    }
}
```

B- 

C- 

D- 


