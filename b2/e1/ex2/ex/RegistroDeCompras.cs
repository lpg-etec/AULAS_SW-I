namespace ex
{
    class RegistroDeCompras
    {
        public List<(DateTime data, string produto, double valor)> compras;

        public RegistroDeCompras()
        {
            compras = new List<(DateTime, string, double)>();
        }

        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            compras.Add((data, produto, valor));
        }

        public void ListarCompras()
        {
            foreach (var compra in compras)
            {
                Console.WriteLine($"{compra.data} {compra.produto} {compra.valor}");
            }
        }
    }
}