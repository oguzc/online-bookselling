using OnlineBookselling.ViewModels;

namespace OnlineBookselling.Services
{
    public interface IProductService
    {
        IProductViewModel GetProduct(long productId);
        ISearchViewModel Search(string searchTerm);
    }
}
