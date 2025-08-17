using DesafioPOO.Models;

// Implementado: Realizar os testes com as classes Nokia e Iphone
Nokia celular = new Nokia("11 99643-7777", "Nokia 11", "1234", 1234);
Console.WriteLine("NOKIA");
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativo("Ifoood");

Iphone celular2 = new Iphone("11 99993-7777", "Iphone 11", "124", 124);
Console.WriteLine("IPHONE");
celular.Ligar();
celular.ReceberLigacao();
celular.InstalarAplicativo("Ifoood");