using System.Collections.Generic;
using static System.Console;
namespace DictionaryInitializer
{
    public class Aluno
    {
        public string  Nome { get; set; }
        public string Sobrenome { get; set; }

        //metodos de inserir os valores nas coleções
        //public Aluno(string nome, string sobrenome)
        //{
        //    this.Nome = nome;
        //    this.Sobrenome = sobrenome;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Alunos = new Dictionary<int, Aluno>()
            {
                //usando Dictionary Initializer
                [123] = new Aluno() { Nome = "José", Sobrenome = "Júnior" },
                [456] = new Aluno() { Nome = "Dariana", Sobrenome = "Dariana" }
            };
            
            //metodos de inserir os valores nas colecoes
            //var a1 = new Aluno() { Nome = "José", Sobrenome = "Júnior" };
            //var a2 = new Aluno() { Nome = "Dariana", Sobrenome = "Neumann" };
            //var Alunos = new Dictionary<int, Aluno>()
            //{
            //    { 123, a1 },
            //    { 456, a2 }
            //};

            //metodos de inserir os valores nas colecoes
            //Alunos.Add(123, new Aluno() { Nome = "José", Sobrenome = "Júnior" });
            //Alunos.Add(456, new Aluno() { Nome = "Dariana", Sobrenome = "Neumann" });

            //metodos de inserir os valores nas colecoes
            //var aluno1 = new Aluno() { Nome = "José", Sobrenome = "Júnior" };
            //var aluno2 = new Aluno() { Nome = "Dariana", Sobrenome = "Neumann" };
            //Alunos.Add(123, aluno1);
            //Alunos.Add(456, aluno2);

            int Dariana = 456;

            WriteLine($"Aluno {Alunos[123].Nome} {Alunos[123].Sobrenome} ");
            WriteLine($"Aluno {Alunos[Dariana].Nome} {Alunos[Dariana].Nome}");
        }
    }
}
