Em que situação você aplicaria a técnica de refatoração **Mudar de Valor para Referência**?

A- Quando o código trabalha com múltiplas instâncias idênticas (isto é, instâncias diferentes, porém contendo
os mesmos dados) e você quer substituí-las por uma única instância.
Isso mesmo! Você está trabalhando com valores, isto é, são instâncias que são sempre criadas, usadas e depois descartadas. Você quer
passar a usar a mesma instância ao longo do tempo de execução da aplicação.

B- Quando você está utilizando um objeto pequeno e imutável
Ops! Você está confundindo as técnicas. Esse caso se aplica à técnica **Mudar de Referência para Valor**

C- Quando seu código utiliza dados com tipos primitivos e você quer substituí-los
por instância de uma nova classe
Ops! Não estamos lidando com tipos primitivos, e sim com instâncias de objetos que são criadas e depois descartadas.

D- Quando uma classe (ou grupo de classes) contém um campo de dados, e o campo possui seu próprio comportamento e dados associados.
Ops! Nesse caso descrito na alternativa precisaríamos criar uma nova classe. Mas na verdade não estamos precisando criar uma nova 
classe e sim modificar a maneira como ela é utilizada.