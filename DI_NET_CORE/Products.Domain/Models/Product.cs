using Products.Domain.Models.Abstract;

namespace Products.Domain.Models
{
    public class Product : IProduct
    {
        public int Id {get; private set;}

        public string Name { get; private set; }

        public Product(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
