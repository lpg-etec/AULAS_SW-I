namespace ex
{
    class AgendaTelefonica
    {
        private List<Contato> contatos;

        public AgendaTelefonica()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine($"Contato {nome} adicionado com sucesso.");
        }

        public void RemoverContato(string nome)
        {
            Contato contatoParaRemover = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contatoParaRemover != null)
            {
                contatos.Remove(contatoParaRemover);
                Console.WriteLine($"Contato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
        }

        public Contato BuscarContato(string nome)
        {
            return contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public void ListarContatos()
        {
            Console.WriteLine("Lista de Contatos:");
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}, Email: {contato.Email}");
            }
        }
    }
}