using System;

namespace ex2
{
    class Folha
    {
        public string Nome { get; set; }
        public int Salario { get; set; }
        public int HED { get; set; }
        public int HEN { get; set; }
        public int ND { get; set; }
        public int FAL { get; set; }
        public double Descontos { get; set; }
        public double Refeicao { get; set; }
        public double Vale { get; set; }
        public Folha(string nome, int salario, int hED, int hEN, int nD, int fAL, double descontos, double refeicao, double vale)
        {
            Nome = nome;
            HED = hED;
            HEN = hEN;
            ND = nD;
            FAL = fAL;
            Refeicao = refeicao;
            Vale = vale;
            Descontos = descontos;
            Salario = salario;
        }
    }
}
