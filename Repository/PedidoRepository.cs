using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PedidoRepository : ICrudRepository<Pedido>
    {
        private List<Pedido> _pedidos;
        private int _ultimoId = 0;

        public PedidoRepository()
        {
            _pedidos = new List<Pedido>();
        }

        public Pedido Adicionar(Pedido pedido)
        {
            _ultimoId++;
            pedido.Id = _ultimoId;

            _pedidos.Add(pedido);

            return pedido;
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidos;
        }

        public Pedido Obter(int id)
        {
            return _pedidos
                        .Where(b => b.Id == id)
                        .FirstOrDefault();
        }

        public Pedido Atualizar(Pedido pedido)
        {
            var pedidoEncontrada = _pedidos.Where(b => b.Id == pedido.Id).FirstOrDefault();

            if (pedidoEncontrada == null)
            {
                throw new Exception("Não é possivel atualizar uma pedido que não existe");
            }

            _pedidos.Remove(pedidoEncontrada);
            _pedidos.Add(pedido);

            return pedido;
        }

        public void Deletar(int id)
        {
            var pedido = Obter(id);

            if (pedido == null)
            {
                throw new Exception("Não foi encontrada nenhuma pedido com o ID: " + id);
            }

            _pedidos.Remove(pedido);
        }

    }
}