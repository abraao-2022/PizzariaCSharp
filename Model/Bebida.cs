namespace PizzariaCSharp.Model
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Bebida()
        {
        }

        public Bebida(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

    }

}