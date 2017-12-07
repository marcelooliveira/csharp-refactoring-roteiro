No código abaixo, como podemos refatorar? Escolha a melhor resposta.

```<language>
public double GetVelocidade()
{
    switch (tipo)
    {
        case R2D2:
            return GetVelocidadePadrao();
        case WALLY:
            return GetVelocidadePadrao() - GetCapacidadeDeCarga() * numeroDeBlocos;
        case BAYMAX:
            return comArmadura ? 0 : GetVelocidadePadrao(potencia);
        default:
            throw new Exception("Tipo não identificado");
    }
}
```

A- Com a técnica **Substituir Condição por Polimorfismo**
Isso mesmo! Use essa técnica quando você tem um código de tipo que afeta o comportamento de uma classe e usa
a variação de comportamento através de condições como acima.

B- Com a técnica **Substituir Condições Aninhadas com Cláusulas de Guarda**
Ops! Essa técnica é adequada quando o comportamento condicional que não deixa claro qual é o caminho de execução normal. Não é o caso acima.

C- Introduzir Objeto Null
Ops! Usamos essa técnica quando temos verificações de valor nulo repetidas, mas não é o caso.

D- Introduzir Asserção
Uma seção do código pressupõe algo sobre o estado do programa
Ops! O trecho de código acima não possui pressupostos para refatorarmos com a técnica **Introduzir Asserção**.

