using System;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é "+area);
            //cw + tab + tab = Console.WriteLine()
            

            //Tipo internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade "+idade);

            sbyte saldoDeGols = sbyte.MinValue;
            //aceita valores negativos de -128 a 127 (signed)
            Console.WriteLine("Saldo de Gols "+saldoDeGols);

            short salario = short.MaxValue;
            global::System.Console.WriteLine("Salário "+salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int "+menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            //inteiro sem sinal
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            //unsigned long (sem sinal)
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            //obrigatoriamente tem que colocar o f, se não é um double
            //double (8 bytes) tem o dobro de armazenamento do float (4 bytes)
            Console.WriteLine("Preço Computador"+ precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);

            Console.ReadLine();
        }
    }
}

