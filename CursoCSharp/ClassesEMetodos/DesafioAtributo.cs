using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            // Acessar a variável 'a' dentro do método Executar!

            var desafioAtributo = new DesafioAtributo();
            Console.WriteLine(desafioAtributo.a);
        }
    }
}

//'a' é um atributo de instância e 'Executar()' é um método que pertence à classe
//para acessar o atributo é necessário criar uma instância da classe onde ele está