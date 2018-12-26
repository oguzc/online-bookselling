using System.Collections.Generic;

namespace OnlineBookselling.ViewModels
{
    public interface ISearchViewModel
    {
        List<SearchProduct> Products { get; }
        string SearchTerm { get; set; }
    }

    public class SearchProduct
    {
        public SearchProduct(string name, string authorFullName)
        {
            Name = name;
            AuthorFullName = authorFullName;
        }

        public string Name { get; private set; }
        public string AuthorFullName { get; private set; }
    }
}
