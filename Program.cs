using DesafioPOO.Models;
using System.Numerics;
using System;
using System.Linq;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n");
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "999999999", modelo: "Tijolo", imei: "111111111", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero: "998765432", modelo: "Iphone 5 Plus Holograma", imei: "123456789", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Disney+");