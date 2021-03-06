﻿Você está desenvolvendo uma aplicação de folha de pagamento.

Nessa aplicação, uma única classe, chamada `Funcionario`, cumpre o papel
de representar três tipos diferentes de funcionário: Vendedor, Gerente e Engenheiro.

Durante a revisão de código, voê percebe que o construtor da classe `Funcionario` 
se comporta de modos diferentes, dependendo do valor do parâmetro `TipoFuncionario`: Quando criamos uma instância
do tipo Vendedor, chamamos o método `GerarRegistroDeComissao` no construtor. Quando o tipo
de funcionário é Gerente, chamamos um método diferente (`GerarRegistroDeBonus`). Quando o tipo
é Engenheiro, não chamamos nenhum desses dois métodos:

```
enum TipoFuncionario
{
    Vendedor = 0,
    Gerente = 1,
    Engenheiro = 2
}

class Funcionario
{
    .
    .
    .
    readonly TipoFuncionario tipo;
    public TipoFuncionario Tipo => tipo;

    readonly string nome;
    public string Nome => nome;

    readonly decimal salario;
    public decimal Salario => salario;

    public Funcionario(TipoFuncionario tipo, string nome, decimal salario)
    {
        this.tipo = tipo;
        this.nome = nome;
        this.salario = salario;

        LancarRegistrosNoBancoDeDados();
        GerarDocumentosFiscais();
        EnviarEmailDeBoasVindas();

        switch (tipo)
        {
            case TipoFuncionario.Vendedor:
                GerarRegistroDeComissao();
                break;
            case TipoFuncionario.Gerente:
                GerarRegistroDeBonus();
                break;
            default:
                break;
        }
    }
    .
    .
    .
}
```

Você então percebe que o construtor está utilizando um **comando switch**, que é
um *code smell* ("odor no código").

Que tipo de refatoração você aplicaria no código acima? Escolha a melhor opção.

A- Substituir Construtor por Método Factory
Isso mesmo! Quando substituimos construtor por Método Factory, podemos ter
um método factory para cada tipo diferente de funcionário. Isso permite que
cada método tenha o comportamento necessário para construir uma instância
diferente, eliminando assim o odor no código chamado **Comando Switch**.

B- Extrair Método (movendo o trecho com o `switch` para outro método)
Ops! Essa refatoração não altera o problema de termos ainda o odor no código chamado **Comando Switch**.

C- Introduzir Objeto-Parâmetro para o construtor da classe
Ops! A técnica **Introduzir Objeto-Parâmetro** é importante e resolve o problema da lista longa de parâmetros,
porém esse não é o problema mais crítico do código acima.

D- Separar Consulta do Modificador
Ops! O código acima é de um construtor de classe e não de um método, 
logo a técnica **Separar Consulta do Modificador** não se aplica aqui.