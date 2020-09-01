using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.DB;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController:ControllerBase
    {
        private readonly ShopDBContext _dbContext;

        public CartController(ShopDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public ActionResult<Cart> Get([FromQuery]int id)
        {
            var cart = _dbContext.Carts.Where(cart => cart.Id == id).Take(1).First();
            return cart;
        }

        [HttpPut]
        public async Task<ActionResult<string>> Put([FromBody]Cart cart)
        {
            _dbContext.Carts.Add(cart);
            await _dbContext.SaveChangesAsync();

            return "ok";
        }
        
        
        
        
    }
}