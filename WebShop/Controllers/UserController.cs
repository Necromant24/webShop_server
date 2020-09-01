using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.DB;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        private readonly ShopDBContext _dbContext;

        public UserController(ShopDBContext dbContext)
        {
            _dbContext = dbContext;
            if (_dbContext == null)
            {
                Console.WriteLine("ah shit! here we try again!");
            }
            else
            {
                Console.WriteLine("inited context successfully! "+_dbContext.ToString());
            }
        }

        [HttpGet]
        public IEnumerable<ViewedUser> Get([FromQuery]int min,[FromQuery]int max)
        {
            IEnumerable<ViewedUser> viewedUsers;
            if (min < max)
            {
                viewedUsers = _dbContext.Users
                    .Where(user => (user.Id > min) && (user.Id < max))
                    .Select(user=>new ViewedUser(user));
            }
            else
            {
                viewedUsers = _dbContext.Users
                    .Select(user=>new ViewedUser(user));
            }
            return viewedUsers;
        }

        [HttpPut]
        public async Task<ActionResult<string>> Put([FromBody]User user)
        {
            string status = "ok";

            _dbContext.Users.Add(user);
            int i = await _dbContext.SaveChangesAsync();
            
            return status;
        }
        
    }
}