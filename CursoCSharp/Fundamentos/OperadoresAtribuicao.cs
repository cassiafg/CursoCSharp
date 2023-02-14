namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 + 10;
            num1 -= 3; //num1 = num1 - 3;
            num1 *= 5; //num1 = num1 * 5;
            num1 /= 2; //num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a; //atribuição por cópia por valor e não por referência

            a++; //operador unário de incremento: a = a + 1;
            b--; //operador unário de decremento: b = b - 1;

            Console.WriteLine($"{a} {b}");


            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c; //parecido com int b = a;
            d.nome = "Maria";
            //porém as duas referências apontam para o mesmo lugar
            Console.WriteLine(c.nome);

            Console.ReadLine();
        }
    }
}