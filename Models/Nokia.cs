using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DesafioPOO.Models;
public class Nokia : Smartphone
{
    public Nokia(string numero, int armazenamento, int bateria) 
        : base(numero, armazenamento, bateria) { }

    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando aplicativo {aplicativo} no Nokia...");
    }
}