Você está desenvolvendo um software para atendimento hospitalar.

O software contém a classe abstrata Paciente, e também as classes Homem e Mulher, que herdam de Paciente.

Você também tem uma classe Hospital, que faz o atendimento dos pacientes.

```
class Programa
{
    void Main()
    {
        var hospital = new Hospital();
        var paciente1 = new Mulher();
        var paciente2 = new Homem();

        hospital.Atender(paciente1);
        hospital.Atender(paciente2);
    }
}

abstract class Paciente
{
    public abstract char GetSexo();
}

class Homem : Paciente
{
    public override char GetSexo()
    {
        return 'M';
    }
}

class Mulher : Paciente
{
    public override char GetSexo()
    {
        return 'F';
    }
}

class Hospital
{
    void Teste()
    {
        var maria = new Mulher();
        var jose = new Homem();

        Atender(maria);
        Atender(jose);
    }

    public void Atender(Paciente paciente)
    {
        //codigo para atendimento hospitalar...
    }
}
```

Ao testar o código, você verifica que tudo está rodando corretamente. Porém,
durante a revisão do código, você descobre que a única diferença entre as classes Homem e Mulher
é o retorno do método GetSexo(), que é uma constante (`M` ou `F`). Por isso, você
decide aplicar a técnica de refatoração **Substituir Subclasse por Campos**.

Reproduza os passos necessários para aplicar a técnica **Substituir Subclasse por Campos** no código acima.

## RESPOSTA 

1. Aplique a técnica **Substituir Construtor por Método Factory** às subclasses.

```
class Paciente
{
    //...

    public static Paciente CriarPacienteHomem()
    {
   
    }

    public static Paciente CriarPacienteMulher()
    {
        
    }

    //...
}
```

2. Substitua chamadas aos construtores das subclasses por chamadas aos métodos factory da superclasse.

```
void Main()
{
    var hospital = new Hospital();
    var paciente1 = Paciente.CriarPacienteHomem();
    var paciente2 = Paciente.CriarPacienteMulher();

    //...
}
```

3. Na superclasse, declare constante para armazenar os valores de cada um dos métodos das subclasses que retornam valores constantes.

```
private const char MASCULINO = 'M';
private const char FEMININO = 'F';
```

4. Crie uma propriedade para armazenar o valor imutável de cada subclasse:

```
public char Sexo { get; private set; }
```

5. Crie um construtor privado na superclasse, recebendo o código do valor constante das subclasses:

```
private Paciente(char sexo)
{
    Sexo = sexo;
}
```

6. Implemente o corpo dos métodos factory da classe mãe:

```
public static Paciente CriarPacienteHomem()
{
    return new Paciente(MASCULINO);
}

public static Paciente CriarPacienteMulher()
{
    return new Paciente(FEMININO);
}
```

7. Exclua as subclasses.



