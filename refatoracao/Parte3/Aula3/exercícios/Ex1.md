Você está desenvolvendo uma aplicação de uma empresa de hotelaria.

Uma das classes é a `HotelFazenda`, que possui uma série de métodos,
entre eles o método `NaoEhVerao`:

```
class HotelFazenda
{
    .
    .
    .

    public bool NaoEhVerao(DateTime data)
    {
        return data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO);
    }
}
```

Ao revisar seu código, você percebe que nenhuma outra classe da aplicação 
utiliza o método `NaoEhVerao`, a não ser a própria classe `HotelFazenda`. 

Você decide então que é necessário aplicar a técnica de refatoração **Ocultar Método**.

Como você aplicaria essa refatoração ao código acima? Escolha a melhor opção.

A- Baixar a visibilidade do método `NaoEhVerao`, de `public` para `private`.
Isso aí! Quando baixamos a visibilidade do método de `public` para `private`,
nenhuma outra classe conseguirá enxergar esse método, além da própria classe `HotelFazenda`.

B- Baixar a visibilidade do método `NaoEhVerao`, de `public` para `protected`.
Quase! Quando baixamos a visibilidade do método de `public` para `protected`, dizemos
que nenhuma outra classe conseguirá enxergar esse método, além da própria classe `HotelFazenda`
**e também suas subclasses**. Como a classe `HotelFazenda` não possui subclasses, podemos
baixar a visibilidade diretamente para `private`.

C- Remover o método `NaoEhVerao` da classe `HotelFazenda`.
Ops! Dessa forma estamos removendo um método que ainda é utilizado na classe `HotelFazenda`. 

D- Baixar a visibilidade do método `NaoEhVerao` marcando-o como `abstract`.
Ops! O objetivo da palavra `abstract` é forçar as subclasses da classe `HotelFazenda`
a implementarem o método `NaoEhVerao`. Esse não é o cenário do problema. 
