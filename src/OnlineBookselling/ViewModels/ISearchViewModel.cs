using System.Collections.Generic;
using OnlineBookselling.Models;

namespace OnlineBookselling.ViewModels
{
    public interface ISearchViewModel
    {
        List<SearchProduct> Products { get; }
        string SearchTerm { get; set; }
    }

    public class SearchProduct
    {
        public SearchProduct(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            AuthorFullName = product.Author?.FullName;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string AuthorFullName { get; private set; }
    }
}
