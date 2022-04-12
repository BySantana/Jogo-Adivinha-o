using System;

namespace Aula1_jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = new Random().Next(1, 5);

            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Você tem 5 chances para acertar o número de 1 a 5 que estou pensando");
                int numero = int.Parse(Console.ReadLine());
                if (numero == input)
                {
                    Console.WriteLine("Acertou!");
                    i = 0;
                }
                else if (numero != input)
                {
                    Console.WriteLine($"Errou!");
                    Console.WriteLine($"As chances estão acabando. Só restam {i}");
                }
               
            }
        }
    }
}
