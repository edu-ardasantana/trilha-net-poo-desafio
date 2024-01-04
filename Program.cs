using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero: "(99)9999-9999", modelo: "Modelo 1", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia(numero: "(88)8888-8888", modelo: "Modelo 2", imei: "222222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");