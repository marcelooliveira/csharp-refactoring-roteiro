Quando você utilizaria a técnica de refatoração **Substituir Código de Tipo por State ou Strategy**?

A- Quando você tem um tipo de código que é mutável e que afeta o comportamento da classe.
Isso mesmo! Usamos os padrões de projeto **State ou Strategy** quando queremos mudar o comportamento de uma classe
simplesmente trocando o valor de um código mutável dessa classe por uma instância de uma subclasse que possui o novo comportamento.

B- Você tem um tipo de código imutável que afeta o comportamento da classe.
Ops! A situação descrita nesta alternativa se refere à técnica de refatoração **Substituir Código de Tipo por Subclasse**.
Quando temos código imutável não precisamos usar os padrões de projeto **State ou Strategy**.

C- Quando uma classe tem um código de tipo que é imutável e que não afeta o comportamento da classe.
Ops! Nessa alternativa temos um problema que é melhor resolvido pela técnica de refatoração **Substituir Código de Tipo por Classe**.
Quando temos código que não afeta o comportamento da classe, não precisamos usar os padrões de projeto **State ou Strategy**.

D- Quando uma classe acumula responsabilidades, possuindo campos e comportamentos relacionados a esses campos, e eles estão espalhados pela classe.
Ops! Esse cenário se refere à técnica **Substituir Dados por Objeto**, e não **Substituir Código de Tipo por State ou Strategy**.
