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
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContex applicationDb;
        public ProductoController(ApplicationDbContex applicationDbContex)
        {
            applicationDb = applicationDbContex;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            using (var contex = applicationDb)
            {
                return contex.Productos.ToList();

            }
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            using (var contex = applicationDb)
            {
                return contex.Productos.Where(c => c.IdProducto == id).FirstOrDefault();

            }
        }

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] Producto value)
        {
            using (var contex = applicationDb)
            {
                contex.Productos.Add(value);
                contex.SaveChanges();
            }
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Producto value)
        {
            using (var contex = applicationDb)
            {
                var producto = contex.Productos.FirstOrDefault(c => c.IdProducto == id);
                producto.NombreProducto = value.NombreProducto;
                producto.PresioActual = value.PresioActual;
                producto.Stock = value.Stock;
                contex.SaveChanges();
            }
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var contex = applicationDb)
            {
                var producto = contex.Productos.FirstOrDefault(c => c.IdProveedor == id);
                contex.Productos.Remove(producto);
                contex.SaveChanges();
            }
        }
    }
}
