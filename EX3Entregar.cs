/*
//PALOMA BEZERRA
Um comerciante comprou um produto e quer vende-lo com um lucro de 45% 
se o valor da compra for menor que R$20,00; caso contrário, o lucro será de 30%. 
Entrar como valor do produto e imprimir o valor da venda.*/

using System;

class Program10 {
  public static void Main10 (string[] args) {

    Console.WriteLine("Digite o valor do produto: ");
    double valorProduto = double.Parse(Console.ReadLine());

    if(valorProduto <= 20.00){
        double lucro45 = valorProduto*1.45;
        Console.WriteLine($"O valor com lucro de 45% é de {lucro45}");
    }
    else{
        double lucro30 = valorProduto*1.30;
        Console.WriteLine($"O valor com lucro de 30% é de {lucro30}");
    }
  }
}
