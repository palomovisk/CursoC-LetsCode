/*Exercicio: Crie um cadastro de uma biblioteca.
Leia os seguintes dados:
Título
Subtitulo
Autor
Editora
Número de páginas
Data de publicação
Idioma
Após receber os dados, limpe o console e exiba os dados na tela.

Altere o cadastro da biblioteca para exibir os dados na seguinte formatação:
    Livro cadastrada com sucesso!
    Livro: Titulo - Subtitulo
    Autor: Nome do autor
    Editora: Editora
    Detalhes: Publicado em 15/07/2001 com 99 páginas em Português.
*/

using System;

class Program8 {
  public static void Main8 (string[] args) {

    Console.WriteLine ("Digite o Titulo do Livro:");
    string tituloLivro = Console.ReadLine();
   
    System.Console.Write("Digite o Subtítulo do Livro: \n");
    string subtituloLivro = Console.ReadLine();

    System.Console.Write("Digite o Autor do Livro: \n");
    string autorLivro = Console.ReadLine();

    System.Console.Write("Digite a Editora do Livro: \n");
    string editoraLivro = Console.ReadLine();

    System.Console.Write("Digite o número de páginas do Livro: \n");
    int paginasLivro = int.Parse(Console.ReadLine());

    System.Console.Write("Digite a data de publicação do Livro: \n");
    DateTime datapublicacaoLivro = DateTime.Parse(Console.ReadLine());

    System.Console.Write("Digite o idioma do Livro: \n");
    string idiomaLivro = Console.ReadLine();
    
    Console.Clear();
    
    System.Console.Write("Livro cadastrado com sucesso! \n");
    System.Console.Write($"Livro: {tituloLivro} - {subtituloLivro}\n");
    System.Console.Write($"Autora: {autorLivro}\n");
    System.Console.Write($"Editora: {editoraLivro}\n"); 
    System.Console.Write($"Detalhes: Publicado em {datapublicacaoLivro.ToShortDateString} com {paginasLivro} em {idiomaLivro}.\n");
   
  }
}