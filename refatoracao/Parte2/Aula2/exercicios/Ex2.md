Em que situação você aplicaria a técnica de refatoração **Mudar de Referência para Valor**?

A- Quando você está utilizando um objeto pequeno e imutável
Isso mesmo! Você está trabalhando com objeto pequeno e imutável, não faz muito sentido trabalhar com referêcia,
pois você pode facilmente criá-lo e descartá-lo a cada utilização. Referências são mais difíceis de se trabalhar
do que valores e você não vai modificar um objeto que será reutilizado ao longo do ciclo e vida da aplicação,
portanto faz mais sentido trabalhar com valor. 

B- Quando o código trabalha com múltiplas instâncias idênticas (isto é, instâncias diferentes, porém contendo
os mesmos dados) e você quer substituí-las por uma única instância.
Ops! Você está confundindo as técnicas. Esse caso se aplica à técnica **Mudar de Valor para Referência**

C- Quando uma classe (ou grupo de classes) contém um campo de dados, e o campo possui seu próprio comportamento e dados associados.
Ops! Nesse caso descrito na alternativa precisaríamos criar uma nova classe. Mas na verdade não estamos precisando criar uma nova 
classe e sim modificar a maneira como ela é utilizada.

D- Quando seu código utiliza dados com tipos primitivos e você quer substituí-los
por instância de uma nova classe
Ops! Não estamos lidando com tipos primitivos, e sim com instâncias de objetos que são criadas e depois descartadas.