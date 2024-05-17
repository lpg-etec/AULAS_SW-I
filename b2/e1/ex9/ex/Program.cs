using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Livro livro1 = new Livro("Dom Quixote", "Miguel de Cervantes");
                Console.WriteLine($"Livro: {livro1.Titulo}, Autor: {livro1.Autor}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar livro: {ex.Message}");
            }

            try
            {
                Livro livro2 = new Livro("", "J.K. Rowling");
                Console.WriteLine($"Livro: {livro2.Titulo}, Autor: {livro2.Autor}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar livro: {ex.Message}");
            }
        }
    }
}
