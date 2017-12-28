PULLUPMETHOD

```
abstract class Cliente
{
    private readonly string nome;
    public string Nome => nome;

    protected readonly string logradouro;
    protected readonly string numero;

    public Cliente(string nome, string logradouro, string numero)
    {
        this.nome = nome;
        this.logradouro = logradouro;
        this.numero = numero;
    }
}

class PessoaFisica : Cliente
{
    private readonly string cpf;
    public string Cpf => cpf;

    public PessoaFisica(string nome, string logradouro, string numero, string cpf) 
        : base(nome, logradouro, numero)
    {
        this.cpf = cpf;
    }

    public string GetEndereco()
    {
        return $"{logradouro} {numero}";
    }
}

class PessoaJuridica : Cliente
{
    private readonly string cnpj;
    public string Cnpj => cnpj;

    public PessoaJuridica(string nome, string logradouro, string numero, string cnpj) 
        : base(nome, logradouro, numero)
    {
        this.cnpj = cnpj;
    }

    public string GetEndereco()
    {
        return $"{logradouro} {numero}";
    }
}
```