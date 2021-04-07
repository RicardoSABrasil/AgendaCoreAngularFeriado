using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Core.Interface.Service;
using RestApiModeloDDD.Domain.Entity;

namespace RestApiModeloDDD.Service
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }

        public Cliente GetByCPF(string cpf)
        {
            return this.repositoryCliente.GetByCPF(cpf);
        }
    }
}