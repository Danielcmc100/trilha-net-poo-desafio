using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("123456789", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia("987654321", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");