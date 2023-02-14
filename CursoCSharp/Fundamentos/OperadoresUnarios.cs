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
            Console.WriteLine(!booleano); //negação lógica

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            //numero1 será incrementado depois da comparação
            //numero2 será decrementado antes da comparação
            Console.WriteLine($"{numero1} {numero2}");
            //não é uma boa prática pois o código fica confuso, de difícil leitura

            Console.ReadLine();
        }
    }
}