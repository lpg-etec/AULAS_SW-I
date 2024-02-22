using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada l1 = new Lampada();
            l1.Cor = "Azul";
            l1.Estado = true;
            l1.Potencia = 250;
            Console.WriteLine($"Cor: {l1.Cor}\nEstado: {l1.Estado}\nPotência: {l1.Potencia}");
        }
    }
}
