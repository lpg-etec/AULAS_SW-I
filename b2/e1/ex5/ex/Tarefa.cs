namespace ex
{
    class Tarefa
    {
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string descricao, DateTime dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        public bool DeveExecutarHoje()
        {
            return DataVencimento.Date == DateTime.Today;
        }
    }
}