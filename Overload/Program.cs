using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    //melhoria do C# 6.0
    //executa sempre o override mais especializado em relação aos outros
    //evitando ambiguidades
    public class Aluno
    {
        public int Matricula { get; set; } = 123;
        public string Nome { get; set; } = "Júnior";

        public override string ToString()
        {
            return $"Nome: {Nome} - Matricula: {Matricula}";
        }
    }
    public class AlunoEspecial : Aluno
    {
        public string Situação { get; set; } = "especial";
        public override string ToString()
        {
            return $"Nome: {Nome} - Matricula: {Matricula} - Situação: {Situação}" ;
        }
    }

    class Program
    {
        static void Mostrar(int obj)
        {
            WriteLine($"Mostar(int): {obj}");
        }
        static void Mostrar(string obj)
        {
            WriteLine($"Mostar(string): {obj}");
        }
        static void Mostrar(bool obj)
        {
            WriteLine($"Mostar(boll): {obj}");
        }
        static void Mostrar(Aluno obj)
        {
            WriteLine($"Mostar(aluno): {obj}");
        }
        static void Main(string[] args)
        {
            Mostrar("string");
            Mostrar(10);
            Mostrar(false);
            Mostrar(new Aluno());
            Mostrar(new AlunoEspecial());
        }
    }
}
