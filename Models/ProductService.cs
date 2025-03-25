using ProjetoAPI.Models.Exceptions;

namespace ProjetoAPI.Models
{
    public class ProductService
    {
        public List<Product> Products = new List<Product>();

        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public List<Product> ListProducts()
        {
            return Products;
        }

        public Product SearchProducById(int id)
        {
            Product p = Products.Find(x => x.Id == id);

            if (p == null)
            {
                throw new DomainException("Product not found!");
            }
            return p;            
        }

        public void SetProductInactive(int codigo)
        {
            Product p = SearchProducById(codigo);
            p.SetInactive();
        }



    }
}
