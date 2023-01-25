using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiControlStock.Data;
using WebApiControlStock.Models;

namespace WebApiControlStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DBControlStockContext context;

        public ProductoController(DBControlStockContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return context.Productos.ToList();
        }
        [HttpPost]

        public ActionResult<Producto> Post(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Productos.Add(producto);
            context.SaveChanges();
            return Ok();
        }
    }
}
