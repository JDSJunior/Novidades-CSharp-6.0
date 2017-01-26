using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    public class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa() { Matricula = 123, Nome = "José", Sobrenome = "Júnior" };
            //usando string interpolation é permitido  uso de dados junto com strings
            //podenso até usar o Intellisense para tal
            //apenas colocando um $ na frente da string
            WriteLine($"Olá {p.Nome} {p.Sobrenome} Matricula {p.Matricula}");
            WriteLine($"Agora são {System.DateTime.Now}");
            ReadKey();
        }
    }
}
