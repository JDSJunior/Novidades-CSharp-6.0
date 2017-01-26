namespace AutoPropertyInitializer
{
    public class Aluno
    {
        //AutoPropertyInitializer
        //inicializa as propriedades diretamente na declaração
        //caso nao seja atribuido nenhum valor 
        //será atribuido os valores inicializados
        public static int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem nome";
        //é possivel chamar metodos static dentro do Initializer
        public string Status { get; set; } = Matricula == 0 ? "Não Matriculado" : "Matriculado";
    }
}
