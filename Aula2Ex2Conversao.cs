using System;

class Program6 {
  public static void Main6 (string[] args) {
    
    //Cast implicito
    double valor = 1.2;
    Console.WriteLine(valor);
    //Cast explicito
    int valorint = (int)10.7;
    Console.WriteLine(valorint);

    //Convert
    valorint = Convert.ToInt32("12");
    Console.WriteLine(valorint);

    //Parse
    valorint = int.Parse("17");
    Console.WriteLine(valorint);

    //TryParse variavel existente
    int.TryParse("23", out valorint);
    //TryParse nova variavel
    bool sucesso = int.TryParse("23", out int valorConvertido);
    Console.WriteLine("Conversao realizada com sucesso? "+sucesso);
  }
}