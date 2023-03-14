namespace ExercicioAlunos;

class Alunos
{
    public string nome="";
    public double nota1, nota2;

 // MEDIA -> retorna um double (por exemplo um número como 8.3)

 //SITUAÇÂO -> retorna um string ("Aprovado" ou "Reprovado")

 //MENSANGEM -> não retorna nada, Só mostra na tela os detalhes (nome, media e situação)   


    //Media
        public double obterMedia(){
            double media = (nota1+nota2)/2;
            return media;

        }
    //Situação
        public string obterSituacao(double media){
            string situacao="";
            if(media>=6){
                situacao="Aprovado";
            }else{
                situacao="Reprovado";
            }
            return situacao;
        }
    //mensagem
        public void mensagem(){
            double mediaCalculada = obterMedia();
            string resultadoSituacao = obterSituacao(mediaCalculada);
            Console.WriteLine(nome+"está "+ resultadoSituacao+" com média de: "+mediaCalculada);
        }
}