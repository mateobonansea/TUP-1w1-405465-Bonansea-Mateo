﻿using HotelBackEnd.Front.Implementation;
using HotelBackEnd.Front.Interface;
using HotelBackEnd.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteFront front;

        public  ClienteController()
        {
            front = new ClienteFront();
        }
        [HttpGet("/GetTipoDocumento")]
        public IActionResult GetTiposDocumento() {
        
            try
            {
                var result = front.GetTipoDocumento();
                if (result == null)
                {
                    return StatusCode(500, " Se produjo un error al buscar los tipos de documentos");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet("/GetTipoCliente")]
        public IActionResult GetTiposCliente() {

            try
            {
                var result = front.GetTipoCliente();
                if (result == null)
                {
                    return StatusCode(500, " Se produjo un error al buscar los tipos de clientes");
                }
                return Ok(result);

            }
            catch (Exception )
            {

                return StatusCode(500);
            }
        }

        [HttpGet("/GetClientesLista")]
        public IActionResult GetClientes()
        {
            try
            {
                var result = front.GetClientesLista();
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los clientes");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet("/GetClienteId")]
        public IActionResult GetClienteID(int id)
        {
            try
            {
                var result = front.GetClienteID(id);
                if (result == null)
                {
                    return StatusCode(500, "Se produjo un error al procesar los clientes");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost("/PostCliente")]
        public IActionResult PostCliente(ClienteModel cliente) {

            try
            {
                var result = front.AltaCliente(cliente);
                if (result == false)
                {
                    return StatusCode(500, " Se produjo un error al dar de alta un cliente");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost("/PostActualizarCliente")]
        
        public IActionResult ActualizarCliente(ClienteModel cliente)
        {
            try
            {
                var result = front.ActualizarCliente(cliente);
                if (result == false)
                {
                    return StatusCode(500, " Se produjo un error al actualizar un cliente");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpDelete("/DeleteCliente")]

        public IActionResult DeleteCliente(string numero)
        {

            try
            {

                var result = front.BajaCliente(numero);
                if (result == false)
                {
                    return StatusCode(500, " Se produjo un error al dar de baja un cliente");
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
