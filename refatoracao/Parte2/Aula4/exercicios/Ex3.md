Como refatorar?

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