namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //convers�o impl�cita
            int inteiro = 10;
            double quebrado = inteiro; //n�o perde informa��es
            Console.WriteLine(quebrado);

            //convers�o expl�cita = casting
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); //mesma coisa
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro n�mero:");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); //tenta converter a palavra para n�mero
            //caso n�o consiga atribui o valor 0
            Console.WriteLine("Resultado 1: {0}", numero1);


            Console.Write("Digite o segundo n�mero:");
            int.TryParse(Console.ReadLine(), out int numero2); //mesma coisa
            Console.WriteLine("Resultado 2: {0}", numero2);



            Console.ReadLine();
        }
    }
}