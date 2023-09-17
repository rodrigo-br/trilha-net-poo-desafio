using System;
using DesafioPOO.Models;

Smartphone nokia = new Nokia("1234", "Modelo 1", "11111aaaa", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Smartphone iphone = new Iphone("4321", "Modelo 2", "bbbb2222", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");