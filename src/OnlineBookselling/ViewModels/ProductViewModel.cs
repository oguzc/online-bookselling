namespace OnlineBookselling.ViewModels
{
    public class ProductViewModel : IProductViewModel
    {
        public int Id { get; }

        public string Name { get; }

        public string Description { get; }

        public string AuthorFullName { get; }
    }
}
