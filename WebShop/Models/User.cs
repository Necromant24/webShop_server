namespace WebShop
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string SocialMediaType { get; set; }
        public string SocialMediaReference { get; set; }

        public string fullName()
        {
            return FirstName + " " + LastName;
        }
        
    }
}