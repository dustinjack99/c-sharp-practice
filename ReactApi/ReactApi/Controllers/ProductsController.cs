using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReactApi.Models;

namespace ReactApi.Controllers
{
    public class ProductsController : ApiController
    {
        ProductModel[] products = new ProductModel[]
        {
            new ProductModel {ProductId = 1, ProductName = "TomatoSoup", ProductCategory = "Groceries", ProductPrice = 1},
            new ProductModel {ProductId = 2, ProductName = "Yo-yo", ProductCategory = "Toys", ProductPrice = 3.75M},
            new ProductModel {ProductId = 3, ProductName = "Hammer", ProductCategory = "Hardware", ProductPrice = 16.99M},
            new ProductModel {ProductId = 4, ProductName = "Sugar", ProductCategory = "Groceries", ProductPrice = 10},
            new ProductModel {ProductId = 5, ProductName = "Chhota-Beem", ProductCategory = "Toys", ProductPrice = 15},
             new ProductModel {ProductId = 6, ProductName = "Printer", ProductCategory = "Hardware", ProductPrice = 120},
        };

        public List<ProductModel> Get()
        {
            return products.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var product = products.Where(x => x.ProductId == id).ToList();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }

    //// GET: api/Products
    //public IEnumerable<string> Get()
    //    {
    //        return new string[] { "value1", "value2" };
    //    }

    //    // GET: api/Products/5
    //    public string Get(int id)
    //    {
    //        return "value";
    //    }

    //    // POST: api/Products
    //    public void Post([FromBody]string value)
    //    {
    //    }

    //    // PUT: api/Products/5
    //    public void Put(int id, [FromBody]string value)
    //    {
    //    }

    //    // DELETE: api/Products/5
    //    public void Delete(int id)
    //    {
    //    }
    //}
}
