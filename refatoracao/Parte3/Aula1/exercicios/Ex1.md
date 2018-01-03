Você está desenvolvendo um sistema bancário.

Nesse sistema, a classe Credito possui um método para calcular o crédito disponível:

```
class Credito
{
    readonly string nomeCliente;
    public string NomeCliente => nomeCliente;

    readonly decimal creditoTotal;
    public decimal CreditoTotal => creditoTotal;

    readonly decimal creditoUtilizado;
    public decimal CreditoUtilizado => creditoUtilizado;

    public Credito(string nomeCliente, decimal creditoTotal, decimal creditoUtilizado)
    {
        this.nomeCliente = nomeCliente;
        this.creditoTotal = creditoTotal;
        this.creditoUtilizado = creditoUtilizado;
    }

    public decimal GetValor()
    {
        return this.creditoTotal - this.creditoUtilizado;
    }
}
```

Que refatoração você acha que pode ser aplicada nessa classe? Escolha a melhor alternativa

A- Renomear método
Isso mesmo! O nome do método `GetValor()`  não diz muito sobre o que ele faz.
Seria melhor renomeá-lo para `GetCreditoDisponivel()`, ou algo parecido.

B- Extrair classe
Ops! Extraímos uma nova classe quando a classe de origem está com sobrecarga de responsabilidades,
o que não é o caso.

C- Extrair método
Ops! Não temos um trecho de código que justifique a extração de um novo método.

D- Introduzir Asserção
Ops! A classe `Credito` não possui métodos com pressupostos que precisem ser 
protegidos através de asserções.
