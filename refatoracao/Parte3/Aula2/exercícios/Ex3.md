Você está trabalhando num sistema, e uma de suas funções é calcular
o valor do Imposto de Circulação de Mercadorias e Serviços (ICMS).

A classe `Programa` contém o seguinte código:

```
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
Substituir os parâmetros do método por um único parâmetro `NotaFiscal`:
```
class Programa
{
    void Main()
    {
        var nf = new NotaFiscal(1000, "SP");
        var valorImposto = ICMS.CalcularValor(nf);
    }
}

class ICMS
{
    private const decimal ICMS_SP_PARA_SP = 0.18m;
    private const decimal ICMS_PADRAO = 0.15m;
    private const string SAO_PAULO = "SP";

    public static decimal CalcularValor(NotaFiscal nf)
    {
        if (nf.Uf == SAO_PAULO)
        {
            return nf.ValorProdutos * ICMS_SP_PARA_SP;
        }
        return nf.ValorProdutos * ICMS_PADRAO;
    }
}
```
Isso aí! Essa técnica é chamada de **Preservar Objeto Inteiro** (*Preserve Whole Object*), 
e elimina a necessidade de "desmembrar" um objeto para passar suas várias propriedades como
parâmetros de um método. Podemos modificar o método para que ele receba o objeto inteiro.
Essa técnica elimina odores (*code smells*) como **Obsessão por Tipos Primitivos** e **Longa Lista de Parâmetros**.

B- 
Aplicar a refatoração **Incorporar Variável Temporária** nas duas variáveis `valorProdutos`
e `uf`:
```
class Programa
{
    void Main()
    {
        var nf = new NotaFiscal(1000, "SP");
        var valorImposto = ICMS.CalcularValor(nf.ValorProdutos, nf.Uf);
    }
}
```
Ops! Apesar de essa refatoração melhorar um pouco nosso código, ainda assim
precisamos passar múltiplos valores do mesmo objeto `NotaFiscal` para o método
`CalcularValor`. Seria melhor passar de uma vez o objeto inteiro para esse método.

C- 
Criar um novo objeto `Parametro` e passá-lo como argumento para o método `CalcularValor`:

```
class Programa
{
    void Main()
    {
        var nf = new NotaFiscal(1000, "SP");
        var parametro = Parametro(nf.ValorProdutos, nf.Uf);
        var valorImposto = ICMS.CalcularValor(parametro);
    }
}

class Parametro
{
    readonly decimal valorProdutos;
    public decimal ValorProdutos => valorProdutos;

    readonly string uf;
    public string Uf => uf;

    public Parametro(decimal valorProdutos, string uf)
    {
        this.valorProdutos = valorProdutos;
        this.uf = uf;
    }
}

class ICMS
{
    private const decimal ICMS_SP_PARA_SP = 0.18m;
    private const decimal ICMS_PADRAO = 0.15m;
    private const string SAO_PAULO = "SP";

    public static decimal CalcularValor(Parametro par)
    {
        if (par.Uf == SAO_PAULO)
        {
            return par.ValorProdutos * ICMS_SP_PARA_SP;
        }
        return par.ValorProdutos * ICMS_PADRAO;
    }
}
```
Ops! Dessa forma estamos criando um **odor no código** (*code smell*) chamado
de **intermediário** (*Middle Man*). Depois teríamos que refatorar novamente
para eliminar esse odor, com a técnica **Remover Intermediário** (*Remove Middle Man*).


D- Modificar a classe `ICMS` para aplicar a técnica **Substituir Método por Objeto-Método**.
Assim podemos mover os parâmetros para o construtor e utilizar um método sem parâmetros:

```
class Programa
{
    void Main()
    {
        var nf = new NotaFiscal(1000, "SP");
        var valorImposto = new ICMS(nf.ValorProdutos, nf.Uf).CalcularValor();
    }
}
```
Ops! Essa alteração não resolve o problema de termos ainda que passar múltiplas propriedades
do objeto `NotaFiscal` como parâmetros para o construtor da classe `ICMS`.
