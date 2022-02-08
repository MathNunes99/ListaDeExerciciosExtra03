using System;

//Exercício 2:
//• Escrever um algoritmo que gera e escreve os números ímpares entre 100 
//e 200

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("NUMEROS IMPARES DE 100 ATÉ 200, APERTE ENTER PARA CONTINUAR");
            Console.ReadLine();
            int i, num = 200;
            for(i = 100; i <= num; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
    }
}
