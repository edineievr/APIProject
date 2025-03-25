using ProjetoAPI.Models.Exceptions;

namespace ProjetoAPI.Models
{
    public class Product
    {
        public bool Active { get; private set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public Product()
        {
            
        }

        public Product(int productId, string description, double quantity, double price)
        {
            Active = true;
            Id = productId;
            Description = description;
            
            if (quantity < 0.00)
            {
                throw new DomainException("Quantity must be higher than 0!");
            }
            else
            {
               Quantity = quantity;
            }

            if (price < 0.00)
            {
                throw new DomainException("Price must not be negative!");
            }
            else
            {
                Price = price;
            }
        }

        public void SetInactive()
        {
            Active = false;
        }

        public void SetActive()
        {
            Active = true;
        }
    }
}
