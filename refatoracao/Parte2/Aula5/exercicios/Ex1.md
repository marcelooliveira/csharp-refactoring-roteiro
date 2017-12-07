Em que situação você utilizaria a técnica de refatoração **Substituir Condições Aninhadas com Cláusulas de Guarda**?

A- Um método tem comportamento condicional que não deixa claro qual é o caminho de execução normal
Isso mesmo! Condições aninhadas são fáceis de identificar: basta encontrar os IFs aninhados em vários níveis de indentação.
Isso provoca confusão, dificuldade de leitura e complexidade no código.
Além disso, é difícil identificar qual o fluxo "normal" de um programa, e quais são as suas exceções. 
Para resolver isso, podemos introduzir "cláusulas guardiãs" para eliminar o aninhamento (a indentação do código) e deixar a estrutura com uma aparência mais achatada e fácil de ler.

B- Você tem um código de tipo que afeta o comportamento de uma classe
Ops! Nessa situação utilizamos outra técnica: **Substituir Condição por Polimorfismo**

C- Você tem verificações de valor nulo repetidas
Ops! Essa é uma situação em que utilizamos a técnica **Introduzir Objeto Null**.

D- Uma seção do código pressupõe algo sobre o estado do programa
Ops! A técnica **Introduzir Asserção** é mais adequada para resolver esse problema.
