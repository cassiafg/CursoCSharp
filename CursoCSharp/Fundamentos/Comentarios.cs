using System;


namespace CursoCSharp.Fundamentos
{
    /// <summary>
    /// 
    /// </summary>
    class Comentarios
    {
        /// <summary>
        /// basta colocar 3 barras
        /// </summary>

        public static void Executar()
        {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            /*
             * Esse é um comentário
             * de múltiplas linhas
             */
            Console.WriteLine("O C# tem o XML Comments");

            //Ctrl + k + c = comenta seleção
            //Crtl + k +u = descomentar
            Console.ReadLine();
        }
    }
}

