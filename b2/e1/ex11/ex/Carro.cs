namespace ex
{
    class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        private int velocidade;

        public int Velocidade
        {
            get { return velocidade; }
            private set
            {
                if (value >= 0)
                {
                    velocidade = value;
                }
                else
                {
                    velocidade = 0;
                }
            }
        }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            Velocidade -= 10;
        }
    }
}
