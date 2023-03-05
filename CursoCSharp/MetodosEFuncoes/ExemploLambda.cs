using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //action não tem retorno (void)
            //é possível passar parâmetro na action
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //função que recebe inteiro como parâmetro
            //quando tem apenas um parâmetro pode tirar os parênteses
            //e quando tem apenas uma sentença de código não precisa as chaves

            Func<int, string> conversorHex = numero => numero.ToString("X");

            //o retorno está implícito após o arrow
            //se usar {} precisa ; e return

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}
