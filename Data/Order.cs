namespace ASPMMA.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatuses { get; set; }
        

        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        public ICollection<Product> Products { get; set; }

      
    }
}
