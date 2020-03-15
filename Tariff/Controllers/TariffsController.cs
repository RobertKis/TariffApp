using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TariffApp.DAL;
using TariffApp.Models;
using Newtonsoft.Json.Linq;

namespace TariffApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffsController : ControllerBase
    {
        private readonly TariffContext _context;

        public TariffsController(TariffContext context)
        {
            _context = context;
        }
        
        [HttpPost("AddProduct/{request}")]
        public async Task<IActionResult> AddProduct([FromBody] Product request)
        {
            _context.Products.Add(request);

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.OrderBy(p => p.AnnualCost).ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
    }
}
