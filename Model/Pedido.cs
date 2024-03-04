namespace PizzariaCSharp.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataEHora { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Bebida> Bebidas { get; private set; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Pizzas = new List<Pizza>();
            Bebidas = new List<Bebida>();
        }

        public Pedido AdicionarPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            return this;
        }

        public Pedido AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
            return this;
        }

        public double ObterValorTotal()
        {
            return 10;
        }

        public Pedido FinalizarPedido()
        {
            DataEHora = DateTime.Now;
            return this;
        }

    }
}