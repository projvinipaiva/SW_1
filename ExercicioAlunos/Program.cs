namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1= new Alunos();
       //NOME DO ALUNO

        Console.WriteLine("Digite seu nome:");
        aluno1.nome = Console.ReadLine();

       //NOTA 1 DA MÉDIA
        Console.WriteLine("Digite sua primeira nota:");
        aluno1.nota1 = double.Parse(Console.ReadLine());
       
       //NOTA 2 DA MÉDIA
        Console.WriteLine("Digite sua segunda nota:");
        aluno1.nota2 = double.Parse(Console.ReadLine());


        //MENSAGEM("Retorno")
        aluno1.mensagem();
    }
}