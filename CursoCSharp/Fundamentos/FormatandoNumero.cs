using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C")); //currency
            Console.WriteLine(valor.ToString("P")); //percentual(multiplica por 100 e acrescenta %)
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); //currency com nenhuma casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //completar até fechar 10 posições

            Console.ReadLine();
        }
    }
}