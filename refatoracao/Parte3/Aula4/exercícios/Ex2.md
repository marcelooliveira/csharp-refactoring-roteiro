Você está revisando o código de um programa para um sistema de folha de pagamento.

Esse programa envolve uma hierarquia de classes:

- `Funcionario`
  - `Engenheiro`
  - `Vendedor`
  - `Gerente`

Algumas regras de negócio se aplicam a essas classes:


1. Todo funcionário recebe salário
2. Somente vendedor recebe comissão
3. Somente gerente recebe bônus


```
class Programa
{
    void Main()
    {
        Funcionario engenheiro = Funcionario.CriarFuncionario(Funcionario.TipoFuncionario.Engenheiro, "José da Silva", 1000);
        Funcionario vendedor = Funcionario.CriarFuncionario(Funcionario.TipoFuncionario.Vendedor, "Maria Bonita", 2000);
        Funcionario gerente = Funcionario.CriarFuncionario(Funcionario.TipoFuncionario.Gerente, "João das Neves", 3000);

        var valorFolhaDePagamento =
            engenheiro.Salario
            + vendedor.Salario
            + gerente.Salario;
    }
}

class Funcionario
{
    public enum TipoFuncionario
    {
        Engenheiro = 0,
        Vendedor = 1,
        Gerente = 2
    }

    protected TipoFuncionario tipo;
    public TipoFuncionario Tipo { get; }

    protected string nome;
    public string Nome => nome;

    protected decimal salario;
    public decimal Salario => salario;

    protected decimal comissao;
    public decimal Comissao => comissao;

    protected decimal bonus;
    public decimal Bonus => bonus;

    protected Funcionario(string nome, decimal salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public static Funcionario CriarFuncionario(TipoFuncionario tipo, string nome, decimal salario)
    {
        switch (tipo)
        {
            case TipoFuncionario.Engenheiro:
                return new Engenheiro(nome, salario);
            case TipoFuncionario.Vendedor:
                return new Vendedor(nome, salario);
            case TipoFuncionario.Gerente:
                return new Gerente(nome, salario);
            default:
                throw new ArgumentException("Tipo de funcionário inválido");
        }
    }

    public void DefinirComissao(decimal comissao)
    {
        if (comissao < 0)
        {
            throw new ArgumentException("Comissão não pode ser negativa");
        }

        if (comissao > .25m)
        {
            throw new ArgumentException("Comissão não pode exceder 25%");
        }

        this.comissao = comissao;
    }

    public void DefinirBonus(decimal bonus)
    {
        if (bonus < 0)
        {
            throw new ArgumentException("Bônus não pode ser negativo");
        }

        if (bonus > salario)
        {
            throw new ArgumentException("Bônus não pode ser maior que o salário");
        }

        this.bonus = bonus;
    }
}

class Engenheiro : Funcionario
{
    public Engenheiro(string nome, decimal salario) : base(nome, salario)
    {
        this.tipo = TipoFuncionario.Engenheiro;
    }
}

class Vendedor : Funcionario
{
    public Vendedor(string nome, decimal salario) : base(nome, salario)
    {
        this.tipo = TipoFuncionario.Vendedor;
    }
}

class Gerente : Funcionario
{
    public Gerente(string nome, decimal salario) : base(nome, salario)
    {
        this.tipo = TipoFuncionario.Gerente;
    }
}
```

Porém, ao revisar o código acima, você percebe que a superclasse funcionário possui
tanto o método `DefinirComissao` quanto o `DefinirBonus`. Por esse motivo, você logo identifica
que o código precisa ser refatorado. 

Que técnica de refatoração você propõe? Escolha a melhor alternativa.

A- Descer Método
Isso mesmo! A superclasse contém dois métodos que são utilizados apenas por algumas das subclasses. Precisamos mover o método `DefinirComissao` da superclasse para a subclasse `Vendedor`,
e mover o método `DefinirBonus` da superclasse para a subclasse `Gerente`.

B- Extrair classe
Ops! Em vez de extrair uma classe a partir da classe `Funcionario`, é melhor 
mover os métodos para as subclasses que realmente os utilizam.

C- Extrair Método
Ops! Extrair Método não irá resolver o problema maior, que é o fato
de a superclasse conter dois métodos que são utilizados apenas por algumas das subclasses.

D- Substituir Método por Objeto-Método
Ops! A técnica **Substituir Método por Objeto-Método** é usada quando temos
um método que é longo, porém suas variáveis são muito interligadas, o que dificulta uma extração de um método.