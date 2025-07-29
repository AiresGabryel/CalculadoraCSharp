using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 1. Definição do Namespace
// O namespace é como um "endereço" ou um "sobrenome" para a sua classe.
// É uma boa prática que o namespace siga a estrutura de pastas.
// Como o arquivo está em "Models", o namespace é "CalculadoraCSharp.Models".
namespace CalculadoraCSharp.Models// faz a referencia ao namespace onde a classe está localizada
{
    // 2. Definição da Classe
    // Esta é a declaração da sua classe.
    // O "public" significa que ela pode ser acessada por outros arquivos do projeto.
    public class Calculadora //classe calculadora
    {
        // 3. Métodos da Classe
        // Estes são os métodos (as "ações") que a sua calculadora pode fazer.
        // Eles também são "public" para que possam ser chamados de fora.
        public void Somar(int x, int y)//recebe 2 parametros para realizar uma operação.
        {
            Console.WriteLine($"{x} + {y} = {x + y}");//soma
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");//divide
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");//multiplica
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");//divide
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");//calcula a potenciação
        }

        //________________SEn, Cos e Tan____________________
        // Esses métodos calculam o seno, cosseno e tangente de um ângulo

        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double seno = Math.Sin(radiano);
            //sin = Seno
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");

        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double coseno = Math.Cos(radiano);
            //cos = Coseno
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");

        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double tangente = Math.Tan(radiano);
            //tan = Tangente
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");

        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");

        }
    }
}