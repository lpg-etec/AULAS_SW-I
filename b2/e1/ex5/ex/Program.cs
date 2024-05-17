using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            // Exemplo de uso
            gerenciador.AdicionarTarefa("Estudar para a prova", DateTime.Today.AddDays(2));
            gerenciador.AdicionarTarefa("Enviar relatório", DateTime.Today);
            gerenciador.AdicionarTarefa("Comprar leite", DateTime.Today.AddDays(1));

            Console.WriteLine("\nTarefas adicionadas:");
            gerenciador.ListarTarefas();

            gerenciador.RemoverTarefa("Enviar relatório");

            Console.WriteLine("\nTarefas após remover 'Enviar relatório':");
            gerenciador.ListarTarefas();

            gerenciador.VerificarTarefasParaHoje();
        }
    }
}