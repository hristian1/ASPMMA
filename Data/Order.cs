namespace ASPMMA.Data
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }
      

        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
