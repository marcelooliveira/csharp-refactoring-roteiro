Você desenvolveu uma aplicação de vendas online, que possui a classe `CalculadoraDePrecos()`
para obter o desconto dado a um produto de acordo com a quantidade e tempo de cadastro do cliente:

```<language>
public decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
{
    var result = descontoInicial;
    if (descontoInicial > LIMITE_MAXIMO_DESCONTO_INICIAL)
    {
        result = DESCONTO_MAXIMO;
    }
    if (quantidade > LIMITE_MINIMO_QUANTIDADE)
    {
        result += INCREMENTO_DESCONTO_POR_QUANTIDADE;
    }
    if (clienteHaQuantosAnos > LIMITE_MINIMO_ANOS_CLIENTE)
    {
        result += INCREMENTO_DESCONTO_POR_TEMPO;
    }
    return result;
}
```

Agora, você precisa que o desconto final também leve em consideração uma nova regra de negócio,
que estabelece que, se o cliente for negativado (num webservice de crédito já em funcionamento), nenhum desconto deve ser
concedido. O método `GetDescontoFinal()` não possui essa informação, porém os métodos que o chamam
possuem.

Como você faria essa refatoração? Escolha a melhor alternativa.

A- Modificaria o método `GetDescontoFinal()`, criando 
um novo parâmetro booleano chamado `clienteNegativado`. Dentro do 
corpo do método, criaria uma asserção no início do método, verificando
se `clienteNegativado` é `true` e, caso verdadeiro, retornaria
um desconto zero (com early return).
Isso mesmo! Como o chamador do método já possui essa informação, podemos criar um novo parâmetro
e passá-lo para o método, que em seguida irá fazer a asserção e tratar a nova regra de negócio.

B- Modificaria o método `GetDescontoFinal()`, introduzindo no início do método
uma chamada para o método do webservice de crédito que informa se o cliente está negativado ou não.
Em seguida, criaria uma asserção no início do método, verificando
se `clienteNegativado` é `true` e, caso verdadeiro, retornaria
um desconto zero (com early return).
Ops! O código que chama o método `GetDescontoFinal()` já fez essa chamada ao webservice anteriormente,
então não precisamos chamar o webservice de novo. Basta passar o valor como parâmetro.

C- Nos códigos que chamam o método `GetDescontoFinal()`, faria uma verificação no webservice de crédito
e armazenaria essa informação na variável booleana chamada `clienteNegativado`. Assim, o método
`GetDescontoFinal()` só seria chamado se a werbservice de crédito retornasse `clienteNegativado = false`.
Ops! Precisamos encapsular e centralizar também a nova regra de negócio num mesmo método, logo
devemos colocá-la no método `GetDescontoFinal()`.

D- Criaria um novo campo na classe `CalculadoraDePrecos()` chamado `clienteNegativado`.
Criaria ou modificaria o construtor da classe `CalculadoraDePrecos()` para receber e atribuir o valor a esse campo.
Dentro do corpo do método `GetDescontoFinal()`, criaria uma asserção no início do método, verificando
se `clienteNegativado` é `true` e, caso verdadeiro, retornaria
um desconto zero (com early return).
Ops! Só precisamos criar um novo campo `clienteNegativado` na classe `CalculadoraDePrecos()`
se essa informação for imutável e também utilizada em outros método da classe.
