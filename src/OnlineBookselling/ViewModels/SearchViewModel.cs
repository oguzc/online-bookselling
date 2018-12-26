using System.Collections.Generic;

namespace OnlineBookselling.ViewModels
{
    public class SearchViewModel : ISearchViewModel
    {
        public List<SearchProduct> Products { get; }

        public string SearchTerm { get; set; }
    }
}
