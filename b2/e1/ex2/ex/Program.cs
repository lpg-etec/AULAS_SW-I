using System;
using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroDeCompras registro = new RegistroDeCompras();

            registro.AdicionarCompra(new DateTime(2024, 5, 17), "Item 1", 10.99);
            registro.AdicionarCompra(new DateTime(2024, 5, 18), "Item 2", 15.49);
            registro.AdicionarCompra(new DateTime(2024, 5, 19), "Item 3", 20.75);

            registro.ListarCompras();
        }
    }
}