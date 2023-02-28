using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    //os métodos da interface não podem ter corpo
    //uma classe aderente a interface deve implementar todos os seus métodos
    //uma classe pode implementar múltiplas interfaces
    //e só pode herdar 1 classe
    //uma interface pode herdar de outra(s) interface(s)
    interface OperacaoBinaria{
        int Operacao(int a, int b); //não vai a palavra abstract, fica implícito que é abstrato
        //public por padrão e abstrato por padrão
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando{op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }
    class Interface
    {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
