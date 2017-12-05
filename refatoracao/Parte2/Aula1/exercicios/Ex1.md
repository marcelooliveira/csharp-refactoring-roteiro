Você está desenvolvendo uma aplicação para um curso de informática.

Você implementa as classes Aluno e Curso. Um Aluno possui N cursos, e por isso
a classe Aluno expõe uma coleção (List) de cursos:

```
class Programa
{
    void Testar()
    {
        Aluno aluno = new Aluno();
        aluno.Cursos.Add(new Curso("JavaScript Básico"));
        aluno.Cursos.Add(new Curso("C# Intermediário"));
        aluno.Cursos.Add(new Curso("Java Avançado"));
    }
}

class Aluno
{
    private readonly List<Curso> cursos;
    internal List<Curso> Cursos { get => cursos; }

    public Aluno()
    {
        cursos = new List<Curso>();
    }
}

class Curso
{
    readonly string nome;
    public string Nome
    {
        get
        {
            return nome;
        }
    }

    public Curso(string nome)
    {
        this.nome = nome;
    }
}
```

Mas note também que a classe Programa consegue manipular (adicionar e remover) diretamente os cursos do aluno.
Você quer modificar o código para encapsular a coleção de cursos e fazer com que os método de adicionar e remover cursos sejam
protegidos pela classe Aluno. Implemente os passos necessários para essa refatoração.

# resposta

1. A classe Aluno expõe a coleção de cursos como uma coleção modificável:

```
internal List<Curso> Cursos { get => cursos; }
```

2. Vamos substituir o tipo do retorno por uma coleção não modificável (somente-leitura). Usaremos IReadOnlyCollection

```
public IReadOnlyCollection<Curso> Cursos { get => cursos; } 
```

3. Agora é preciso substituir o objeto retornado por uma nova instância de ReadOnlyCollection
```
public IReadOnlyCollection<Curso> Cursos { get { return new ReadOnlyCollection<Curso>(cursos); } }
```

4. Como estamos retornando uma coleção somente-leitura, o código na classe Programa não pode mais adicionar/remover
cursos diretamente. Precisamos então implementar essas funcionalidades dentro da classe Aluno:

```
public void AddCurso(Curso curso)
{
    cursos.Add(curso);
}

public void RemoveCurso(Curso curso)
{
    cursos.Remove(curso);
}
```

5. Agora vamos modificar a classe Programa para consumir os métodos Adicionar e Remover:

```
class Programa
{
    void Testar()
    {
        Aluno aluno = new Aluno();
        aluno.AddCurso(new Curso("JavaScript Básico"));
        aluno.AddCurso(new Curso("C# Intermediário"));
        aluno.AddCurso(new Curso("Java Avançado"));
    }
}
```
