Você está desenvolvendo uma aplicação para um hotel fazenda.
Na classe `HotelFazenda`, você tem o método para obter o
valor total para um período de N dias, dependendo da estação do
ano do período de hospedagem:

```
public decimal GetValorTotal(DateTime data, int dias)
{
    if (data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO))
        return dias * taxaInverno + taxaServicoInverno;

    return dias * taxaVerao; //early return
}
```

O código acima compila e roda com sucesso, porém você repara que
é possível refatorá-lo.

Que tipo de refatoração você faria? Escolha a melhor alternativa.

A- Decompor Condição 
Isso mesmo! Repare na condição `if (data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO))` 
É difícil entender um trecho de código grande. E é ainda pior quando esse trecho é cheio de condições (if, then, else, switch, etc).

Uma única condição pode ser composta de várias partes complexas:

A condição em si (IF), que pode conter múltiplas expressões e várias partes
Os blocos (THEN) que são executados quando a condição é verdadeira. Esses blocos também podem ser complexos e difíceis de entender.
Os blocos (ELSE) que são executados quando a condição é falsa. Eles também podem ser igualmente complexos.

Entender essas condições implica em entender cada uma das partes em separado. Isso leva tempo e pode prejudica o trabalho de desenvolvimento e manutenção do código.

Com a técnica de refatoração **Decompor Condição**, o código ficaria assim:

```
public decimal GetValorTotal(DateTime data, int dias)
{
    if (NaoEhVerao(data))
        return TaxaInverno(dias);

    return TaxaVerao(dias); //early return
}
```


B- Consolidar Expressão Condicional
Ops! Não é o caso. Aplicamos **Consolidar Expressão Condicional** 
quando temos uma sequência de verificações condicionais com o mesmo resultado


C- Consolidar Fragmentos Condicionais Duplicados
Ops! Aplicamos **Consolidar Fragmentos Condicionais Duplicados** quando o mesmo 
trecho de código está presente em todos os ramos de uma árvore condicional


D- Remover Flag de Controle
Ops! Você poderia aplicar **Remover Flag de Controle**
se você tivesse uma variável que está funcionando como flag de controle para uma série de expressões booleanas.
