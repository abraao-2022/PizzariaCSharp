using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        private List<Cliente> _clientes;
        private int _ultimoId = 0;

        public ClienteRepository()
        {
            _clientes = new List<Cliente>();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            _ultimoId++;
            cliente.Id = _ultimoId;

            _clientes.Add(cliente);

            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }

        public Cliente Obter(int id)
        {
            return _clientes
                        .Where(b => b.Id == id)
                        .FirstOrDefault();
        }

        public Cliente Atualizar(Cliente cliente)
        {
            var clienteEncontrada = _clientes.Where(b => b.Id == cliente.Id).FirstOrDefault();

            if (clienteEncontrada == null)
            {
                throw new Exception("Não é possivel atualizar uma cliente que não existe");
            }

            _clientes.Remove(clienteEncontrada);
            _clientes.Add(cliente);

            return cliente;
        }

        public void Deletar(int id)
        {
            var cliente = Obter(id);

            if (cliente == null)
            {
                throw new Exception("Não foi encontrada nenhuma cliente com o ID: " + id);
            }

            _clientes.Remove(cliente);
        }

    }
}