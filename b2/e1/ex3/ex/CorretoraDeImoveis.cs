namespace ex
{
    class CorretoraDeImoveis
    {
        private List<Imovel> imoveis;

        public CorretoraDeImoveis()
        {
            imoveis = new List<Imovel>();
        }

        public void InserirImovel(string endereco, double preco, string tipo)
        {
            Imovel novoImovel = new Imovel(endereco, preco, tipo);
            imoveis.Add(novoImovel);
        }

        public void AlterarPreco(string endereco, double novoPreco)
        {
            foreach (Imovel imovel in imoveis)
            {
                if (imovel.Endereco == endereco)
                {
                    imovel.Preco = novoPreco;
                    Console.WriteLine($"Preço do imóvel no endereço '{endereco}' alterado para {novoPreco:C}");
                    return;
                }
            }
            Console.WriteLine("Imóvel não encontrado.");
        }

        public void ListarImoveis()
        {
            Console.WriteLine("Lista de Imóveis:");
            foreach (Imovel imovel in imoveis)
            {
                Console.WriteLine($"Endereço: {imovel.Endereco}, Preço: {imovel.Preco:C}, Tipo: {imovel.Tipo}");
            }
        }

        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Não há imóveis disponíveis para calcular o valor médio.");
                return 0;
            }

            double totalPreco = 0;
            foreach (Imovel imovel in imoveis)
            {
                totalPreco += imovel.Preco;
            }

            return totalPreco / imoveis.Count;
        }
    }
}