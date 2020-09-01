namespace WebShop
{
    public class ViewedUser
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public ViewedUser(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
        }
    }
}