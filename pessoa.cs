using System;

//Classe Pessoa: Crie uma classe que modele uma pessoa:

//Atributos: nome, idade, peso e altura
//Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.

class Pessoa {
  private string nome;
  private double altura;
  private double peso; 
  private int idade;
  private double ganho;



  public void Perfil(string nome ,double altura,double peso,int idade) {
 
   Console.WriteLine("Nome:{0},Altura:{1},Peso:{2},Idade:{3}",nome,altura,peso,idade);
  }
  public void envelhecer(int i){
    if(idade < i){
      Console.WriteLine("Ficou mais velho");
    }

 }
  public void engordar(double p){
    if(p > peso)
      peso = p;
      Console.WriteLine("O seu peso atual é {0} ",peso);
   }
  public void emagrecer(double p2){
    if(p2 < peso)
      peso = p2;
      Console.WriteLine("O seu peso atual é {0} ",peso);

   }
  public void crescer(int idade,double altura)
  {
    for(int i = idade;idade < 21;idade++)
    {
    altura = altura + 0.05;
  }
     Console.WriteLine("Sua altura atual é {0} ",altura);

}
}