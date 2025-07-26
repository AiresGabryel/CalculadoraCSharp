// 1. Importando o Namespace (A Referência)
// Esta linha é a chave!
// Ela diz ao compilador: "Eu quero usar as classes que estão dentro do namespace 'CalculadoraCSharp.Models'".
// Sem esta linha, o C# não saberia onde encontrar a classe "Calculadora".
using CalculadoraCSharp.Models;

// 2. Instanciando a Classe
// Agora que o namespace foi importado, podemos criar um objeto (uma "instância")
// da classe "Calculadora" como se ela estivesse neste mesmo arquivo.
Calculadora calc = new Calculadora();

// 3. Chamando os Métodos
// Com o objeto "calc" criado, podemos acessar seus métodos públicos.
calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);


