Uma aplicação desktop para saúde possui um formulário para cálculo do IMC (índice de massa corporal),
que é calculado como o peso dividido pelo quadrado da altura da pessoa.

Você é responsável pela revisão do código, e se depara com o formulário FormCalculadoraAntes:

```
public partial class FormCalculadoraAntes : Form
{
    public FormCalculadoraAntes()
    {
        InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        double.TryParse(txtAltura.Text, out double altura);
        double.TryParse(txtPeso.Text, out double peso);

        if (altura == 0 || peso == 0)
        {
            MessageBox.Show("Altura ou peso inválidos!");
            return;
        }

        double imc = peso / (Math.Pow(altura, 2));
        txtIMC.Text = $"IMC calculado: {imc:0.00}";
    }
}
```

Então você percebe que a classe FormCalculadoraAntes, que faz parte da interface
do usuário (GUI) contém comportamento que deveria ser do domínio.

Para resolver esse problema, implemente os passos necessários para fazer a
técnica de refatoração **Duplicar Dados Observados**.

# Resposta

1. Primeiro precisamos criar uma classe no domínio para encapsular os comportamentos com as regras de negócio

```
internal class CalculadoraIMC
{
}
```

2. Agora a classe nova receberá o método para calcular o IMC. Vamos copiar
o código que está no formulário.

```
public void Calcular(double altura, double peso)
{
    if (altura == 0 || peso == 0)
    {
        throw new ArgumentOutOfRangeException("Altura ou peso inválidos!");
    }

    double imc = peso / (Math.Pow(altura, 2));
}
```

3. Note que agora nossa classe CalculadoraIMC não se comunica com
o formulário. Vamos aplicar o padrão de projeto chamado **Observer** (Observador).
Ou seja, a classe precisa ser "observada" sempre que o valor do IMC for calculado.
Para isso, é necessário **a)** criar uma interface para o observador da classe e **b)** criar dentro
da classe as funcionalidades para gerenciar seus observadores.

4. O primeiro passo para implementar o padrão Observer é criar a interface.

```
interface ICalculadoraObserver
{
    void ResultadoIMC(double imc);
}
```

Note que a interface exigirá a implementação do método ResultadoIMC.

5. Agora criamos uma lista de observadores:

```
private IList<ICalculadoraObserver> observadores = new List<ICalculadoraObserver>();
```

6. Mas como os observadores serão adicionados/removidos? Vamos implementar métodos para isso agora:

```
public void Adiciona(ICalculadoraObserver observador)
{
    observadores.Add(observador);
}

public void Remove(ICalculadoraObserver observador)
{
    observadores.Remove(observador);
}
```

7. Agora vamos modificar o método `Calcular` para **notificar** os observadores
quando o cálculo for efetuado:

```
public void Calcular(double altura, double peso)
{
    if (altura == 0 || peso == 0)
    {
        throw new ArgumentOutOfRangeException("Altura ou peso inválidos!");
    }

    double imc = peso / (Math.Pow(altura, 2));
    foreach (var observador in observadores)
    {
        observador.ResultadoIMC(imc);
    }
}
```

9. Agora voltamos à classe FormCalculadoraAntes. Vamos marcá-la com a interface ICalculadoraObserver
 
```
public partial class FormCalculadoraDepois : Form, ICalculadoraObserver

```

10. Vamos usar o Visual Studio para implementar a inteface:

```
public void ResultadoIMC(double imc)
{
    txtIMC.Text = $"{imc:0.00}";
}
```

11. Vamos criar um campo e definir uma nova instância de
CalculadoraIMC no construtor:

```
private readonly CalculadoraIMC calculadora;

public FormCalculadoraDepois()
{
    InitializeComponent();
    calculadora = new CalculadoraIMC();
    calculadora.Adiciona(this);
}
```

Note como acima estamos adicionando o próprio formulário como observador
da classe CalculadoraIMC.

12. Agora modificamos o método do evento Click do botão para
chamar o método do cálculo do IMC que foi transferido para a nova classe:

```
private void btnCalcular_Click(object sender, EventArgs e)
{
    double.TryParse(txtAltura.Text, out double altura);
    double.TryParse(txtPeso.Text, out double peso);

    try
    {
        calculadora.Calcular(altura, peso);
    }
    catch (Exception exc)
    {
        MessageBox.Show(exc.Message);
    }
}
```

E é isso! Conseguimos implementar com sucesso a técnica **Duplicar Dados Observados**.

