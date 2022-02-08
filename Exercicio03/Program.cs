using System;

//Exercício 3:
//• Desenvolver um algoritmo que efetue a soma de todos os números 
//ímpares que são múltiplos de três e que se encontram no conjunto dos 
//números de 1 até 500

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("SOMA NUMEROS MULTIPLOS DE 3 DE 1-500, APERTE ENTER PARA CONTINUAR");
            Console.ReadLine();
            int i, soma = 0, num = 500;
            for (i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    soma = soma + i;
                }

            }
            Console.WriteLine(soma);
            Console.ReadLine();

        }
    }
}
