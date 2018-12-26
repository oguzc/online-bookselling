namespace OnlineBookselling.Models
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface IProduct
    {
        int Id { get; }
        int Name { get; set; }
        double GetPrice();
    }
}
