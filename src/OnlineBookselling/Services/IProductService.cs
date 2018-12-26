using OnlineBookselling.ViewModels;

namespace OnlineBookselling.Services
{
    public interface IProductService
    {
        IProductViewModel GetProduct(int productId);
        ISearchViewModel Search(string searchTerm);
    }
}
