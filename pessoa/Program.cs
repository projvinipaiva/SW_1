namespace pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("GOONDOAFREDO", 18);
        //p1.AlteraNome("ANDERSON");
        //p1.AlteraSobreNome("VANIN");
        //p1.AlteraIdade(48);
        p1.MostraDados();
    }
}
