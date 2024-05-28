using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone("123123", "Modelo1", "11111", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Trello");

Console.WriteLine("\n");

Console.WriteLine("Smartphone nokia");
Smartphone nokia = new Nokia("5555555", "Modelo5", "55555", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Notion");

Console.WriteLine("\n");