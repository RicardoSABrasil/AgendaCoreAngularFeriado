using RestApiModeloDDD.Application.DTO;
using RestApiModeloDDD.Application.Interface;
using RestApiModeloDDD.Application.Interface.Mapper;
using RestApiModeloDDD.Core.Interface.Service;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDTO clienteDTO)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDTO);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClientesDTO(clientes);
        }

        public ClienteDTO GetByCPF(string cpf)
        {
            var clienteDTO = serviceCliente.GetByCPF(cpf);
            return mapperCliente.MapperEntityToDto(clienteDTO);
        }

        public ClienteDTO GetById(int id)
        {
            var clienteDTO = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(clienteDTO);
        }

        public void Remove(ClienteDTO clienteDTO)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDTO);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDTO clienteDTO)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDTO);
            serviceCliente.Update(cliente);
        }
    }
}