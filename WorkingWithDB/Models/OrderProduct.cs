namespace WorkingWithDB.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public Order Order { get; set; } = new ();
        public int OrderId { get; set; }

        public Teapot Teapot { get; set; } = new ();
        public int TeapotId { get; set; }
    }
}
