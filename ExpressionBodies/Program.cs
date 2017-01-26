using System;
using static System.Console;

namespace ExpressionBodies
{
    public static class Calc
    {
        //usando Expression Bodies
        //muito parecido com LambdaExpression
        public static string Nome => "C# Calc";

        //usando Expression Bodies
        public static int Somar(int X, int Y) => X + Y;
        //{
        //    return X + Y;
        //}

        //usando Expression Bodies
        public static int Multiplicar(int X, int Y) => X * Y;
        //{
        //    return (X * Y);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 20;
            var resultado = Calc.Somar(X, Y);

            X = 20;
            Y = 10;
            var resultado2 = Calc.Multiplicar(X, Y);

            WriteLine($"Os resultados dos calculos foram {resultado} e {resultado2} feitos em {Calc.Nome} ");
        }
    }
}
