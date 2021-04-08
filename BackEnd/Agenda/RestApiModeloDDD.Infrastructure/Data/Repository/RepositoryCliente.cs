using RestApiModeloDDD.Core.Interface.Repository;
using RestApiModeloDDD.Domain.Entity;
using RestApiModeloDDD.Infrastructure.Data.Repository.EF;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repository
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public Cliente GetByCPF(string cpf)
        {
            return sqlContext.Clientes.Where(w => w.CPF == cpf).FirstOrDefault();
        }
    }
}