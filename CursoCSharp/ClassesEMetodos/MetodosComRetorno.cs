using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        //cada método deve ter uma assinatura única = nome do método + parâmetros
        //dentro de uma mesma classe
        //em classes diferentes é possível ter um método com mesma assinatura de
        //um método em outra classe

        //o tipo de retorno não faz parte da assinatura!
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
            //retorna a instância da classe atual (o próprio objeto calculadoraCadeia)
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }

    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            //o construtor padrão (vazio) está implícito na classe CalculadoraComum

            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();
            //é possível encadear várias chamadas pois o resultado retorna o próprio objeto
            
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2)
                .Resultado();
            Console.WriteLine(resultado);
            //o método Resultado() retorna um inteiro, então não é possível mais encadear
        }
    }
}
