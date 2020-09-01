using System.Collections.Generic;

namespace WebShop
{
    // users list of products that he will buy
    public class UsersCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Cart> Carts { get; set; }
        
    }
}