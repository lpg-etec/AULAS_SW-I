using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeProdutos gerenciador = new GerenciadorDeProdutos();

            // Adicionando alguns produtos de exemplo
            gerenciador.AdicionarProduto(1, "Camisa", 25.99);
            gerenciador.AdicionarProduto(2, "Calça", 39.99);
            gerenciador.AdicionarProduto(3, "Tênis", 89.99);

            // Apresentando todos os produtos
            gerenciador.ApresentarProdutos();

            // Consultando um produto pelo código
            int codigoConsultado = 2;
            Produto produtoConsultado = gerenciador.ConsultarProduto(codigoConsultado);
            if (produtoConsultado != null)
            {
                Console.WriteLine($"\nProduto encontrado (Código {codigoConsultado}): {produtoConsultado.Nome}, Preço: {produtoConsultado.Preco:C}");
            }
            else
            {
                Console.WriteLine($"\nProduto com código {codigoConsultado} não encontrado.");
            }
        }
    }
}