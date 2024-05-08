using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Infomações do Smartphone Nokia: ");

Nokia nokia1 = new Nokia(numero: "21966993198", modelo: "Xperia 3000", imei: "221133447788", memoria: 68);
nokia1.Ligar();
nokia1.InstalarAplicativo("Wpp");

Console.WriteLine(nokia1.Numero);

Console.WriteLine("Infomações do Smartphone Iphone: ");

Nokia iphone1 = new Nokia(numero: "21966993198", modelo: "Xperia 3000", imei: "221133447788", memoria: 68);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Wpp");

Console.WriteLine(iphone1.Numero);