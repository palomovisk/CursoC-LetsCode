using System;

class Program {
  public static void Main (string[] args) {


    // int[] vetorInteiro;
    // int[] vetorInteiro2 = new int[5];

    // vetorInteiro2[0]= 10;
    // vetorInteiro2[1]= 20;
    // vetorInteiro2[2]= 30;
    // vetorInteiro2[3]= 40;
    // vetorInteiro2[4]= 50;
    
    // vetorInteiro = new int[5];
    // vetorInteiro[0]= 10;
    // Console.WriteLine("Digite o valor do produto: ");

    // int[] vetorInteiro3 = new int[5] {1,2,3,4,5};

    // int[] vetorInteiro4 = {10,20,30,40,50,60};

     decimal[] notaAlunos = new decimal[4];
    // Console.WriteLine("Digite a nota 1: ");
    // notaAlunos[0] = decimal.Parse(Console.ReadLine());

    // Console.WriteLine("Digite a nota 2: ");
    // notaAlunos[1] = decimal.Parse(Console.ReadLine());

    // Console.WriteLine("Digite a nota 3: ");
    // notaAlunos[2] = decimal.Parse(Console.ReadLine());

    // Console.WriteLine("Digite a nota 4: ");
    // notaAlunos[3] = decimal.Parse(Console.ReadLine());

    // decimal notaFinal = (notaAlunos[0]+notaAlunos[1]+notaAlunos[2]+notaAlunos[3])/notaAlunos.Length;

    // Console.WriteLine("Media do aluno: "+notaFinal);
    decimal somanotas=0;
    for(int i=0; i<4; i++){
        Console.WriteLine($"Digite a nota {i+1}: ");
        notaAlunos[i] = decimal.Parse(Console.ReadLine());
        somanotas += notaAlunos[i];
    }
     decimal notaFinal = somanotas/(notaAlunos.Length);
     Console.WriteLine("Media do aluno: "+notaFinal);


  }
}
