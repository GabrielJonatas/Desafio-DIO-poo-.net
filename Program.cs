using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero: "98710", modelo: "X12", imei: "1111119999900000", memoria: 128);

nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Iphone iphone = new Iphone(numero: "11990", modelo: "X25", imei: "5555588777999", memoria: 512);

iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();