using System.Collections.Generic;

namespace OnlineBookselling.ViewModels
{
    public class NullSearchViewModel : ISearchViewModel
    {
        public List<SearchProduct> Products => new List<SearchProduct>();

        public string SearchTerm { get => string.Empty; set => SearchTerm = string.Empty; }
    }
}
