using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int maior = 0;

            while(cont <= 10)
            {
                Console.WriteLine("Digite um número: ");
                int n = int.Parse(Console.ReadLine());

                if (n>maior)
                {
                    maior = n;
                }
                cont++;
                
            }
            Console.WriteLine("O maior número é {0}", maior);


        }
    }
}