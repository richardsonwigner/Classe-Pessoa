using System;

class MainClass {
  public static void Main (string[] args) {
   Pessoa dados = new Pessoa();

   dados.Perfil("Richardson",1.8,60,17);
   dados.envelhecer(20);
   dados.engordar(80);
   dados.crescer(20,1.8);

}
}