namespace OnlineBookselling.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public AuthorInfo Author { get; set; }

        public class AuthorInfo
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string FullName => $"{Name} {Surname}";
        }
    }
}
