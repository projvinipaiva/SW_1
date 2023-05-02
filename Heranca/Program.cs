namespace Heranca;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "Vinícius de P.";
        n1.Idade = 17;
        n2.Nome = "Roberto";
        n2.Idade = 58;
        n3.Nome = "Nicolas";
        n3.Idade = 23;
        n3.Cargo = "Gerente";

        Console.WriteLine("Nome:  " +  n1.Nome + "-- Idade: " +  n1.Idade + " Seu Lucro é: " + n1.Lucro());
        Console.WriteLine("Nome:  " +  n2.Nome + "-- Idade: " +  n2.Idade + " Seu Lucro é: " + n2.Lucro());
        Console.WriteLine("Nome:  " +  n3.Nome + "-- Idade: " +  n3.Idade + " -- Cargo: " + n3.Cargo + " --Seu Lucro é: " + n3.Lucro());
    }
}
