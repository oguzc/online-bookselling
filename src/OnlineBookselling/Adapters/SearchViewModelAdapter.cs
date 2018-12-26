using System.Collections.Generic;
using System.Linq;
using OnlineBookselling.Models;
using OnlineBookselling.ViewModels;

namespace OnlineBookselling.Adapters
{
    public class SearchViewModelAdapter : ISearchViewModel
    {
        private readonly List<Product> products;

        public SearchViewModelAdapter(List<Product> products)
        {
            this.products = products;
        }

        public List<SearchProduct> Products => products.Select(product => new SearchProduct(product)).ToList();

        public string SearchTerm { get => string.Empty; set => SearchTerm = value; }
    }
}
