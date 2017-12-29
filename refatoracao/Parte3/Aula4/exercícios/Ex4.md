Você está desenvolvendo uma aplicação de cadastro de clientes.

Nesse cadastro, um cliente pode ser ou uma pessoa física ou uma pessoa jurídica.
Por isso, temos a hierarquia definida como:

- Cliente
  - PessoaFisica
  - PessoaJuridica

Ao revisar seu código, você se depara com construtores quase idênticos nas subclasses
`PessoaFisica` e `PessoaJuridica`:

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

Então você decide aplicar a técnica de refatoração **Subir Corpo do Construtor**.

Realize agora os passos necessários para completar essa refatoração.

## RESPOSTA

1. Vamos começar criando um construtor sem parâmetros na superclasse Cliente:

```
public Cliente()
{
}
```

2. Agora vamos adicionar a esse construtor somente os parâmetros que são comuns aos construtores das subclasses: `nome`, `logradouro` e `numero`:

```
public Cliente(string nome, string logradouro, string numero)
{
}
```

3. Em seguida, precisamos adicionar a esse construtor somente o código que é comum aos construtores das subclasses:

```
public Cliente(string nome, string logradouro, string numero)
{
    this.nome = nome;
    this.logradouro = logradouro;
    this.numero = numero;
}
```

4. Agora vamos encadear o construtor da classe `PessoaFisica` com o construtor da superclasse `Cliente`, passando os parâmetros exigidos no construtor desta superclasse: `nome`, `logradouro` e `numero`:

```
public PessoaFisica(string nome, string logradouro, string numero, string cpf)
:base(nome, logradouro, numero)
{
    this.nome = nome;
    this.logradouro = logradouro;
    this.numero = numero;
    this.cpf = cpf;
}
```

5. Podemos então eliminar o código que já foi movido para o construtor da superclasse:
```
public PessoaFisica(string nome, string logradouro, string numero, string cpf)
:base(nome, logradouro, numero)
{
    this.cpf = cpf;
}
```

6. Agora basta repetir os passos 4 e 5, desta vez na subclasse `PessoaJuridica`, e assim teremos a refatoração completa:

```
abstract class Cliente
{
    protected string nome;
    public string Nome => nome;

    protected string logradouro;
    protected string numero;

    public Cliente(string nome, string logradouro, string numero)
    {
        this.nome = nome;
        this.logradouro = logradouro;
        this.numero = numero;
    }

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
        : base(nome, logradouro, numero)
    {
        this.cpf = cpf;
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
}

```

