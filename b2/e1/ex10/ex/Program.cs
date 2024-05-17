using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal leao = new Animal("Simba", "Leão", 5);
            Animal macaco = new Animal("Mico", "Macaco", 3);

            leao.EmitirSom();
            macaco.EmitirSom();
        }
    }
}
