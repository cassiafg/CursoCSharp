using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    //não permite herança
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho { }

    class Avo
    {
        //virtual = permite ser sobrescrito
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        //um método selado não pode ser sobrescrito
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //não é possível sobrescrever um método sealed
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
