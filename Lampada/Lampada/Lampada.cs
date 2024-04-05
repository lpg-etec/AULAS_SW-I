using System;

namespace ProjetoLampada
{
    public class Lampada
    {
        private bool ligada { get; set; }
        private int potencia { get; set; }
        private string cor { get; set; }

        public Lampada(bool l, int p, string c)
        {
            this.ligada = l;
            this.potencia = p;
            this.cor = c;
        }

        public void ligar()
        {
            this.ligada = true;
        }
        public void desligada()
        {
            this.ligada = false;
        }
        public bool estaLigado()
        {
            return this.ligada;
        }
    }
}