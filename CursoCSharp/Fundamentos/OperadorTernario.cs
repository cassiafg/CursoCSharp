namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 && bomComportamento //expressão = primeira parte
                ? "Aprovado" : "Reprovado";                    //primeiro operando se for verdadeiro
            Console.WriteLine(resultado);                      //segundo operando se for falso

            Console.ReadLine();
        }
    }
}