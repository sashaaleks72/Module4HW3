namespace WorkingWithDB.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public User User { get; set; } = new ();
        public int UserId { get; set; }

        public OrderStatus OrderStatus { get; set; } = new ();
        public int OrderStatusId { get; set; }

        public List<OrderProduct> OrderProducts { get; set; } = new ();
    }
}
