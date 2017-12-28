PULLUPCONSTRUCTORBODY

```
abstract class Cliente
{
    protected string nome;
    public string Nome => nome;

    protected string logradouro;
    protected string numero;

    public string GetEndereco()
    {
        return $"{logradouro} {numero}";
    }
}

class PessoaFisica : Cliente
{
    private readonly string cpf;
    public string Cpf => cpf;

    public PessoaFisica(string nome, string logradouro, string numero, string cpf)
    {
        this.nome = nome;
        this.logradouro = logradouro;
        this.numero = numero;
        this.cpf = cpf;
    }
}

class PessoaJuridica : Cliente
{
    private readonly string cnpj;
    public string Cnpj => cnpj;

    public PessoaJuridica(string nome, string logradouro, string numero, string cnpj)
    {
        this.nome = nome;
        this.logradouro = logradouro;
        this.numero = numero;
        this.cnpj = cnpj;
    }
}

```