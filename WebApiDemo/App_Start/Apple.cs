namespace WebApiDemo
{
    public class Apple : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Tag { get; set; }
    }
}
