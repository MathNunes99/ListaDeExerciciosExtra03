using System;

//Exercício 5:
//• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de 
// do cálculo de A! e o seu resultado. 
//Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//• Pesquise sobre “fatorial"

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fat=1, count=0, i, A=0;

            Console.WriteLine("ESCREVA UM NUMERO PARA SABER O FATORIAL (EVITE NUMEROS GRANDES): ");
            A = int.Parse(Console.ReadLine());
            count = A;
            Console.Clear();


           for(i=1; i <= A; i++)
            {
                Console.Write(A + "! = ");
                
                

                while (count > 1)
                {
                    
                    if (count >= 1)
                    {
                        Console.Write(count);
                        Console.Write(" x ");
                        fat = fat * count ;
                        count = count - 1;
                    }
                }

                Console.WriteLine("1 = " + fat);
                i = A;

                Console.ReadLine();

            }
            
        }
    }
}
