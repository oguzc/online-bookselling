using System;
using System.Collections.Generic;
using System.Linq;
using JsonFlatFileDataStore;
using OnlineBookselling.Models;

namespace OnlineBookselling.Repositories
{
    public class ProductRepository : IRepository<Product, long>
    {
        private readonly DataStore _store;
        private readonly IDocumentCollection<Product> _collection;

        private ProductRepository()
        {
            // Open database (create new if file doesn't exist)
            _store = new DataStore("books.json");

            // Get employee collection
            _collection = _store.GetCollection<Product>();
        }

        private static readonly Lazy<ProductRepository> lazy =
            new Lazy<ProductRepository>(() => new ProductRepository());

        public static ProductRepository Instance
        {
            get { return lazy.Value; }
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(long id)
        {
            return _collection.AsQueryable().SingleOrDefault(_ => _.Id == id);
        }

        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string searchTerm)
        {
            return _collection
                .AsQueryable()
                .Where(_ =>  _.Name.Contains(searchTerm) ||
                            ((bool) _.Author?.FullName.Contains(searchTerm))
                ).ToList();
        }
    }
}
