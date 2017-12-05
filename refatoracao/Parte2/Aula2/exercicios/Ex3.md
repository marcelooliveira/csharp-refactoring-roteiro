Você está desenvolvendo uma aplicação de compras online.

Você desenvolve as classes do modelo: Cliente e Pedido. Cada Cliente pode ter N pedidos.
Cada Pedido tem somente 1 cliente associado.

Observe o código abaixo:

```
class Program
{
    void Main()
    {
        var cliente = new Cliente();
        var pedido = new Pedido();

        cliente.AdicionaPedido(pedido);
        cliente.RemovePedido(pedido);

        //acessando pedidos a partir do cliente
        foreach (var p in cliente.Pedidos)
        {
            Console.WriteLine($"Pedido: {pedido}");
        }

        //acessando cliente a partir do pedido (não é possível!)
        //Console.WriteLine($"Cliente: {pedido.Cliente}");
    }
}
```

Note que não é possível acessar o cliente a partir do pedido.

Qual técnica de refatoração necessária para permitir esse tipo de acesso?


A- Mudar Associação de Unidirecional para Bidirecional
Isso mesmo! Você tem duas classes que precisam usar recursos uma da outra, porém só existe um "link" de uma para a outra.
Porém, tome cuidado! Associações bidirecionais são mais difíceis de implementar e manter que as unidirecionais. Associações bidirecionais fazem as classes ficarem interdependentes. Com uma associação unidirecional, uma delas pode ser usada independentemente da outra.

B- Mudar Associação de Bidirecional para Unidirecional
Ops! Já temos uma associação unidirecional, navegando do cliente para os pedidos. Precisamos fazer o contrário: implementar uma associação bidirecional,
para podermos navegar do pedido para o cliente.

C- Mudar de Referência para Valor
Ops! Esse tipo de refatoração é utilizada quando você está utilizando uma referência para um objeto pequeno e imutável,
e quer trocar a referência por um valor. 

D- Mudar de Valor para Referência
Ops! Esse tipo de refatoração é utilizada quando o código trabalha com múltiplas instâncias idênticas (isto é, instâncias diferentes, porém contendo
os mesmos dados) e você quer substituí-las por uma única instância.