namespace conta_bancaria;
class Conta{

    public int Numero {get; set;}
    public double Valor;
    public string? cliente{get;set;}
    public double Saldo{get;set;}
    
    public double Limite{get; private set;}

    public double obterjuros(){
        double Juros = ((Valor * 0.06)*12) + Valor;
        return Juros;
    }

    public double Mensal(){
        double Mes = (Valor * 0.06 + Valor/12);
        return Mes;
    }

    public void Depositar(double custo){
        this.Saldo += Valor;
    }

    public void Sacar(double custo){
       if(Valor > this.Saldo + this.Limite){
         Console.WriteLine("Você não pode realizar este saque ! saldo Insuficiente!");
      }else
      this.Saldo -= Valor;
    }

    public double ConsutSaldo(){
        return this.Saldo += this.Limite;
    }

    public double MostrarSaldo(){
    return this.Saldo + this.Limite;
   }

   public void AjustaLimite(double valor){
      this.Limite = valor;
   }
}