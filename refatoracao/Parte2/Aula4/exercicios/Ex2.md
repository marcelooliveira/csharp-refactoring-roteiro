Você trabalha numa empresa de seguros.

Durante o desenvolvimento da classe `ValorSeguroAReceber`,
você compila e testa o código, com sucesso:

```
public decimal ValorSeguroAReceber()
{
    if (cumprindoCarencia) return 0; // early return
    if (mensalidadesAtrasadas > 1) return 0; // early return
    if (mesesSemSinistro < 12) return 0; // early return

    decimal resultado = 0;

    //
    //Aqui é calculado o valor do seguro...
    //
    return resultado;
}
```

Porém, durante a revisão do código, você percebe que há oportunidade de 
refatorar o código.

Então você decide aplicar a técnica de refatoração **Consolidar Expressão Condicional**.

Que tipo de odor (code smell) essa técnica resolve no nosso código? Escolha a melhor alternativa.


A- Código Duplicado
Isso mesmo! Note que cada condição `if` possui a mesma instrução de retorno duplicada:

```
    if (cumprindoCarencia) return 0; // early return
    if (mensalidadesAtrasadas > 1) return 0; // early return
    if (mesesSemSinistro < 12) return 0; // early return
}
```

Quando aplicamos **Consolidar Expressão Condicional**, podemos remover essa duplicação:

```<language>
public decimal ValorSeguroAReceber()
{
    if (NaoEhElegivelParaSeguro())
    {
        return 0; // early return
    }

    decimal resultado = 0;

    //
    //Aqui é calculado o valor do seguro...
    //
    return resultado;
}

private bool NaoEhElegivelParaSeguro()
{
    return cumprindoCarencia 
        || mensalidadesAtrasadas > 1 
        || mesesSemSinistro < 12;
}
```

B- Comentários
Ops! Temos comentários nesse código, mas são para ilustrar nossa aula.
Além disso, **Consolidar Expressão Condicional** não serve para remover comentários.

C- Número Mágico
Ops! Para resolver isso, teríamos que aplicar outra técnica: **Substituir Número Mágico por Constante**

D- Obsessão por Tipos Primitivos
Ops! Não temos nesse trecho tipos primitivos que precisem ser substituídos por objetos,
pois esses tipos não possuem comportamentos associados a eles.


