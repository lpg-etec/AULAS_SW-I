using System.IO;

class main
{
    public static void Main(String[] args)
    {
        Conta c = new Conta(100, 1000, 5000);
        c.AjusteLimite(500);
        c.Depositar(100);
        c.Sacar(5500);
        Console.WriteLine($"Saldo: {c.ConsultaSaldo()}");
        c.Depositar(4000);
        Console.WriteLine($"Saldo: {c.ConsultaSaldo()}");
    }
}