namespace PizzariaCSharp.Repository.Interfaces
{
    public interface ICrudRepository<T>
    {
        T Adicionar(T modelo);
        List<T> ObterTodos();
        T Obter(int id);
        T Atualizar(T modelo);
        void Deletar(int id);
    }
}