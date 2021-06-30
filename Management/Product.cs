namespace Management {
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"id {Id}, name {Name}, price {Price}";
        }
    }
}