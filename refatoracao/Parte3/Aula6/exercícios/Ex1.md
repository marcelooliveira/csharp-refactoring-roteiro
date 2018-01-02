Em que cenário você utilizaria a técnica de refatoração **Colapsar Hierarquia**?

A- Quando a subclasse e superclasse são praticamente iguais
Isso mesmo! Quando a subclasse e superclasse são praticamente iguais, usamos a técnica **Colapsar Hierarquia**,
escolhendo qual classe deve continuar na aplicação e, em seguida, movendo para essa classe
os métodos/propriedades necessários, e em seguida, eliminando a classe menos importante.
B- Quando duas ou mais subclasses possuem métodos diferentes, mas que executam um algoritmo na mesma ordem
Ops! Nesse cenário devemos aplicar a técnica **Formar Método Template**, pois assim vamos extrair o "esqueleto"
da sequência de execução do algoritmo.
C- Quando a subclasse só usa uma parte dos dados ou comportamentos da superclasse
Ops! Nesse cenário usamos outra técnica: **Substituir Herança por Delegação**.
D- Quando uma classe tem um campo que referencia outra classe, e tem métodos simples, que fazem nada além de chamar os métodos dessa outra classe
Ops! Aplicamos a técnica **Substituir Delegação por Herança** nesse cenário.

