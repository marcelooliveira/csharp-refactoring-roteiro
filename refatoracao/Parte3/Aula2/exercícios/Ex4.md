Você foi contratado para desenvolver aplicações para uma rede de hotéis.

Numa das aplicações, mais especificamente na classe `HotelFazenda`,
você precisa obter o preço total de uma hospedagem de um determinado período,
que tem uma data de entrada (*check-in*) e uma data de saída (*check-out*):

```
public decimal GetValorHospedagem(DateTime dataEntrada, DateTime dataSaida)
{
    var dias = (int)(dataSaida - dataEntrada).TotalDays;

    if (NaoEhVerao(dataEntrada))
        return TaxaInverno(dias);

    return TaxaVerao(dias); //early return
}
```

Você realiza todos os testes e verifica que a aplicação roda corretamente como esperado.

No entanto, você resolve revisar o código e refatorar o que for necessário para melhorar
a qualidade do seu trabalho.

Você então descobre que o método `GetValorHospedagem` possui um **odor** (*code smell*)
conhecido como **Obsessão por Tipos Primitivos**. Você decide então aplicar a técnica de
refatoração **Introduzir Objeto-Parâmetro** (*Introduce Parameter Object*).

Realize os passos necessários para aplicar essa técnica de refatoração.

## RESPOSTA

1) Você irá precisar de uma nova classe para eliminar os *tipos primitivos* (DateTime) como parâmetros do método:

```
class Periodo
{
}
```

2) Agora essa classe também vai precisar dos campos representando cada um dos parâmetros que eram passados para o método. Porém, `dataEntrada` e `dataSaida` são nomes muito específicos. Vamos pensar em algo mais genérico, como `inicio` e `fim`:

```
class Periodo
{
    readonly DateTime inicio;
    readonly DateTime fim;
}
```

3) Para acessar os campos, vamos criar propriedades somente-leitura para ambos:

```
class Periodo
{
    readonly DateTime inicio;
    readonly DateTime fim;
    public DateTime Inicio => inicio;
    public DateTime Fim => fim;
}
```

4) Adicionamos então um construtor à classe `Periodo`, para podermos alimentar os campos:

```
class Periodo
{
    readonly DateTime inicio;
    readonly DateTime fim;
    public DateTime Inicio => inicio;
    public DateTime Fim => fim;

    public Periodo(DateTime inicio, DateTime fim)
    {
    }
}
```

5) Adicionamos então um construtor à classe `Periodo`, para podermos alimentar os campos:

```
class Periodo
{
    readonly DateTime inicio;
    readonly DateTime fim;
    public DateTime Inicio => inicio;
    public DateTime Fim => fim;

    public Periodo(DateTime inicio, DateTime fim)
    {
        this.inicio = inicio;
        this.fim = fim;
    }
}
```

6) Mas e se as datas estiverem invertidas? Neste caso, vamos proteger a classe, impedindo a data inicial ser posterior à data final. Lançaremos uma exceção caso isso aconteça:

```
class Periodo
{
    readonly DateTime inicio;
    readonly DateTime fim;
    public DateTime Inicio => inicio;
    public DateTime Fim => fim;

    public Periodo(DateTime inicio, DateTime fim)
    {
        if ((fim - inicio).TotalDays < 0)
        {
            throw new ArgumentException("Datas estão invertidas!");
        }

        this.inicio = inicio;
        this.fim = fim;
    }
}
```

7) Caso alguém precise saber quantos dias possui o período informado, vamos fornecer um método `Dias` que encapsula esse cálculo:

```
class Periodo
{
    readonly DateTime inicio;
    readonly DateTime fim;
    public DateTime Inicio => inicio;
    public DateTime Fim => fim;

    public Periodo(DateTime inicio, DateTime fim)
    {
        if ((fim - inicio).TotalDays < 0)
        {
            throw new ArgumentException("Datas estão invertidas!");
        }

        this.inicio = inicio;
        this.fim = fim;
    }

    public int Dias()
    {
        return (int)(fim - inicio).TotalDays;
    }
}
```

8) Agora basta modificar o código original para consumir a classe `Periodo` de forma correta. Note como o novo objeto funciona como uma **cápsula** para a data de início e fim do período:

```
public decimal GetValorHospedagem(Periodo periodo)
{
    if (NaoEhVerao(periodo.DataInicial))
        return TaxaInverno(periodo.Dias);

    return TaxaVerao(periodo.Dias); //early return
}
```