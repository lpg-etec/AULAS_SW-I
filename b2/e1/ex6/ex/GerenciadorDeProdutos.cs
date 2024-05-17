namespace ex
{
    class GerenciadorDeProdutos
    {
        private List<Produto> produtos;

        public GerenciadorDeProdutos()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(int codigo, string nome, double preco)
        {
            Produto novoProduto = new Produto(codigo, nome, preco);
            produtos.Add(novoProduto);
            Console.WriteLine($"Produto '{nome}' adicionado com sucesso.");
        }

        public void ApresentarProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
            }
        }

        public Produto ConsultarProduto(int codigo)
        {
            return produtos.Find(p => p.Codigo == codigo);
        }
    }
}