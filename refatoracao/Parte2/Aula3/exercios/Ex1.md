Numa aplicação, você possui uma classe chamada Usuario, contendo, entre outras, a propriedade IdPapel, do tipo `char`.
Cada valor diferente de IdPapel representa um papel do usuário no sistema: administrador, editor, convidado, que são representados
pelas letras A, E e C; isto é, existe um conjunto limitado de valores que a propriedade IdPapel pode assumir.
Esse código de papel do usuário é armazenado na classe Usuario, mas essa classe nunca varia de comportamento conforme
o valor do IdPapel muda de valor. 
Você não quer que a propriedade IdPapel receba qualquer valor. Qual técnica de refatoração você utilizaria? Escolha a melhor alternativa.

A- A técnica **Substituir Código de Tipo por Classe**
Isso mesmo! Um dos motivos mais comuns para usar códigos de tipos são as aplicações com bancos de dados, quando um banco de dados tem campos nos quais um tipo de informação é codificada com um número ou string.
Por exemplo, você tem uma classe Usuário com o campo Usuario_Papel, que contém informação sobre os privilégios de acesso de cada usuário: administrador, editor, convidado, etc. Nesse caso, a informação pode ser codificada no campo como A, E, C, etc.
Porém, essa abordagem possui desvantagens. Os setters do campo geralmente não verificam se o código do campo é válido, o que pode causar problemas quando alguém envia valores inválidos para esses campos.
Além disso, a verificação de tipos é impossível nesses campos, porque o campo aceita armazenar qualquer string.
A técnica refatoração **Substituir Código de Tipo por Classe** reforça a validação do tipo, garantindo integridade dos dados.

B- A técnica **Substituir Código de Tipo por Subclasse**
Ops! Quando você tem um tipo de código imutável que afeta o comportamento da classe, é necessário aplicar uma outra técnica
de refatoração: **Substituir Código de Tipo por Subclasse**, onde cada subclasse representa um dos diferentes valores possíveis
para o tipo. No caso do enunciado, a classe Usuario não muda de comportamento conforme o valor do campo IdPapel muda.

C- A técnica **Substituir Dados por Objeto**
Ops! A técnica **Substituir Dados por Objeto** apenas encapsula dados+comportamento numa nova classe. No caso do enunciado,
não temos comportamento que varia conforme o valor do campo IdPapel.

D- A técnica **Substituir Array por Objeto**.
Ops! De acordo com o enunciado, não temo os códigos armazenados em array.

