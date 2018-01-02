Lembra do último exercício, onde uma classe `ItemDeServico`
servia tanto para representar itens de **mão de obra** quanto de **matéria prima**?

Aqui temos o código atual da aplicação:

```
    class Programa
    {
        void Main()
        {
            Funcionario joao = new Funcionario(50);
            ItemDeServico s1 = new ItemDeServico(5, 0, true, joao);
            ItemDeServico s2 = new ItemDeServico(15, 10, false, null);
            decimal totalDoServico = s1.GetPrecoTotal() + s2.GetPrecoTotal();
        }
    }

    class ItemDeServico
    {
        private int quantidade;
        private decimal precoUnitario;
        private Funcionario funcionario;
        private bool ehTrabalho;

        public ItemDeServico(int quantidade, decimal precoUnitario, bool ehMaoDeObra, Funcionario funcionario)
        {
            this.quantidade = quantidade;
            this.precoUnitario = precoUnitario;
            this.ehTrabalho = ehMaoDeObra;
            this.funcionario = funcionario;
        }
        public decimal GetPrecoTotal()
        {
            return quantidade * GetPrecoUnitario();
        }
        public int GetQuantidade()
        {
            return quantidade;
        }
        public decimal GetPrecoUnitario()
        {
            return (ehTrabalho) ? funcionario.GetCusto() : precoUnitario;
        }
        public Funcionario GetFuncionario()
        {
            return funcionario;
        }
    }

    class Funcionario
    {
        private decimal custo;
        public Funcionario(decimal custo)
        {
            this.custo = custo;
        }
        public decimal GetCusto()
        {
            return custo;
        }
    }
```

Depois de uma revisão de código, você descobre que é necessário extrair uma subclasse para 
o conceito de **mão de obra** e outra subclasse para **matéria prima**.
Que alterações você faria nesse código para aplicar a refatoração **Extrair Subclasse**?
Execute agora os passos necessários para essa técnica de refatoração.

#RESPOSTA

1- Vamos promover `ItemDeServico` ao nível de **superclasse**, logo
ninguém poderá criar instâncias diretamente dessa classe. Vamos então marcá-la como `abstract`.

```
abstract class ItemDeServico
{
    ...
}
```

2- Cada especialização de `ItemDeServico` deve gerar uma nova classe.
Portanto, vamos criar as subclasses `MaoDeObra` e `MateriaPrima`,
herdando de `ItemDeServico`.

```
class MaoDeObra : ItemDeServico
{
    ...
}

class MateriaPrima : ItemDeServico
{
    ...
}
```


3- Somente a classe `MaoDeObra` irá lidar com funcionários,
portanto vamos **descer o campo** `funcionario` e descer o método `**GetFuncionario**`
para essa subclasse.

```
class MaoDeObra : ItemDeServico
{
    private Funcionario funcionario;

    public Funcionario GetFuncionario()
    {
        return funcionario;
    }
}
```

4- Somente a classe `MateriaPrima` usará o campo `precoUnitario`,
portanto vamos **descer o campo** `precoUnitario` para essa subclasse.

```
class MateriaPrima : ItemDeServico
{
    private decimal precoUnitario;
}
```

5- Agora identificamos que o método `GetPrecoUnitario` assume comportamentos
diferentes dependendo do tipo do item de serviço. Portanto, vamos **descer o método**
`GetPrecoUnitario` para ambas subclasses:

```
class MaoDeObra : ItemDeServico
{
    private Funcionario funcionario;

    public decimal GetPrecoUnitario()
    {
        return funcionario.GetCusto();
    }

    public Funcionario GetFuncionario()
    {
        return funcionario;
    }

}

class MateriaPrima : ItemDeServico
{
    private decimal precoUnitario;

    public decimal GetPrecoUnitario()
    {
        return precoUnitario;
    }
} 
```

6- Agora que fizemos a técnicar "**descer método**" para ambas
subclasses, vamos marcar esse método GetPrecoUnitario como `abstract`
na superclasse, e marcá-lo como `override` nas subclasses.

```
public abstract decimal GetPrecoUnitario();
```

7- Agora modificamos o método `GetPrecoTotal` na superclasse,
para obter o valor do método `GetPrecoUnitario`:

```
public decimal GetPrecoTotal()
{
    return quantidade * GetPrecoUnitario();
}
```

8- Então identificamos os parâmetros do construtor que são comuns
a ambas as subclasses. Esse parâmetro é `quantidade`. Vamos criar
um construtor na superclasse com esse parâmetro:

```
public ItemDeServico(int quantidade)
{
    this.quantidade = quantidade;
}
```

9- Vamos aplicar a técnica de **encadeamento de construtores**,
fazendo os construtores das subclasses chamarem o construtor da superclasse:

```
class MaoDeObra : ItemDeServico
{
    ...
    public MaoDeObra(int quantidade, Funcionario funcionario)
        : base(quantidade)
    {
        this.funcionario = funcionario;
    }
    ...
}

class MateriaPrima : ItemDeServico
{
    ...
    public MateriaPrima(int quantidade, decimal precoUnitario)
        : base(quantidade)
    {
        this.precoUnitario = precoUnitario;
    }
    ...
}
```

10- Pronto! Com isso conseguimos implementar a técnica
**Extrair Subclasse** com sucesso!

```
abstract class ItemDeServico
{
    private int quantidade;

    public ItemDeServico(int quantidade)
    {
        this.quantidade = quantidade;
    }
    public decimal GetPrecoTotal()
    {
        return quantidade * GetPrecoUnitario();
    }
    public int GetQuantidade()
    {
        return quantidade;
    }
    public abstract decimal GetPrecoUnitario();
}

class MaoDeObra : ItemDeServico
{
    private Funcionario funcionario;

    public MaoDeObra(int quantidade, Funcionario funcionario)
        : base(quantidade)
    {
        this.funcionario = funcionario;
    }

    public override decimal GetPrecoUnitario()
    {
        return funcionario.GetCusto();
    }

    public Funcionario GetFuncionario()
    {
        return funcionario;
    }

}

class MateriaPrima : ItemDeServico
{
    private decimal precoUnitario;

    public MateriaPrima(int quantidade, decimal precoUnitario)
        : base(quantidade)
    {
        this.precoUnitario = precoUnitario;
    }

    public override decimal GetPrecoUnitario()
    {
        return precoUnitario;
    }
}

```