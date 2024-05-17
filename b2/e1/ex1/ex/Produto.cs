namespace ex
{
    class Produto
    {
        public string name;
        public double preco;
        public int quantidade;

        public Produto(string name, double preco, int quantidade)
        {
            this.name = name;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public void adicionar(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void remover(int quantidade)
        {
            this.quantidade -= quantidade;
        }
    }
}