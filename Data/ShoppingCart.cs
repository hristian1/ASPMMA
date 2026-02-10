namespace ASPMMA.Data
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<ShoppingCartItem> Items { get; set; }
    }
}
