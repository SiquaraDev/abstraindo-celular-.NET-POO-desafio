using DesafioPOO.Models;


Iphone iphone = new Iphone("912345678", "X", "LXK54", 8);
Nokia nokia = new Nokia("987654321", "4B", "HSC09", 4);

string app = "wpp";

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(app);

Console.WriteLine();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(app);

Console.WriteLine();