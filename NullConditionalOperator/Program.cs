using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno() { Matricula = 123, Nome = "Júnior" };
            WriteLine($"Matricula: {gp.Matricula}\nNome: {gp.Nome}");
            //operador? (Null Conditional Operator) teste se a classe foi estanciada
            //para evitar erro de Null Reference
            WriteLine($"Curso: {gp?.Curso?.NomeCurso ?? "Sem Curso"}");
            //equivalente a gp nao instanciado. curso nao foi instanciado. areadocurso nao instanciaod. AreaDoCurso nao foi instanciado
            //AreaDoCurso recebe "Sem Area"
            WriteLine($"Area: {gp?.Curso?.areadocurso?.AreaDoCuso ?? "Sem area"}");
            ReadKey();
        }
    }

    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "sem nome";
        public Curso Curso { get; set; }
    }

    public class Curso
    {
        public int Codigo { get; set; } = 0;
        public string NomeCurso { get; set; } = "sem nome";
        public Area areadocurso { get; set; }
    }

    public class Area
    {
        public int Codigo { get; set; } = 0;
        public string AreaDoCuso { get; set; } = "sem nome";
    }
}
