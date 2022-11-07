class Program7 {
  public static void Main7 (string[] args) {

    // Console.WriteLine ("--- Data");

    // DateTime dataHoje = new DateTime(2022,11,05);

    // Console.WriteLine ("Data: "+dataHoje);

    // DateTime dataHoje2 = new DateTime(2022,11,05,19,28,33);
    
    // Console.WriteLine ("Data2: "+dataHoje2);

    // DateTime dataHoje3 = DateTime.Now;
    
    // Console.WriteLine ("Data3: "+dataHoje3);

    // Console.WriteLine("ANO: "+dataHoje3.Year);

    // Console.WriteLine("DATA SEM HORAS: "+dataHoje3.ToShortDateString());

    // Console.WriteLine("HORA SEM DATA: "+dataHoje3.ToShortTimeString());

    // Console.WriteLine("Adicionando 5 dias: "+dataHoje2.AddDays(5));

    // Console.WriteLine("Hora: "+dataHoje2.Hour);

    // Console.WriteLine("Dia do ano: "+dataHoje2.DayOfYear);

    // var nome2 = "paloma"; //programa subentende o tipo utilizando var 

    // Console.WriteLine("Var: "+nome2);

    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();
  
    string frase1 = "Oi "+nome+ " seja bem-vinda";
    Console.WriteLine(frase1);

    string frase2 = string.Format("Oi {0} seja bem-vinda",nome);
    Console.WriteLine(frase2);

    string frase3 = $"Oi {nome} seja bem-vinda";
    Console.WriteLine(frase3);

  }
}