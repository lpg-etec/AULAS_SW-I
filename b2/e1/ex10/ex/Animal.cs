namespace ex
{
    class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public void EmitirSom()
        {
            Console.WriteLine($"O {Especie} {Nome} está emitindo um som...");
        }
    }
}
