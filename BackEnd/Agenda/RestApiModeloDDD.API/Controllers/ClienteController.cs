using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTO;
using RestApiModeloDDD.Application.Interface;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            this.applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var clienteDTO = applicationServiceCliente.GetById(id);
            if (clienteDTO == null)
                return NotFound();
            return Ok(clienteDTO);
        }

        [HttpGet("Consulta/{cpf}")]
        public ActionResult<string> Consulta(string cpf)
        {
            var clienteDTO = applicationServiceCliente.GetById(5);
            if (clienteDTO == null)
                return NotFound();
            return Ok(clienteDTO);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                applicationServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                applicationServiceCliente.Update(clienteDTO);
                return Ok("Cliente Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                applicationServiceCliente.Remove(clienteDTO);
                return Ok("Cliente Removido com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}