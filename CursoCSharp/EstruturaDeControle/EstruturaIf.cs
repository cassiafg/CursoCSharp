using System;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIf
    {
        public static void Executar()
        {            
            //if (exp) { 
            //    Sentença;
            //    Sentença;
            //    Sentença;
            //}

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;
            //comentar = ctrl k c

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }


            Console.ReadLine();
            
        }
    }
}

