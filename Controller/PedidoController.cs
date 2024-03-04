using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PedidoController : ICrudController<Pedido>
    {
        private ICrudRepository<Pedido> _repositoryPedido;

        public PedidoController(ICrudRepository<Pedido> repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
        }

        public List<Pedido> ObterTodos()
        {
            return _repositoryPedido.ObterTodos();
        }

        public Pedido Obter(int id)
        {
            return _repositoryPedido.Obter(id);
        }

        public Pedido Adicionar(Pedido pedido)
        {
            return _repositoryPedido.Adicionar(pedido);
        }

        public void Deletar(int id)
        {
            _repositoryPedido.Deletar(id);
        }

        public Pedido Atualizar(int id, Pedido pedido)
        {
            pedido.Id = id;
            return _repositoryPedido.Atualizar(pedido);
        }
    }
}