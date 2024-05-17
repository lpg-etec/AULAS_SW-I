using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um fabricante
            Fabricante fabricante = new Fabricante("Acme Inc.", "123 Main St", "New York");

            // Criando um produto
            try
            {
                Produto produto = new Produto("Widget", fabricante, 19.99);
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:C}, Fabricante: {produto.Fabricante.Nome}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar produto: {ex.Message}");
            }

            // Tentando criar um produto com nome vazio
            try
            {
                Produto produtoInvalido = new Produto("", fabricante, 25.0);
                Console.WriteLine($"Produto: {produtoInvalido.Nome}, Preço: {produtoInvalido.Preco:C}, Fabricante: {produtoInvalido.Fabricante.Nome}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar produto: {ex.Message}");
            }

            // Tentando criar um produto com preço negativo
            try
            {
                Produto produtoPrecoNegativo = new Produto("Gadget", fabricante, -10.0);
                Console.WriteLine($"Produto: {produtoPrecoNegativo.Nome}, Preço: {produtoPrecoNegativo.Preco:C}, Fabricante: {produtoPrecoNegativo.Fabricante.Nome}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar produto: {ex.Message}");
            }
        }
    }
}
