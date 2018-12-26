namespace OnlineBookselling.ViewModels
{
    public class NullProductViewModel : IProductViewModel
    {
        public int Id => 0;

        public string Name => "Boyle bir urun yok!";

        public string Description => "Aradiginiz urun ne bulunamamistir..";

        public string AuthorFullName => string.Empty;
    }
}
