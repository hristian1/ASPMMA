namespace ASPMMA.Data
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCarts { get; set; }

        public int ProductId { get; set; }
        public Product Products { get; set; }

        public int Quantity { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
