using System;

namespace CursoCSharp.EstruturaDeControle
{
    public class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("N�meros pares entre 1 e {0}", intervalo);

            for(int i = 1; i <= intervalo; i++)
            {
                if (i% 2 == 1)
                {
                    continue;
                    //volta para a itera��o
                }
                Console.Write(i + " ");
            }

            Console.ReadLine();

        }
    }
}

