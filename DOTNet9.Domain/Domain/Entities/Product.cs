namespace DOTNet9API.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        private Product() { } // Required for ORM (EF Core)

        public Product(string name,string description ,decimal price, int stock)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            SetPrice(price);
            SetStock(stock);
        }

        public void SetPrice(decimal price)
        {
            if (price <= 0) throw new ArgumentException("Price must be greater than zero.");
            Price = price;
        }

        public void SetStock(int stock)
        {
            if (stock < 0) throw new ArgumentException("Stock cannot be negative.");
            Stock = stock;
        }

        public void UpdateDetails(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}
