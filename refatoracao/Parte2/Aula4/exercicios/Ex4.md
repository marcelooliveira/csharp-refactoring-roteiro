Observe o método abaixo. Ele toma uma lista de pessoas e, se encontrar uma pessoa de uma outra lista de pessoas especiais,
o método envia um alerta e retorna `true`. Se não encontrar nenhuma pessoa, o método apenas retorna `false`. 

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

Porém, o método pode ser refatorado, pois o uso da flag `encontrouPessoa` não é uma boa prática. Implemente os passos necessários para aplicar a técnica de refatoração
**Remover Flag de Controle**.


### RESPOSTA


1. Crie um novo método estático para consultar e retornar a lista das pessoas especiais:

```<language>
private static IList<string> GetPessoasEspeciais()
{
    return new List<string>
    {
        "Diego",
        "João"
    };
}
```

2. Substitua as duas condições `if (person.Equals("..."))` por uma única condição que verifique a existência de uma pessoa na lista de pessoas especiais.

```<language>
if (pessoasEspeciais.Contains(person))
```

3. Em vez de atribuir valor à flag de controle, apenas retorne `true`, utilizando um _early return_.

```<language>
if (pessoasEspeciais.Contains(person))
{
    EnviarAlerta();
    return true; //early return
}
```

4. Remova a flag de controle do código.
5. Ao final do método, retorne `false`.

```<language>
public bool EncontrarPessoaEspecial(IList<string> pessoas)
{
    IList<string> pessoasEspeciais = GetPessoasEspeciais();
    foreach (var person in pessoas)
    {
        if (pessoasEspeciais.Contains(person))
        {
            EnviarAlerta();
            return true; //early return
        }
    }
    return false;
}
```


