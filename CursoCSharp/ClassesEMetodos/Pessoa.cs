using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        //Atributos diretamente dentro da classe iniciam com letra maiúscula
        //e quando dentro de métodos com letra minúscula
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
