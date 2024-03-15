class Conta
{
    private int Id { get; set; }
    private float Limite { get; set; }
    private float Saldo { get; set; }
    //private string Nome { get; set; }

    public Conta(int c, float l, float s)
    {
        this.Id = c;
        this.Limite = l;
        this.Saldo = s;
    }
    public float ConsultaSaldo()
    {
        return this.Saldo;
    }
    public float Sacar(float num)
    {
        float diff = this.Saldo + this.Limite - num;
        if (diff < 0)
        {
            return 0;
        }
        this.Saldo -= num;
        return this.Saldo;
    }
    public float Depositar(float num)
    {
        this.Saldo += num;
        return this.Saldo;
    }
    public float AjusteLimite(float num)
    {
        this.Limite = num;
        return this.Limite;
    }
}       