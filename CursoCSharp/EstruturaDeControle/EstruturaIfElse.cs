using System;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("N�o fez mais que sua obriga��o...");
            }else
            {
                Console.WriteLine("Recupera��o");
            }


            Console.ReadLine();

        }
    }
}