Você está participando de uma sessão de revisão de código de um projeto
de automação bancária.

Num certo momento você tem que avaliar a classe `ContaCorrente` abaixo:

```
class Programa
{
    void Main()
    {
        var conta = new ContaCorrente();
        conta.Depositar(100);
        conta.Sacar(75);
        conta.saldo -= 35;
    }
}

class ContaCorrente
{
    public decimal saldo;

    public void Sacar(decimal valor)
    {
        if (valor > saldo)
        {
            throw new ArgumentException("Saldo insuficiente");
        }

        this.saldo -= valor;
    }

    public void Depositar(decimal valor)
    {
        this.saldo += valor;
    }
}
```

Indique um possível problema no código da classe `ContaCorrente` acima.

A. Quebra de encapsulamento
Isso mesmo! A classe ContaCorrente falhou em proteger e _encapsular_ o campo
saldo. Com isso, o código externo pode acessar e modificar diretamente o saldo,
sem conhecimento da classe!

B. Duplicação de código
Ops! Não existe código duplicado na classe. Nesse ponto, ela está bem ajustada.

C. Obsessão por tipos primitivos
Ops! Apesar da classe utilizar um decimal para armazenar o saldo, esse tipo de dado
cumpre bem o seu papel, não sendo necessário introduzir uma instância de uma nova classe para substituí-lo.

D. Violação da Lei de Demeter
Ops! A Lei de Demeter é violada quando um método 
acessa outros objetos que não fazem parte dos argumentos do método ou membros da própria classe. Mas esse não é o caso.