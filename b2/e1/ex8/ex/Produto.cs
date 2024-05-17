namespace ex
{
    class Produto
    {
        private string nome;
        private double preco;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do produto não pode ser vazio.");
                }
                nome = value;
            }
        }

        public Fabricante Fabricante { get; set; }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço do produto deve ser positivo.");
                }
                preco = value;
            }
        }

        public Produto(string nome, Fabricante fabricante, double preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preco = preco;
        }
    }
}
