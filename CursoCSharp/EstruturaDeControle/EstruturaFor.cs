using System;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaFor
    {
        public static void Executar()
        {
            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine($"O valor de i ? {i}.");
            //    i++;
            //}

            //for(int i = 0;i < 10; i++)
            //{
            //    Console.WriteLine($"O valor de i ? {i}.");
            //}

            //for(int i = 1;i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i ? {i}.");
            //}

            double somatorio = 0;
            string entrada;
            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno{0}:", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("M?dia da turma:{0}", media);

            //usando for como while:
            //for( ;media > 9; ){
            //}


            Console.ReadLine();

        }
    }
}