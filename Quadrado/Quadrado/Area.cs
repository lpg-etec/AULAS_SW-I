using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado
{ 
    class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public Area(int lado, int altura) 
        {
            this.Base = lado;
            this.Altura = altura;
        }
        public int Calcular()
        {
            return this.Base * this.Altura;
        }
        public string MostrarDetalhes()
        {
            string c;
            if (this.Base == this.Altura)
            {
                c = "Quadrado";
            } else
            {
                c = "Retângulo";
            }
            return $"{this.Base} * {this.Altura} = {this.Calcular()} ({c})";
        }
    }
}
