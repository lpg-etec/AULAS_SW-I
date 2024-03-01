using System;
using System.IO;

namespace ProjetoLampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp1 = new Lampada(false, 1000, "Vermelho");
            lamp1.ligar();
            Console.WriteLine($"ligada: {lamp1.estaLigado()}");
        }
    }
}