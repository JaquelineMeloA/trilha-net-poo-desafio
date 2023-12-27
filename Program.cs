using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo Smart", imei: "41558755", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "4521", modelo: "Modelo Premium", imei: "415587155", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");