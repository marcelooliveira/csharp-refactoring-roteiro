Uma aplicação de gerenciamento de obras possui uma classe `ItemDeServico`,
que serve tanto para representar itens de **mão de obra** quanto de **matéria prima**.
Dependendo de um campo interno booleano chamado `EhMaoDeObra`, essa classe pode
assumir o comportamento ou de **mão de obra** ou de **matéria prima**.

Que tipo de refatoração você sugere para este cenário? Escolha a melhor alternativa.

A- Extrair Subclasse
Isso mesmo! A classe `ItemDeServico` está acumulando tarefas e violando o Princípio
da Responsabilidade Única (SRP - Single Responsibility Principle).
Podemos extrair uma subclasse para cada tipo de item de serviço que essa
classe representa: uma classe chamada `MateriaPrima` e outra chamada `MaoDeObra`.
Dessa forma, ambas irão herdar da superclasse `ItemDeServico`.

B- Extrair Superclasse 
Ops! Utilizamos **Extrair Superclasse** quando duas ou mais classes possuem métodos ou dados em comum.
C- Extrair Interface
Ops! **Extrair interface** não irá resolver o problema atual, que é o acúmulo de tarefas e violação do Princípio da Responsabilidade Única.
D- Extrair Classe
Quase! Usamos **Extrair Classe** quando partes de uma classe podem formar uma nova classe,
porém neste cenário temos que estabelecer uma relação de hierarquia entre a classe `ItemDeServico` e
as novas classes extraídas, portanto devemos usar **Extrair Subclasse**.