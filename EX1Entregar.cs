/*
//PALOMA BEZERRA
Crie um programa que leia o nome de um usuário e exiba na tela duas linhas, 
a primeira contendo o texto "Olá" e a segunda linha contendo o nome do usuário
*/

using System;

class Program4 {
  public static void Main4 (string[] args) {

    Console.WriteLine("Digite seu nome: ");
    string nomeUsuario = Console.ReadLine();
    Console.WriteLine($"Olá \n{nomeUsuario}");
  }
}