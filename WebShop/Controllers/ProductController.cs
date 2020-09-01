using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.DB;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly ShopDBContext _dbContext;
        public ProductController(ShopDBContext context)
        {
            _dbContext = context;
        }
        
        //var viewedProducts = products.Select(product => new ViewedProduct(product));
        // var products = _dbContext.Products.Where(product => product.Type1 == type1);
        // var conters = products.Select(product => product.ProductCounter);
        // List<ViewedProduct> viewedProducts = new List<ViewedProduct>();
        //
        // foreach (var counter in conters)
        // {
        //     Console.WriteLine(counter.Count+" -- curr count");
        //     //viewedProducts.Add(new ViewedProduct());
        // }

        [HttpGet]
        public IEnumerable<ViewedProduct> Get([FromQuery]string type1)
        {
            var products = _dbContext.Products
                .Where(product => product.Type1 == type1)
                .Include(product=>product.ProductCounter);
            
            var viewedProducts = products.Select(product => new ViewedProduct(product));
            
            return viewedProducts;
        }

        [Route("[controller]/cart")]
        [HttpGet]
        public IEnumerable<ViewedProduct> GetCartProducts([FromQuery]int[] idlist )
        {
            var list = new List<ViewedProduct>();
            foreach (var id in idlist)
            {
                list.Add(new ViewedProduct(_dbContext.Products.Find(id)));
            }
            
            return list;
        }
        
        

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody]Product product)
        {
            using (var reader = new StreamReader(Request.Body))
            {
                var body = reader.ReadToEndAsync();
                Console.WriteLine(body);
            }
            Console.WriteLine(" in creating product");
            Console.WriteLine(product);
            product.printThis();
            string status = "ok";
            _dbContext.Products.Add(product);
            int i = await _dbContext.SaveChangesAsync();

            return status;
        }
        
        
        
    }
}