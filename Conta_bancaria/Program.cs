namespace Conta_bancaria;

class Program
{
    static void Main(string[] args){
    
    Conta conta = new Conta();

    Console.Write("Digite o valor do seub emprestimo: ");
    conta.valor = double.Parse(Console.ReadLine());

    Console.WriteLine("Seu emprestimo é de: " + conta.valor);
    Console.WriteLine("Seus jutos don emprestimos é de: " + conta.obterjuros());
    Console.WriteLine("Seus jutos mensais serão de: " + conta.Mensal() + " por mes");

    }
}
