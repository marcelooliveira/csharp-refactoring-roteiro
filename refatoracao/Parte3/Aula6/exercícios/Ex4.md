Você está revisando o código de uma aplicação de locadora de filmes.

As classes `ResumoHTML` e `Resumo` abaixo possuem um método de mesmo nome (`GetResumo`),
que gera um resumo do cliente em formatos diferentes, porém utilizando a mesma
sequência de algoritmos.

```
internal class ResumoHTML
{
    private Cliente cliente;

    public ResumoHTML(Cliente cliente)
    {
        this.cliente = cliente;
    }

    internal string GetResumo()
    {
        var resultado = new StringBuilder();
        resultado.AppendLine("<h1>Locações de <em>" + cliente.Nome + "</em></h1>");
        foreach (var locacao in cliente.Locacoes)
        {
            resultado.AppendLine(locacao.Filme.Titulo + "<br/>");
        }
        resultado.AppendLine("<p> Você deve: <em>R$ " + cliente.ValorTotal.ToString() + "</em></p>");
        resultado.AppendLine("Você ganhou: " + cliente.PontosDeFidelidade.ToString() + "</em> pontos.");
        return resultado.ToString();
    }
}

internal class Resumo
{
    private Cliente cliente;

    public Resumo(Cliente cliente)
    {
        this.cliente = cliente;
    }

    internal string GetResumo()
    {
        var resultado = new StringBuilder();
        resultado.AppendLine("Resumo de locações de " + cliente.Nome);
        foreach (var locacao in cliente.Locacoes)
        {
            resultado.AppendLine("\t" + locacao.Filme.Titulo);
        }
        resultado.AppendLine("Total devido: " + cliente.ValorTotal.ToString());
        resultado.AppendLine($"Você ganhou: {cliente.PontosDeFidelidade.ToString()} pontos");
        return resultado.ToString();
    }
}
```

Você decide então aplicar a técnica de refatoração **Formar Método Template**.

Realize os passos necessários para a implementação dessa refatoração.

### RESPOSTA

1- Extraia uma classe base (extrair superclasse). Vamos chamá-la de `BaseResumo`:

```
abstract class BaseResumo
{
}
```

2- Vamos aplicar a técnica **Subir Campo** para mover o campo `cliente` para a superclasse:

```
abstract class BaseResumo
{
    protected readonly Cliente cliente;

    public BaseResumo(Cliente cliente)
    {
        this.cliente = cliente;
    }
}
```

3- Na classe ResumoHTML, vamos extrair 4 métodos diferentes, para obter
cada uma das partes do relatório gerado pelo método `GetResumo`:

```
internal class ResumoHTML : BaseResumo
{
    internal string GetResumo()
    {
        var resultado = new StringBuilder();
        resultado.AppendLine(GetTitulo());
        foreach (var locacao in cliente.Locacoes)
        {
            resultado.AppendLine(GetDetalhe(locacao));
        }
        resultado.AppendLine(GetDebitos());
        resultado.AppendLine(GetPontos());
        return resultado.ToString();
    }

    string GetDebitos()
    {
        return "<p> Você deve: <em>R$ " + cliente.ValorTotal.ToString() + "</em></p>";
    }

    string GetDetalhe(Locacao locacao)
    {
        return locacao.Filme.Titulo + "<br/>";
    }

    string GetPontos()
    {
        return "Você ganhou: " + cliente.PontosDeFidelidade.ToString() + "</em> pontos.";
    }

    string GetTitulo()
    {
        return "<h1>Locações de <em>" + cliente.Nome + "</em></h1>";
    }
}
```

4- Vamos repetir o passo 3, mas desta vez para a classe `Resumo`:

```
internal class Resumo : BaseResumo
{
    string GetDebitos()
    {
        return "Total devido: " + cliente.ValorTotal.ToString();
    }

    string GetDetalhe(Locacao locacao)
    {
        return "\t" + locacao.Filme.Titulo;
    }

    string GetPontos()
    {
        return $"Você ganhou: {cliente.PontosDeFidelidade.ToString()} pontos";
    }

    string GetTitulo()
    {
        return "Resumo de locações de " + cliente.Nome;
    }
}
```

5- Na superclasse BaseResumo, vamos criar esses mesmos 4 métodos, porém
como `protected abstract`:

```
protected abstract string GetPontos();

protected abstract string GetDebitos();

protected abstract string GetDetalhe(Locacao locacao);

protected abstract string GetTitulo();
```

6- Vamos então marcar esses 4 métodos nas subclasses como `protected override`.

7- Agora aplicamos a técnica **Subir Método** para mover o método `GetResumo`
para a superclasse `BaseResumo`, como `public`:

```
public string GetResumo()
{
    var resultado = new StringBuilder();
    resultado.AppendLine(GetTitulo());
    foreach (var locacao in cliente.Locacoes)
    {
        resultado.AppendLine(GetDetalhe(locacao));
    }
    resultado.AppendLine(GetDebitos());
    resultado.AppendLine(GetPontos());
    return resultado.ToString();
}
```

8- Agora modificamos os construtores das classes
`Resumo` e `ResumoHTML` para fazer um encadeamento
com o construtor da superclasse `BaseResumo`:

```
internal class ResumoHTML : BaseResumo
{
    public ResumoHTML(Cliente cliente) : base(cliente)
    {
    }

    ...
}

internal class Resumo : BaseResumo
{
    public Resumo(Cliente cliente) : base(cliente)
    {
    }
    ...
}
```

9- Ufa! Agora sim, temos a técnica **Formar Método Template** implementada!

```
abstract class BaseResumo
{
    protected readonly Cliente cliente;

    public BaseResumo(Cliente cliente)
    {
        this.cliente = cliente;
    }

    public string GetResumo()
    {
        var resultado = new StringBuilder();
        resultado.AppendLine(GetTitulo());
        foreach (var locacao in cliente.Locacoes)
        {
            resultado.AppendLine(GetDetalhe(locacao));
        }
        resultado.AppendLine(GetDebitos());
        resultado.AppendLine(GetPontos());
        return resultado.ToString();
    }

    protected abstract string GetPontos();

    protected abstract string GetDebitos();

    protected abstract string GetDetalhe(Locacao locacao);

    protected abstract string GetTitulo();
}

internal class ResumoHTML : BaseResumo
{
    public ResumoHTML(Cliente cliente) : base(cliente)
    {
    }

    protected override string GetDebitos()
    {
        return "<p> Você deve: <em>R$ " + cliente.ValorTotal.ToString() + "</em></p>";
    }

    protected override string GetDetalhe(Locacao locacao)
    {
        return locacao.Filme.Titulo + "<br/>";
    }

    protected override string GetPontos()
    {
        return "Você ganhou: " + cliente.PontosDeFidelidade.ToString() + "</em> pontos.";
    }

    protected override string GetTitulo()
    {
        return "<h1>Locações de <em>" + cliente.Nome + "</em></h1>";
    }
}

internal class Resumo : BaseResumo
{
    public Resumo(Cliente cliente) : base(cliente)
    {
    }

    protected override string GetDebitos()
    {
        return "Total devido: " + cliente.ValorTotal.ToString();
    }

    protected override string GetDetalhe(Locacao locacao)
    {
        return "\t" + locacao.Filme.Titulo;
    }

    protected override string GetPontos()
    {
        return $"Você ganhou: {cliente.PontosDeFidelidade.ToString()} pontos";
    }

    protected override string GetTitulo()
    {
        return "Resumo de locações de " + cliente.Nome;
    }
}

```