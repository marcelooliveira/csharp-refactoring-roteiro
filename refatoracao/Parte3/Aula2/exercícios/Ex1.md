Você está desenvolvendo um sistema de folha de pagamento.

A classe `Funcionário` possi métodos especializados em gerar aumento
para os funcionários, chamados `DarAumentoDe5PorCento()` e 
`DarAumentoDe10PorCento`:

```
class Funcionario
{
    readonly string nome;
    public string Nome => nome;

    decimal salario;
    public decimal Salario => salario;

    public Funcionario(string nome, decimal salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public void DarAumentoDe5PorCento()
    {
        salario *= 1.05m;
    }

    public void DarAumentoDe10PorCento()
    {
        salario *= 1.10m;
    }
}
```

Qual refatoração você aplicaria nessa classe? Escolha a melhor opção:


A- 
Criaria um método chamado `DarAumento()`, recebendo como parâmetro o aumento
porcentual concedido:
```
public void DarAumento(decimal aumento)
{
    salario += aumento / 100.0m;
}
```

Isso mesmo! O corpo dos dois métodos varia em função do valor do aumento.
Logo, podemos aplicar a técnica de refatoração **Parametrizar Método**
para exigir como parâmetro o valor do aumento concedido. 

B- 
Modificaria o método `DarAumentoDe10PorCento` para chamar o método
`DarAumentoDe5PorCento()` duas vezes e assim eliminar a duplicação de código:
```
public void DarAumentoDe5PorCento()
{
    salario *= 1.05m;
}

public void DarAumentoDe10PorCento()
{
    DarAumentoDe5PorCento();
    DarAumentoDe5PorCento();
}
```
Ops! E se houver a necessidade de novos tipos de aumento, de 2% e 7%, por exemplos?
Continuaremos com um problema de termos métodos diferentes para cada
um dos possíveis valores de aumento. Isso cria duplicação desnecessária em nosso
código. **Além disso, dois aumentos consecutivos de 5% não são o mesmo que
um aumento de 10%, mas sim de 10,25%! !**

C-
Substituiria os *números mágicos* `1.05m` e `1.10m` por constantes:
```
class Funcionario
{
    private const decimal FATOR_AUMENTO_5_PORCENTO = 1.05m;
    private const decimal FATOR_AUMENTO_10_PORCENTO = 1.10m;

    .
    .
    .

    public void DarAumentoDe5PorCento()
    {
        salario *= FATOR_AUMENTO_5_PORCENTO;
    }

    public void DarAumentoDe10PorCento()
    {
        salario *= FATOR_AUMENTO_10_PORCENTO;
    }
}
```
Ops! Eliminar números mágicos é sempre bom, mas o problema principal é que
ainda teremos métodos diferentes para cada um dos possíveis valores de aumento.

D-
Removeria o método `DarAumentoDe10PorCento()`. Assim, o código cliente
teria que chamar duas vezes o método `DarAumentoDe5PorCento()` para
gerar um aumento de 10 por cento, mas com a vantagem de removermos o código
duplicado.  
```
public void DarAumentoDe5PorCento()
{
    salario *= 1.05m;
}

//MÉTODO REMOVIDO!
//public void DarAumentoDe10PorCento()
//{
//    salario *= 1.10m;
//}
```

Ops! O cálculo está errado. **Dois aumentos consecutivos de 5% não são o mesmo que
um aumento de 10%, mas sim de 10,25%!**

