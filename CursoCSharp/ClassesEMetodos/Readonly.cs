using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        //readonly é um valor imutável, uma vez que inicializado
        //dentro do contexto do programa - pode ser setado no construtor
        //uma vez que o objeto é criado o atributo fica "somente leitura"
        //e não pode ser alterado
        //só pode ser atribuido no construtor ou inicializador da variável
        //se fosse const deveria ser inicializado na compilação
        //o tipo DateTime não pode ser const
        //e, além disso, o campo const requer que um valor seja fornecido

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar()
        {
                var novoCliente = new Cliente("Ana Silva",
                    new DateTime(1987, 5, 22));

                Console.WriteLine(novoCliente.Nome);
                Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
