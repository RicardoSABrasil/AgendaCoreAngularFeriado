using RestApiModeloDDD.Application.DTO;
using RestApiModeloDDD.Application.Interface.Mapper;
using RestApiModeloDDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        private IEnumerable<ClienteDTO> clientesDTO = new List<ClienteDTO>();

        public Cliente MapperDtoToEntity(ClienteDTO clienteDTO)
        {
            return new Cliente()
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email
            };
        }

        public ClienteDTO MapperEntityToDto(Cliente cliente)
        {
            return new ClienteDTO()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };
        }

        public IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes)
        {
            var clienteDTOs = new List<ClienteDTO>();
            foreach (var cliente in clientes)
            {
                clienteDTOs.Add(MapperEntityToDto(cliente));
            }
            return clienteDTOs;
        }
    }
}
