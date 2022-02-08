using System;

//Exercício 1:
//• Desenvolver um algoritmo que leia a altura de 15 pessoas. Este 
//programa deverá calcular e mostrar:
//a.A menor altura do grupo;
//b.A maior altura do grupo

namespace ListaDeExerciciosExtra.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal maior, menor, altura = 0;
            int j = 0 ;

            Console.WriteLine("EXERCICIO 01");

            Console.WriteLine("QUANTAS ALTURAS VOCE QUER FAZER A LEITURA?");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("INFORME O PRIMEIRO NUMERO: ");
            altura = decimal.Parse(Console.ReadLine());
            maior = altura;
            menor = altura;

            int i = 1;

            for(i = 2; i <= j; i++)
            {
                Console.WriteLine("INFORME O " + i + " NUMERO:");
                altura = decimal.Parse(Console.ReadLine());
                if (altura > maior)
                    maior = altura;
                else if(altura < menor)
                    menor = altura;               
            }
            Console.WriteLine("O MAIOR NUMERO É: " + maior);
            Console.WriteLine("O MENOR NUMERO É: " + menor);
            Console.ReadLine();
                
        }
    }
}
