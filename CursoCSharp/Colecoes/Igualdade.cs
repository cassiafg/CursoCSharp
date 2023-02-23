using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; //atribuição por referência

            Console.WriteLine(p1 == p2);
            //está comparando referências de memória
            //apontam para locais diferentes de memória

            Console.WriteLine(p3 == p2);
            //apontam para o mesmo local de memória
            
            
            Console.WriteLine(p1.Equals(p2));
            //a implementalçao do método equals também compara endereço de memória
            //é necessário sobrescrever na classe produto
        }
    }
}
