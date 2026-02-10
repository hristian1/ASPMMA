namespace ASPMMA.Data
{
    public class OrderHistory
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Orders { get; set; }

        public int StatusId { get; set; }
        public OrderStatus OrderStatuses { get; set; }

        public DateTime ChangeDate { get; set; }
        public string Note { get; set; }
    }
}
