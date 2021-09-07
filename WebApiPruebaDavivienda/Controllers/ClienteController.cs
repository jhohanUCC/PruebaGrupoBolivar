using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPruebaDavivienda.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPruebaDavivienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContex applicationDb;
        public ClienteController(ApplicationDbContex applicationDbContex) {
            applicationDb = applicationDbContex;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            using (var contex = applicationDb)
            {
                return contex.Clientes.ToList();

            }
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {

            using (var contex = applicationDb)
            {
                return contex.Clientes.Where(c => c.IdTercero == id).FirstOrDefault();

            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            using (var contex = applicationDb)
            {
                contex.Clientes.Add(value);
                contex.SaveChanges();
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
            using (var contex = applicationDb)
            {
                var cliente = contex.Clientes.FirstOrDefault(c => c.IdTercero == id);
                cliente.Nombres = value.Nombres;
                cliente.Apellidos = value.Apellidos;
                contex.SaveChanges();
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var contex = applicationDb)
            {
                var cliente = contex.Clientes.FirstOrDefault(c => c.IdTercero == id);
                contex.Clientes.Remove(cliente);
                contex.SaveChanges();
            }
        }
    }
}
