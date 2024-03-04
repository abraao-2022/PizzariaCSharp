using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class BebidaController : ICrudController<Bebida>
    {
        private ICrudRepository<Bebida> _repositoryBebida;

        public BebidaController(ICrudRepository<Bebida> repositoryBebida)
        {
            _repositoryBebida = repositoryBebida;
        }

        public List<Bebida> ObterTodos()
        {
            return _repositoryBebida.ObterTodos();
        }

        public Bebida Obter(int id)
        {
            return _repositoryBebida.Obter(id);
        }

        public Bebida Adicionar(Bebida bebida)
        {
            return _repositoryBebida.Adicionar(bebida);
        }

        public void Deletar(int id)
        {
            _repositoryBebida.Deletar(id);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _repositoryBebida.Atualizar(bebida);
        }
    }
}