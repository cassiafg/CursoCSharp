using System;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo";
            //nome = 123; n�o � poss�vel converter para int
            Console.WriteLine(nome);

            //var idade; o valor deve ser atribu�do na mesma linha
            var idade = 32; //deve ser inicializada
            Console.WriteLine(idade);

            int a; //declarando
            a = 3; //inicializando ou atribuindo
            int b = 2; //declara e inicializa ao mesmo tempo
            Console.WriteLine(a + b);

            Console.ReadLine();
        }
    }
}