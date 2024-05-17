using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();

            // Exemplo de uso
            agenda.AdicionarContato("João", "123456789", "joao@email.com");
            agenda.AdicionarContato("Maria", "987654321", "maria@email.com");

            Console.WriteLine("\nContatos adicionados:");
            agenda.ListarContatos();

            agenda.RemoverContato("João");

            Console.WriteLine("\nContatos após remover João:");
            agenda.ListarContatos();

            Console.WriteLine("\nBuscando contato de Maria:");
            Contato contatoMaria = agenda.BuscarContato("Maria");
            if (contatoMaria != null)
            {
                Console.WriteLine($"Nome: {contatoMaria.Nome}, Telefone: {contatoMaria.Telefone}, Email: {contatoMaria.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }
}