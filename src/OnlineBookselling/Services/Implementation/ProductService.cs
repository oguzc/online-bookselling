using OnlineBookselling.Adapters;
using OnlineBookselling.ViewModels;
using OnlineBookselling.Repositories;

namespace OnlineBookselling.Services.Implementation
{
    public class ProductService : IProductService
    {
        public IProductViewModel GetProduct(int productId)
        {
            IProductViewModel productViewModel;
            var product = ProductRepository.Instance.GetById(productId);
            if (product == null)
            {
                productViewModel = new NullProductViewModel();
            }
            else
            {
                productViewModel = new ProductViewModelAdapter(product);
            }
            return productViewModel;
        }

        public ISearchViewModel Search(string searchTerm)
        {
            ISearchViewModel searchViewModel;
            var search = ProductRepository.Instance.Search(searchTerm);
            if (search == null)
            {
                searchViewModel = new NullSearchViewModel();
            }
            else
            {
                searchViewModel = new SearchViewModelAdapter(search);
            }
            return searchViewModel;
        }
    }
}
