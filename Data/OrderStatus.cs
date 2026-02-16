namespace ASPMMA.Data
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }

        public Order orders { get; set; }
    }
}
