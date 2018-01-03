Você está desenvolvendo uma aplicação para uma imobiliária.

Essa aplicação tem uma classe chamada `Proprietario`, que herda da classe `Imovel`. 

![Ex2](https://s3.amazonaws.com/caelum-online-public/765-csharp-refatorando-codigo-parte-3/Ex2.png)

Porém, durante a revisão de código, você percebe que a classe `Imovel` não usa todos os membros da classe `Proprietario`,
e que por isso é preciso aplicar uma refatoração.

Que técnica de refatoração você implementaria? Escolha a melhor alternativa.

A- Substituir Herança por Delegação 
Isso mesmo! No mundo real, um imóvel não possui imóveis, portanto temos aqui
um **odor no código** (*code smell*) chamado **Herança Rejeitada**. Precisamos
substituir essa herança por uma delegação. Em vez de **ser** um proprietário, um imóvel deve **ter** um proprietário.

B- Substituir Delegação por Herança
Ops! A classe `Imovel` já faz uma herança, logo essa opção não faz sentido.

C- Colapsar Hierarquia
Ops! Ambas as classes são bem definidas, úteis e distintas, portanto não podemos
substituí-las por uma única classe.

D- Extrair Classe
Ops! Extrair classe não irá resolver o problema mais evidente, que é
a herança mal utilizada.

