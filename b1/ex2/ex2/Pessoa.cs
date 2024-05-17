using System;

namespace ex2
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }

        public Pessoa(string nome, string sexo, DateTime nascimento)
        {
            Nome = nome;
            Sexo = sexo;
            Nascimento = nascimento;
        }
    }
}
