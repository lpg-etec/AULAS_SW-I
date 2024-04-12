using System;

namespace ex
{
    class Aviao
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int Capacidade { get; set; }
        public bool EmVoo { get; set; }

        public Aviao(string nome, string modelo, int capacidade, bool emVoo)
        {
            Nome = nome;
            Modelo = modelo;
            Capacidade = capacidade;
            EmVoo = emVoo;
        }
    }
}
