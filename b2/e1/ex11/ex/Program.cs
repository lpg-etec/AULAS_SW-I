using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Fusca", 1980);

            Console.WriteLine($"Velocidade inicial: {meuCarro.Velocidade}");

            meuCarro.Acelerar();
            Console.WriteLine($"Velocidade após acelerar: {meuCarro.Velocidade}");

            meuCarro.Frear();
            Console.WriteLine($"Velocidade após frear: {meuCarro.Velocidade}");

            // Tenta frear além da velocidade atual para garantir que não seja negativa
            for (int i = 0; i < 5; i++)
            {
                meuCarro.Frear();
            }
            Console.WriteLine($"Velocidade após frear além do limite: {meuCarro.Velocidade}");
        }
    }
}
