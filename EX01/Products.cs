namespace EX01
{
    public class Products
    {
        public string  Id { get; set;}

        public string Name { get; set; }

       public float Price { get; set; }
        public string Category { get; set; }

        public Products(string id, string name, float price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
        public Products()
        {
            
        }
    }
}