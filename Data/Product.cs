namespace ASPMMA.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }

        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public string ImageUrl { get; set; }


        public int CategoryId { get; set; }
        public Category Categorys { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ShoppingCartId { get; set; } 
        public ShoppingCart ShoppingCarts { get; set; }

        public int OrderId { get; set; }
        public Order Orders { get; set; }

 
    }
}
