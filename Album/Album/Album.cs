using System;

namespace Program
{
    class Album
    {
        readonly int numeroTotalDePaginas = 2;
        int numeroTotalDeFotos;
        int numeroDeFotos;
        public int NumeroDeFotos
        {
            get { return numeroDeFotos; }
            set { if (value > numeroTotalDeFotos) { throw new IndexOutOfRangeException(); } }
        }
        public Album(int total, int numero)
        {
            this.numeroTotalDeFotos = total;
            this.numeroDeFotos = numero;
        }
    }
}
