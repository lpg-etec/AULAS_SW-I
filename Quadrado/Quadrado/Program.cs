using System.IO;

namespace Quadrado
{
    class main 
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("1: Quadrado\n2: Retângulo");
            string op = Console.ReadLine();
            if (op == "1")
            {
                
            }
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Area a = new Area(n1, n2);
            string c = a.Base == a.Altura ? "Quadrado" : "Retângulo";
            Console.WriteLine($"{a.Base} * {a.Altura} = {a.Calcular()} ({c})");
            Console.WriteLine($"{a.MostrarDetalhes()}");
        }
    }
}