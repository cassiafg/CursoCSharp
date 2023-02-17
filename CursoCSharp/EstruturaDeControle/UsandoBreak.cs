using System;

namespace CursoCSharp.EstruturaDeControle
{
    public class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O n�mero que queremos � {0}", numero);

            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine("{0} � o n�mero que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                } else
                {
                    Console.WriteLine("N�o!");
                }
            }

            Console.WriteLine("Fim!");

            Console.ReadLine();
        }
    }
}