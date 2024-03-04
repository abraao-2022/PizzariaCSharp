using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        private List<Pizza> _pizzas;
        private int _ultimoId = 0;

        public PizzaRepository()
        {
            _pizzas = new List<Pizza>();
        }

        public Pizza Adicionar(Pizza pizza)
        {
            _ultimoId++;
            pizza.Id = _ultimoId;

            _pizzas.Add(pizza);

            return pizza;
        }

        public List<Pizza> ObterTodos()
        {
            return _pizzas;
        }

        public Pizza Obter(int id)
        {
            return _pizzas
                        .Where(b => b.Id == id)
                        .FirstOrDefault();
        }

        public Pizza Atualizar(Pizza pizza)
        {
            var pizzaEncontrada = _pizzas.Where(b => b.Id == pizza.Id).FirstOrDefault();

            if (pizzaEncontrada == null)
            {
                throw new Exception("Não é possivel atualizar uma pizza que não existe");
            }

            _pizzas.Remove(pizzaEncontrada);
            _pizzas.Add(pizza);

            return pizza;
        }

        public void Deletar(int id)
        {
            var pizza = Obter(id);

            if (pizza == null)
            {
                throw new Exception("Não foi encontrada nenhuma pizza com o ID: " + id);
            }

            _pizzas.Remove(pizza);
        }

    }
}