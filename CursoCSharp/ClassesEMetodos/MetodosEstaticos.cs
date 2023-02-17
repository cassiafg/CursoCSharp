using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //static = o método não pertence mais ao objeto, e sim à classe
        //quando não tem a palavra estática, só pode ser acessado a partir da instância (objeto)
        //o método estático não pode ser acessado a partir da instância, apenas diretamente pela classe

        //se um atributo for estático, ele terá uma única cópia compartilhada pelos objetos
        

        //Método de Classe ou Método Estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        //Método de Instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
