Você está desenvolvendo uma aplicação de folha de pagamento.
Abaixo, está um trecho de código referente à classe `Funcionario`:

```
class Funcionario
{
    //...
    public decimal GetPagamento()
    {
        switch (Tipo)
        {
            case ENGENHEIRO:
                return Salario;
            case VENDEDOR:
                return Salario + Comissao;
            case GERENTE:
                return Salario + Bonus;
            default:
                break;
        }
        throw new Exception("Tipo desconhecido");
    }
    //...
}
```

Você nota que o método `GetPagamento()` possui comportamentos que variam conforme o código do `Tipo`.

Quais odores (code smell) você identifica nesse trecho de código? Escolha a melhor alternativa.

A- Instrução Switch (Switch Statement)
Isso mesmo! O uso da instrução `switch` faz com que a classe `Funcionario` tenha que checar o valor
de `Tipo` para decidir qual comportamento ela irá apresentar. Cada classe deveria ter um comportamento
bem definido. Esse odor (code smell) pode ser resolvido pela técnica de refatoração **Substituir Código de Tipo por State ou Strategy**.

B- Obsessão por Primitivos (Primitive Obsession)
Isso mesmo! A propriedade `Tipo` é do tipo inteiro (ou string), porém existem comportamentos associados a diferentes valores
desse tipo, que estão espalhadas pela classe `Funcionario`.  Esse odor (code smell) pode ser resolvido pela técnica de refatoração **Substituir Código de Tipo por State ou Strategy**.

C- Código duplicado (Duplicated Code)
Ops! Não existe código duplicado no trecho apresentado. Cada braço da instrução `switch` possui seu próprio algoritmo diferenciado.

D- Intermediário (Middle Man)
Ops! Não existe intermediário (middle man) no trecho apresentado. Um **intermediário** é uma classe cujos métodos
apenas delegam funcionalidades ou dados, sem acrescentar valor ao sistema.


