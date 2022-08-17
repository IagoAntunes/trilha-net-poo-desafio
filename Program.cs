using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123","J8","123",16);
Iphone iphone = new Iphone("234","10","456",64);


nokia.InstalarAplicativo("Facebook");
nokia.Ligar();



iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();