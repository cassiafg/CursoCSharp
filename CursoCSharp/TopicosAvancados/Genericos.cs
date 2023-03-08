using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados
{
    class Genericos
    {
        public class Caixa <T> {
            //o T pode ser substituído por outra letra, pode ter mais letras<T, A, B>

            T valorPrivado; //deve ser substituído em algum momento por um tipo (int, objeto, string...)
            public T Coisa { get; set; }

            public Caixa (T coisa)
            {
                Coisa = coisa;
                valorPrivado = coisa;
            }

            public T metodoGenerico(T valor)
            {
                return new Random().Next(0, 2) == 0 ? Coisa : valor; 
            }

            public T GetValor()
            {
                return valorPrivado;
            }
        }

        class CaixaInt : Caixa<int>
        {
            public CaixaInt() : base(0) { }
        }

        class CaixaProduto : Caixa<Produto>
        {
            public CaixaProduto() : base(new Produto()) { }
        }
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType());
        }
    }
}
