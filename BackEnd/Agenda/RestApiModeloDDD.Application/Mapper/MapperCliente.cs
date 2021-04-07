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
            if (clienteDTO == null)
                return null;
            return new Cliente()
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email,
                CPF = clienteDTO.CPF
            };
        }

        public ClienteDTO MapperEntityToDto(Cliente cliente)
        {
            if (cliente == null)
                return null;
            return new ClienteDTO()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email,
                CPF = cliente.CPF
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
