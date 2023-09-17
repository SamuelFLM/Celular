


using Celular.Models;

Nokia nokia = new Nokia("98283942123", "Nokia 280 LF", "acb-232sdsak", 8);

nokia.Ligar();

nokia.InstalarAplicativo("Subway surf");

nokia.ReceberLigacao();

Console.WriteLine("\nPressione uma tecla para continuar.......");

Console.ReadKey();

Console.Clear();

Iphone iphone = new Iphone("23344321", "Iphone 15 Plus", "233123sk-awq", 8);


iphone.Ligar();

iphone.InstalarAplicativo("Instagram");

iphone.ReceberLigacao();