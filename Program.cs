using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Nokia nokia = new Nokia ("(11) 9876-6546", "C21 Plus", "12356709", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone ("11 9768-0921", "13 Pro", "67895408", 256);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");