Você está desenvolvendo um sistema de folha de pagamento.

A classe `Funcionario` do sistema possui um método `DarAumento´,
que recebe o tipo do aumento (aumento por valor fixo ou porcentual):

```
public void DarAumento(int tipo, decimal aumento)
{
    switch (tipo)
    {
        case TIPO_AUMENTO_FIXO:
            salario += aumento;
            break;
        case TIPO_AUMENTO_PORCENTUAL:
            salario *= (1.0m + aumento / 100.0m);
            break;
        default:
            throw new ArgumentException("Tipo de aumento inválido");
    }
}
```

A aplicação funciona normalmente, mas você descobre que o código não está bom, e decide refatorar para melhorar
a qualidade dele. Que refatoração você faria? Escolha a melhor alternativa.

A-
Substituiria o método `DarAumento` por dois métodos, cada um para
um tipo de operação de aumento:

```
public void DarAumentoPorcentual(decimal aumento)
{
    salario *= (1.0m + aumento / 100.0m);
}

public void DarAumentoFixo(decimal aumento)
{
    salario += aumento;
}
```
Isso mesmo! Com a técnica **Substituir Parâmetro por Métodos Explícitos**,
facilitamos a leitura do código e reforçamos o propósito de cada método.

B-
Criaria duas subclasses diferentes, uma para cada tipo de aumento,
e dentro delas criaria um método `DarAumento`, e chamaria o método
da classe correta a partir método `DarAumento` original:

```
public void DarAumento(int tipo, decimal aumento)
{
    switch (tipo)
    {
        case TIPO_AUMENTO_FIXO:
            new AumentoFixo().DarAumento(this, aumento);
            break;
        case TIPO_AUMENTO_PORCENTUAL:
            new AumentoPorcentual().DarAumento(this, aumento);
            break;
        default:
            throw new ArgumentException("Tipo de aumento inválido");
    }
}
```
Ops! Essa abordagem pode funcionar, porém não é a mais simples: além
de criar duas classes novas, é necessário criar dois métodos novos
e também temos o inconveniente de manter o **comando switch**, que 
é um odor no código (*code smell*) que poderia ser evitado com outra técnica.

C-
Criaria uma nova classe, chamada `Aumento`, e dentro dela 
criaria dois métodos estáticos `DarAumentoPorcentual` e `DarAumentoFixo`,
para lidar com os tipos de aumento diferentes, e chamaria esses métodos
a partir método `DarAumento` original:

```
public void DarAumento(int tipo, decimal aumento)
{
    switch (tipo)
    {
        case TIPO_AUMENTO_FIXO:
            Aumento.DarAumentoFixo(this, aumento);
            break;
        case TIPO_AUMENTO_PORCENTUAL:
            Aumento.DarAumentoPorcentual(this, aumento);
            break;
        default:
            throw new ArgumentException("Tipo de aumento inválido");
    }
}
```
Ops! Essa refatoração pode funcionar, porém não é a mais simples: além
de criar uma classe nova, é necessário criar dois métodos novos
e também temos o inconveniente de manter o **comando switch**, que 
é um odor no código (*code smell*) que poderia ser evitado com outra técnica.


D-
Modificaria o corpo do método `DarDesconto` para trocar o comando switch
por "cláusulas de guarda" com _early returns_ e assim deixar o código mais limpo:

```
public void DarAumento(int tipo, decimal aumento)
{
    if (tipo == TIPO_AUMENTO_FIXO)
    {
        salario += aumento;
        return;
    }
    if (tipo == TIPO_AUMENTO_PORCENTUAL)
    {
        salario *= (1.0m + aumento / 100.0m);
        return;
    }
    throw new ArgumentException("Tipo de aumento inválido");
}
```

Ops! Trocar um comando *switch* por dois *ifs* como no exemplo não é vantagem 
nenhuma. Estamos fazendo a mesma coisa, porém com outros comandos.



