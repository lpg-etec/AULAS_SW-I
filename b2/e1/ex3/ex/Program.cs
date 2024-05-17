using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            CorretoraDeImoveis corretora = new CorretoraDeImoveis();
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Listar Todos os Imóveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Endereço do imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do imóvel: ");
                        string tipo = Console.ReadLine();
                        corretora.InserirImovel(endereco, preco, tipo);
                        break;
                    case "2":
                        Console.Write("Endereço do imóvel: ");
                        string enderecoAlterar = Console.ReadLine();
                        Console.Write("Novo preço do imóvel: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPreco(enderecoAlterar, novoPreco);
                        break;
                    case "3":
                        corretora.ListarImoveis();
                        break;
                    case "4":
                        double valorMedio = corretora.CalcularValorMedio();
                        Console.WriteLine($"O valor médio dos imóveis é: {valorMedio:C}");
                        break;
                    case "5":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                        break;
                }
            }
        }
    }
}