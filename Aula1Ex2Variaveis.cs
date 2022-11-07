using System;

class Program3 {
  public static void Main3 (string[] args) {

    Console.WriteLine ("--- Valores Inteiros");

    int valorInteiro = 300;
    Console.WriteLine ("Int: "+valorInteiro);

    Console.WriteLine ("--- Valores Ponto Flutuante");
    float valorFloat = 3.4F; //colocar F para ele entender que é um float
    Console.WriteLine ("Float: "+valorFloat);

    double valorDouble = 5.2D; //o D é opcional
    Console.WriteLine ("Double: "+valorDouble);

    decimal valorDecimal = 25.8M; //o M é obrigatório
    Console.WriteLine ("Decimal: "+valorDecimal); 

    Console.WriteLine ("--- Variáveis de Texto");
    char valorChar = 'F';
    Console.WriteLine ("Char: "+valorChar);

    string valorTexto = "Ola tudo bem";
    Console.WriteLine ("Texto: "+valorTexto);

    Console.WriteLine ("--- Variáveis de Valor Lógico");
    bool valorBool = true;
    Console.WriteLine ("Bool: "+valorBool);

    //Ler uma string 
    Console.WriteLine ("Digite seu nome");
    string valorDigitado = Console.ReadLine();
    Console.WriteLine (valorDigitado);

  } 
}