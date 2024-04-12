using System;

namespace ex
{
    class Carro
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public Carro(string nome, string modelo, int ano)
        {
            Nome = nome;
            Modelo = modelo;
            Ano = ano;
        }
    }
}
