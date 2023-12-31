using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product.Microservice.Data;

namespace Product.Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationDbContext _context;

        public ProductController(IApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Entities.Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChanges();
            return Ok(product.Id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            if (products == null) return NotFound();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _context.Products.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            await _context.SaveChanges();
            return Ok(product.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Entities.Product productData)
        {
            var product = _context.Products.Where(a => a.Id == id).FirstOrDefault();

            if (product == null) return NotFound();
            else
            {
                product.Name = productData.Name;
                product.Rate = productData.Rate;
                await _context.SaveChanges();
                return Ok(product.Id);
            }
        }
    }
}