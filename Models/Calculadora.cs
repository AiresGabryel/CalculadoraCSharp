using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 1. Definição do Namespace
// O namespace é como um "endereço" ou um "sobrenome" para a sua classe.
// É uma boa prática que o namespace siga a estrutura de pastas.
// Como o arquivo está em "Models", o namespace é "CalculadoraCSharp.Models".
namespace CalculadoraCSharp.Models
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
    }
}