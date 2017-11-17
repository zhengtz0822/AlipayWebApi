using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDemoContract.Models;

namespace WebApiDemoContract.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Product

            Product[] products = new Product[]
            {
            new Product { Id = 1, Name = "neo.zheng", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "jack.liu", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
            };
            public void Product()
            {
                
            }
            public string GetAllProducts()
            {
            
                string url = Request.Content.ToString();
                return products.ToJson();
            }

            public IHttpActionResult GetProduct(int id)
            {
                var product = products.FirstOrDefault((p) => p.Id == id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
        
    }
}