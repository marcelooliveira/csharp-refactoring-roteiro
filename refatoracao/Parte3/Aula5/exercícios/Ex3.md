Você tem duas ou mais classes que possuem métodos ou dados em comum.

Qual técnica de refatoração você aplicaria a esse cenário?

A- Extrair Superclasse
Isso aí! A técnica **Extrair Superclasse** serve para *generalização* de
dados e comportamentos que estão duplicados na classe original. Com uma superclasse, você pode criar uma hierarquia 
em que as subclasses são especializações da classe base.

B- Extrair Subclasse
Ops! A técnica **Extrair Subclasse** é a técnica inversa, quando
queremos gerar especializações de uma classe. Pelo enunciado, precisamos criar uma 
superclasse que reúna os dados e comportamentos em comum
entre as classes.

C- Extrair Interface
Ops! **Extrair interface** não irá resolver o problema atual, que é a
duplicação de dados ou comportamentos na classe original.

D- Extrair Classe
Quase! Usamos **Extrair Classe** quando partes de uma classe podem formar uma nova classe,
porém nesse cenário também queremos criar uma hierarquia onde a classe extraída
será a superclasse das classes originais.