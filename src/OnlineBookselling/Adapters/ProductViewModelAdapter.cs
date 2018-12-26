using OnlineBookselling.Models;
using OnlineBookselling.ViewModels;

namespace OnlineBookselling.Adapters
{
    public class ProductViewModelAdapter : IProductViewModel
    {
        private readonly Product product;

        public ProductViewModelAdapter(Product product)
        {
            this.product = product;
        }

        public string Name => product.Name;

        public string Description => product.Description;

        public string AuthorFullName => product.Author?.FullName;
    }
}
