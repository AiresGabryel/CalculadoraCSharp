using CalculadoraCSharp.Models;// Sem esta linha, o C# não saberia onde encontrar a classe "Calculadora".



string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;

            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");












//________________Soma com Do While___________
// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar):");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");




//___________________Tabuada com do while______________________
// Console.WriteLine("Entre com o número da tabuada: ");
// int numero = Convert.ToInt32(Console.ReadLine());
// int contador = 1;
// do
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// } while (contador <=10);


//___________________Tabuada com while______________________
//while = enquanto
// Console.WriteLine("Entre com o número da tabuada: ");
// int numero = int.Parse(Console.ReadLine());
// int contador = 1;
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }


//___________________Tabuada com for______________________
// Console.WriteLine("Digíte o número da tabuada: ");
// int numero = int.Parse(Console.ReadLine());
// for (int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// }



















































//Calculadora calc = new Calculadora();//instanciando a class
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);






