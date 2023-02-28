namespace classes;
class Transacao
{
    public string tipo = "";
    public int agencia;
    public int conta;
    public decimal valor;

    public void sacar(){
        valor--;
    }

     public void transferir(){
        valor--;
        valor++;
    }

     public void consultar(){
        conta--;
    }

     public void depositar(){
        valor++;
    }
    }
