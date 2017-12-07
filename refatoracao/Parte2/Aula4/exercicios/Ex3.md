Você está desenvolvendo uma aplicação de comércio eletrônico.

Num certo momento, você desenvovle a classe `Produto`:

```<language>
public Produto(decimal preco, bool ehVendaPromocional)
{
    this.preco = preco;
    this.ehVendaPromocional = ehVendaPromocional;

    if (ehVendaPromocional)
    {
        this.precoFinal = preco * 0.95m;
        Catalogo.IncluirProduto(this);
        GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
    }
    else
    {
        this.precoFinal = preco * 0.98m;
        Catalogo.IncluirProduto(this);
        GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
    }
}
```

Como você refatoraria  o código acima? Escolha a melhor alternativa:

A-
```<language>
public Produto(decimal preco, bool ehVendaPromocional)
{
    this.preco = preco;
    this.ehVendaPromocional = ehVendaPromocional;

    this.precoFinal = CalculaPrecoFinal();
    Catalogo.IncluirProduto(this);
    GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
}

private decimal CalculaPrecoFinal()
{
    if (ehVendaPromocional)
        return preco * FATOR_DESCONTO_PROMOCIONAL; //early return

    return preco * FATOR_DESCONTO_NORMAL;
}
```
Isso mesmo! Usamo o método `CalculaPrecoFinal()` para agrupar o 
fragmento de código que são duplicados em vários rmaos da árvre condicional no código original. Essa técnica de refatoração
se chama **Consolidar Fragmentos Condicionais Duplicados**.


B- 
```<language>
public Produto(decimal preco, bool ehVendaPromocional)
{
    this.preco = preco;
    this.ehVendaPromocional = ehVendaPromocional;

    if (ehVendaPromocional)
    {
        this.precoFinal = preco * FATOR_DESCONTO_PROMOCIONAL;
        Catalogo.IncluirProduto(this);
        GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
    }
    else
    {
        this.precoFinal = preco * FATOR_DESCONTO_NORMAL;
        Catalogo.IncluirProduto(this);
        GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
    }
}
```
Quase! Nesta alternativa, foi aplicada a técnica **Substituir Número Mágico Por Constante**,
porém esse não é o único problema do código original. Ele possui trecho duplicado em mais de um
dos ramos da árvore condicional, e pode ser refatorado com a técnica **Consolidar Fragmentos Condicionais Duplicados**.

C- 
```<language>
public Produto(decimal preco, bool ehVendaPromocional)
{
    this.preco = preco;
    this.ehVendaPromocional = ehVendaPromocional;

    Catalogo.IncluirProduto(this);
    GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
}
```
Ops! Ficou faltando atribuir um valor ao campo `this.precoFinal`.


D- 
```<language>
public Produto(decimal preco, bool ehVendaPromocional)
{
    this.preco = preco;
    this.ehVendaPromocional = ehVendaPromocional;

    Catalogo.IncluirProduto(this);
    GerenciadorDeEmail.EnviarEmailDeNovoProduto(this);
    this.precoFinal = CalculaPrecoFinal();
}

private decimal CalculaPrecoFinal()
{
    if (ehVendaPromocional)
        return preco * FATOR_DESCONTO_PROMOCIONAL; //early return

    return preco * FATOR_DESCONTO_NORMAL;
}
```

Ops! Houve uma inversão na ordem do código refatorado, e isso pode
alterar o comportamento do programa! Note como a linha `this.precoFinal` ficou incorretamente no final do método.
