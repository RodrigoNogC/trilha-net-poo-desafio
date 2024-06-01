using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DesafioPOO.Models;
public abstract class Smartphone
{
    protected string _numero;
    protected int _armazenamento;
    protected int _bateria;

    public Smartphone(string numero, int armazenamento, int bateria)
    {
        _numero = numero;
        _armazenamento = armazenamento;
        _bateria = bateria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string aplicativo);
} 
