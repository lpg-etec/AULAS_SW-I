namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Quadrado\n2: Retângulo");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Area a = new Area(n1, n2);
            string c = a.Base == a.Altura ? "Quadrado" : "Retângulo";
            Console.WriteLine($"{a.Base} * {a.Altura} = {a.Calcular()} ({c})");
            Console.WriteLine($"{a.MostrarDetalhes()}");

            Pessoa pessoa = new Pessoa("nome", "sexo", new DateTime());
            Console.WriteLine($"{pessoa.Nome} {pessoa.Sexo}");

            Album album = new Album(5, 2);
            Console.WriteLine($"{album.NumeroDeFotos}");
            Album album1 = new Album(5, 2);
            album1.NumeroDeFotos = 6;
            Console.WriteLine($"{album1.NumeroDeFotos}");
        }
    }
}