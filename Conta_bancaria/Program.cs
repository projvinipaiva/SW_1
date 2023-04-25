namespace conta_bancaria;
class Program
{
    static void Main(string[] args){

        Conta conta = new Conta();

        conta.Depositar(500);
        conta.Sacar(900);
        conta.Sacar(1000);
        conta.AjustaLimite(500);

        Console.Write("Digite o valor do seu emprestimo: ");
        conta.Valor = double.Parse(Console.ReadLine());
        
        Console.WriteLine("seu saldo é de: " + conta.MostrarSaldo());
        Console.WriteLine("Seu emprestimo é de: " + conta.Valor);
        Console.WriteLine("Seu emprestimo com Juros é de: " + conta.obterjuros());
        Console.WriteLine("Suas parcelas mensais serão de: " + conta.Mensal());

    }
}