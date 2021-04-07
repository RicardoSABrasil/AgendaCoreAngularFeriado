using RestApiModeloDDD.Domain.Entity;

namespace RestApiModeloDDD.Core.Interface.Repository
{
    public interface IRepositoryCliente : IRepositoryBase<Cliente>
    {
        Cliente GetByCPF(string cpf);
    }
}