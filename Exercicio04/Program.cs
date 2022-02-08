using System;

//Exercício 4:
//• Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e 
//calcule a tabuada de N.
//• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 
//10N.

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N=0, i=0, tot=0, cont=10;

            Console.WriteLine("DIGITE UM NUMERO PARA SABER SUA TABUADA DE 1 A 10");
            N = int.Parse(Console.ReadLine());

            for(i=1; i<=cont; i++)
            {
                tot = N * i;
                Console.WriteLine(N + " x " + i + " = " + tot);

            }
            Console.ReadLine();

        }
    }
}
