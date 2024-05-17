namespace ex
{
    class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa novaPessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(novaPessoa);
            Console.WriteLine("Pessoa adicionada à agenda.");
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoaParaRemover = pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (pessoaParaRemover != null)
            {
                pessoas.Remove(pessoaParaRemover);
                Console.WriteLine("Pessoa removida da agenda.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }
}
