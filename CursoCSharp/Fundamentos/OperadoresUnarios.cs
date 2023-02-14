namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //inverte o sinal
            Console.WriteLine(!booleano); //nega��o l�gica

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            //numero1 ser� incrementado depois da compara��o
            //numero2 ser� decrementado antes da compara��o
            Console.WriteLine($"{numero1} {numero2}");
            //n�o � uma boa pr�tica pois o c�digo fica confuso, de dif�cil leitura

            Console.ReadLine();
        }
    }
}