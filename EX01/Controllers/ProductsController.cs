using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EX01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        static Products p1 = new Products { Name = "milk", Id = "123", Price = 5, Category = "A" };
        static Products p2 = new Products { Name = "candies", Id = "432", Price = 21, Category = "B" };
        static Products p3 = new Products { Name = "coffee", Id = "678", Price = 12, Category = "C" };

        private static readonly List<Products> ProductsList = new List<Products>() { p1, p2, p3 };






        [HttpGet("GetProductById{id}")]
        public ActionResult<Products> GetProductById(string id)
        {
            return Ok(ProductsList.Find(prod => prod.Id == id));
        }

        [HttpPost("CreateProduct")]
        public ActionResult<Products> CreateProduct(string id, string name, float price, string category)
        {
            Products p = new Products(id, name, price, category);
            ProductsList.Add(p);
            return Ok(p);
        }

        [HttpPut("UpdateProduct")]
        public ActionResult<Products> UpdateProduct(Products p)
        {
            Products p1 = ProductsList.Find(prod => prod.Id == p.Id);
            p1.Name = p.Name;
            p1.Price = p.Price;
            p1.Category = p.Category;
            return Ok(p1);

        }

        [HttpDelete("DeleteProduct{id}")]
        public ActionResult DeleteProduct(string id)
        {
            ProductsList.Remove(ProductsList.Find(prod => prod.Id == id));
            return Ok();
        }

        [HttpGet("SearchByName{name}")]
        public ActionResult <Products> SearchByName(string name)
        {
            return Ok(ProductsList.Find(prod => prod.Name == name));
        }

        [HttpGet("getByCategory{category}")]
        public ActionResult<List<Products>> getByCategory(string category)
        {
            return Ok(ProductsList.FindAll(prod => prod.Category == category));
        }

        [HttpGet("GetByPriceRange")]
        public ActionResult <List<Products>> GetByPriceRange([FromQuery]float min, [FromQuery]float max )
        {
            return Ok(ProductsList.FindAll(prod => prod.Price >= min && prod.Price <= max));
        }
    }
    
}
