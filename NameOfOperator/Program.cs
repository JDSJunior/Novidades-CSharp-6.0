using System;
using static System.Console;

namespace NameOfOperator
{
    public class Professor
    {
        public string Matricula { get; set; } = "0";
        public string Nome { get; set; } = "sem nome";
        public DateTime Data { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"Matricula: {this.Matricula} \nNome: {this.Nome} \nData: {this.Data}";
        }
    }
    public static class Relatorio
    {
        public static void Imprimir(Professor professor)
        {
            WriteLine("Relatório");
            //testa o campo professor 
            //se for nulo imprime a sentença
            WriteLine(professor?.ToString() ?? $"O parametro de nome {nameof(professor)} não pode ser nulo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Professor JJS = null;
            Relatorio.Imprimir(JJS);
            //nameof retorna o nome da variavel mesmo sem instancia-la
            WriteLine(JJS?.ToString() ?? $"Objeto {nameof(JJS)} nao instanciado");

            JJS = new Professor() { Matricula = "123", Nome = "Dariana" };
            WriteLine(JJS);
            
            ReadKey();
        }
    }
}
