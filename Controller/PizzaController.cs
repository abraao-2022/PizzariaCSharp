using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
        private ICrudRepository<Pizza> _repositoryPizza;

        public PizzaController(ICrudRepository<Pizza> repositoryPizza)
        {
            _repositoryPizza = repositoryPizza;
        }

        public List<Pizza> ObterTodos()
        {
            return _repositoryPizza.ObterTodos();
        }

        public Pizza Obter(int id)
        {
            return _repositoryPizza.Obter(id);
        }

        public Pizza Adicionar(Pizza pizza)
        {
            return _repositoryPizza.Adicionar(pizza);
        }

        public void Deletar(int id)
        {
            _repositoryPizza.Deletar(id);
        }

        public Pizza Atualizar(int id, Pizza pizza)
        {
            pizza.Id = id;
            return _repositoryPizza.Atualizar(pizza);
        }
    }
}