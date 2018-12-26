using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookselling.Models;

namespace OnlineBookselling.Repositories
{
    public class BookRepository : IRepository<Book, int>
    {
        private BookRepository() { }

        private static readonly Lazy<BookRepository> lazy =
            new Lazy<BookRepository>(() => new BookRepository());

        public static BookRepository Instance
        {
            get { return lazy.Value; }
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Delete(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
