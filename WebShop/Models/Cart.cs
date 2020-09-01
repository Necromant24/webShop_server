namespace WebShop
{
    public class Cart
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        // count of god in cart
        public int Count { get; set; }
        
    }
}