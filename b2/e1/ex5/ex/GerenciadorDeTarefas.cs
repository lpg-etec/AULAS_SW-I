namespace ex
{
    class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas;

        public GerenciadorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento);
            tarefas.Add(novaTarefa);
            Console.WriteLine($"Tarefa '{descricao}' adicionada com sucesso.");
        }

        public void RemoverTarefa(string descricao)
        {
            Tarefa tarefaParaRemover = tarefas.Find(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            if (tarefaParaRemover != null)
            {
                tarefas.Remove(tarefaParaRemover);
                Console.WriteLine($"Tarefa '{descricao}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa '{descricao}' não encontrada.");
            }
        }

        public void ListarTarefas()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
            }
        }

        public void VerificarTarefasParaHoje()
        {
            Console.WriteLine("Tarefas para hoje:");
            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.DeveExecutarHoje())
                {
                    Console.WriteLine($"Descrição: {tarefa.Descricao}, Data de Vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                }
            }
        }
    }
}