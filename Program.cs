using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("1400", "14", "122222", 160);
iphone.Ligar();
Console.WriteLine("Iphone");
iphone.InstalarAplicativo("Spotify");

Console.WriteLine();

Nokia nokia = new Nokia("2000", "XYZ", "20000", 50);
nokia.Ligar();
Console.WriteLine("Nokia");
nokia.InstalarAplicativo("Youtube");
nokia.ReceberLigacao();