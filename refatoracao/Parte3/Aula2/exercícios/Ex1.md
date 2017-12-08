```<language>
class Funcionario
{
    readonly string nome;
    public string Nome => nome;

    decimal salario;
    public decimal Salario => salario;

    public Funcionario(string nome, decimal salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public void DarAumentoDe5PorCento()
    {
        salario *= 1.05m;
    }

    public void DarAumentoDe10PorCento()
    {
        salario *= 1.10m;
    }
}
```