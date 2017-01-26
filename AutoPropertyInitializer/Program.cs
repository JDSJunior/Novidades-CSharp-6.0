using static System.Console;

namespace AutoPropertyInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var jr = new Aluno(); //{ Matricula = 123, Nome = "Júnior" };
            WriteLine($"{ jr.Nome} - { Aluno.Matricula} - {jr.Status}");
            ReadKey();
        }
    }
}
