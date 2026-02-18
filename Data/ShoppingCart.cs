namespace ASPMMA.Data
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
