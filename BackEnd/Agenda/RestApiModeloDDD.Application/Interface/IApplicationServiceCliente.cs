using RestApiModeloDDD.Application.DTO;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interface
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO clienteDTO);

        void Update(ClienteDTO clienteDTO);

        void Remove(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> GetAll();

        ClienteDTO GetById(int id);

        ClienteDTO GetByCPF(string cpf);
    }
}