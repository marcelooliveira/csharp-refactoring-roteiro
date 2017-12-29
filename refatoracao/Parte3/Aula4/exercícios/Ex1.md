Em que situação você utilizaria a técnica de refatoração Subir Método (Pull Up Method)?

A- Quando duas ou mais subclasses possuem um método que realiza um trabalho similar.
Isso mesmo! Se duas subclasses possuem um método idêntico ou similar, podemos mover esse método para a superclasse,
e assim eliminar os métodos das subclasses.

B- Quando um método só existe em uma das subclasses.
Ops! Se um método só existe em uma das subclasses, não podemos movê-lo para a superclasse, porque isso
forçaria uma herança desnecessária desse método às outras subclasses.

C- Quando a superclasse possui um método abstrato que é implementado pelas subclasses.
Ops! Nesse caso, o método abstrato na superclasse indica que existe esse método é implementado
nas subclasses com código e comportamento diferentes, por isso não pode ser movido para a superclasse.

D- Quando a superclasse possui um método que é utilizado por apenas uma ou algumas das subclasses.
Ops! Nesse caso a refatoração que deve ser aplicada é a inversa: Descer Método.