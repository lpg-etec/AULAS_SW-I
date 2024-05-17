using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto("Carro", 16000, 5);
            Console.WriteLine($"{prod.name} {prod.preco} {prod.quantidade}");
            prod.remover(5);
            Console.WriteLine($"{prod.name} {prod.preco} {prod.quantidade}");
            prod.adicionar(2);
            Console.WriteLine($"{prod.name} {prod.preco} {prod.quantidade}");
        }
    }
}