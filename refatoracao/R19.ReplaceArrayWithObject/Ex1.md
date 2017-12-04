```
class Empresa
{
    public Empresa()
    {
        using (var streamReader = File.OpenText("clientes.csv"))
        {
            string linha = string.Empty;
            while ((linha = streamReader.ReadLine()) != null)
            {
                string[] cliente = linha.Split(',');

                Console.WriteLine("Dados do Cliente");
                Console.WriteLine("================");
                Console.WriteLine("ID: " + cliente[0]);
                Console.WriteLine("Nome: " + cliente[1]);
                Console.WriteLine("Telefone: " + cliente[2]);
                Console.WriteLine("Website: " + cliente[3]);
                Console.WriteLine("================");
            }
        }
    }
}
```

# resposta

1. Introduzir classe

```
internal class Cliente
{
    readonly string id;
    readonly string nome;
    readonly string fone;
    readonly string website;

    public Cliente(string id, string nome, string fone, string website)
    {
        this.id = id;
        this.nome = nome;
        this.fone = fone;
        this.website = website;
    }

    public string Id
    {
        get
        {
            return id;
        }
    }

    public string Nome
    {
        get
        {
            return nome;
        }
    }

    public string Fone
    {
        get
        {
            return fone;
        }
    }

    public string Website
    {
        get
        {
            return website;
        }
    }
}
```

2. trocar `cliente` por `campos`

```
string[] campos = linha.Split(',');
```

3. criar instância de clinete

```
var cliente = new Cliente(
 	campos[0], campos[1], campos[2], campos[3]);
```

4. trocar acesso ao array por acesso ao objeto

```
Console.WriteLine("ID: " + cliente.Id);
Console.WriteLine("Nome: " + cliente.Nome);
Console.WriteLine("Telefone: " + cliente.Fone);
Console.WriteLine("Website: " + cliente.Website);
```