namespace Conta_bancaria;

class Conta{
    
    public double valor;

    public double obterjuros(){
        double juros = ((valor * 0.06)*12)+ valor;    
        return juros;
        }

        public double Mensal(){
            double Mes = ((valor* 0.06) + valor/12);
            return Mes;
        }

    
}
