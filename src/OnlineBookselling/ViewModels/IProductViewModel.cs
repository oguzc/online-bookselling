namespace OnlineBookselling.ViewModels
{
    public interface IProductViewModel
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        string AuthorFullName { get; }
    }
}
