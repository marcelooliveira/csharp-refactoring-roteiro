Como refatorar?

```
public bool EncontrarPessoaEspecial(IList<string> pessoas)
{
    bool encontrouPessoa = false;
    foreach (var person in pessoas)
    {
        if (person.Equals("Diego"))
        {
            EnviarAlerta();
            encontrouPessoa = true;
        }
        if (person.Equals("João"))
        {
            EnviarAlerta();
            encontrouPessoa = true;
        }
    }
    return encontrouPessoa;
}
```