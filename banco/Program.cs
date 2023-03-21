namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco Etec MCM!");
        Conta c = new Conta();
       // c.Saldo = 1500;
       c.Depositar(1500);

       c.AjustaLimite(500);

        //Console.WriteLine("seu saldo é de: " + c.Saldo + " e seu limite é de: "  + c.Limite);
        Console.WriteLine("seu saldo é de: " + c.MostrarSaldo());
    }
}
