Você está desenvolvendo uma aplicação para um sistema de uma rede de farmácias.

Para isso, você cria as classes Pedido e Item (veja abaixo). 

No final, você precisa obter o valor total comprado pelo cliente:

```
class Exemplo
{
    void Teste()
    {
        var pedido1 = new Pedido("José da Silva");
        pedido1.AddItem("Alphakix", 10, 3);
        pedido1.AddItem("Stocklab", 15, 5);
        pedido1.AddItem("Statstrong", 6, 2);

        var pedido2 = new Pedido("José da Silva");
        pedido2.AddItem("Fluxon", 5, 4);
        pedido2.AddItem("Uptron", 6, 5);
        pedido2.AddItem("Fillflix", 2, 4);

        IList<Pedido> pedidos = new List<Pedido>{ pedido1, pedido2 };

        decimal comprasTotaisCliente = 
            pedidos
            .Where(p => p.Cliente.Equals("José da Silva"))
            .Sum(p => p.Itens.Sum(i => i.Total));
    }
}

class Pedido
{
    private readonly string cliente;
    public string Cliente { get; }

    private readonly IList<Item> itens = new List<Item>();
    public IReadOnlyCollection<Item> Itens => new ReadOnlyCollection<Item>(itens);
        
    public Pedido(string cliente)
    {
        this.cliente = cliente;
    }

    public static int QuantidadeDePedidosDe(IEnumerable<Pedido> pedidos, string cliente)
    {
        return pedidos
            .Count(p => 
                p.Cliente.Equals(cliente, 
                    StringComparison.CurrentCultureIgnoreCase));
    }

    public void AddItem(string produto, decimal precoUnitario, int quantidade)
    {
        itens.Add(new Item(produto, precoUnitario, quantidade));
    }

    public void RemoveItem(string produto)
    {
        var item = itens.Where(i => i.Produto.Equals(produto, StringComparison.CurrentCultureIgnoreCase)).SingleOrDefault();
        if (item != null)
        {
            itens.Remove(item);
        }
    }
}

class Item
{
    readonly string produto;
    public string Produto => produto;

    readonly decimal precoUnitario;
    public decimal PrecoUnitario => precoUnitario;

    readonly int quantidade;
    public int Quantidade => quantidade;

    public decimal Total => precoUnitario * quantidade;

    public Item(string produto, decimal precoUnitario, int quantidade)
    {
        this.produto = produto;
        this.precoUnitario = precoUnitario;
        this.quantidade = quantidade;
    }
}
```

Porém, você percebe que tanto o nome do cliente quanto o cálculo de compras armazenado na 
variável `comprasTotaisCliente` estão soltos pelo código da classe `Programa`, isto é, 
os dados e comportamento do cliente estão espalhados. 

Que técnica refatoração você sugere para resolver esse problema? Escolha a melhor opção.

## resposta

A. A técnica **Substituir Valores por Objeto**:

Isso mesmo! Você pode resolver o problema com a refatoração 
**Substituir Valores por Objeto**, seguindo os seguintes passos
- Introduzir a classe Cliente, contendo o nome do cliente
- Susbtituir o tipo do campo Pedido.Cliente de string para a nova classe Cliente
- Susbtituir o tipo do parâmetro do construtor de Pedido de string para a nova classe Cliente
- Em Exemplo.Teste(), instanciar um novo Cliente e passá-lo como parâmetro do construtor de Pedido
- Introduzir nova propriedade Cliente.TotalCompras
- Introduzir novos métodos Cliente.AdicionarItem(Item) e Cliente.RemoverItem(Item)
- Modificar método Exemplo.Teste() para acessar diretamente a propriedade Cliente.TotalCompras para obter o total do cliente.

B. A técnica **Extrair Classe**
Quase! As técnicas **Extrair Classe** e **Substituir Valores por Objeto** são similares.
A diferença está na **motivação** para refatorar: com **Extrair Classe**, temos uma classe longa que está tomando
várias responsabilidades que desejamos quebrar. Mas neste caso, usamos **Substituir Valores por Objeto**, pois
queremos substituir um tipo primitivo (Cliente, que é string) por uma instância de uma nova classe, pois esse
campo primitivo tem seu próprio comportamento (como o total de compras) e ele está provocando duplicação de código.

C. A técnica **Substituir Método por Objeto-Método**
Ops! Em **Substituir Método por Objeto-Método**, criamos uma nova classe a partir das variáveis que estão espalhadas
em um método. Mas em **Substituir Valores por Objeto** (que é este caso),  criamos uma nova classe a partir dos
campos que estão espalhados numa classe.

D. A técnica **Introduzir um Objeto Parâmetro**
Ops! Esta técnica serve para substituir uma lista de parâmetros por um parâmetro único,
que é um objeto que contém todos os parâmetros da lista original.


