Em que situação você utilizaria a técnica de refatoração Subir Corpo do Construtor (Pull Up Constructor Body)?

A- Quando o corpo dos construtores das subclasses possuem códigos praticamente idênticos
Isso mesmo! Para evitar a duplicação do código dos construtores, movemos o corpo do construtor duplicado para a superclasse da hierarquia.

B- Quando o corpo dos construtores das subclasses possuem trechos de código diferentes
Ops! Se os construtores possuem códigos diferentes, então não podemos generalizar, ou seja, não podemos subir o corpo do construtor para a superclasse.

C- Quando somente algumas subclasses possuem um construtor definido
Ops! Se uma subclasse não possui construtor, não temos um construtor comum para generalizar.

D- Quando somente a superclasse possui um construtor definido
Ops! Se as subclasses não possuem construtor, não há construtor algum para subirmos para a superclasse.