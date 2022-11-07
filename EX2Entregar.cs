/*
//PALOMA BEZERRA
Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno 
foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7,
solicitar a nota do recuperação, somar com o valor da média e obter a nova média. Se a nova média for
maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na recuperação. 
Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição. 
Apresentar junto com as mensagens o valor da média do aluno.*/

using System;

class Program5 {
  public static void Main5 (string[] args) {

    Console.WriteLine("Digite a primeira nota: ");
    double nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota: ");
    double nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a terceira nota: ");
    double nota3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quarta nota: ");
    double nota4 = double.Parse(Console.ReadLine());
    
    Double media = (nota1+nota2+nota3+nota4)/4;

    if(media >= 7){
        Console.WriteLine($"Você está aprovado! Com nota a {media}");
    }
    else{
        Console.WriteLine($"Sua nota foi {media}, você está de recuperação");
        Console.WriteLine("Digite a nota de recuperacao: ");
        double notaRecuperacao = double.Parse(Console.ReadLine());

        double notaFinal = (media+notaRecuperacao)/2;

        if(notaFinal >= 7){
            Console.WriteLine($"Você está aprovado! Com nota a {notaFinal}");
        }
        else{
            Console.WriteLine($"Você tirou a nota {notaFinal} , infelizmente você está reprovado.");
        }

    }
  }
}