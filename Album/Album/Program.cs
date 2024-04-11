using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album(5, 2);
            Console.WriteLine($"{album.NumeroDeFotos}");
            Album album1 = new Album(5, 2);
            album1.NumeroDeFotos = 6;
            Console.WriteLine($"{album1.NumeroDeFotos}");
        }
    }
}