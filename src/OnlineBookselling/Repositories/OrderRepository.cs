using System;
using System.Collections.Generic;
using System.Linq;
using JsonFlatFileDataStore;
using OnlineBookselling.Models;

namespace OnlineBookselling.Repositories
{
    public class OrderRepository : IRepository<Order, int>
    {
        private readonly DataStore _store;
        private readonly IDocumentCollection<Order> _collection;

        private OrderRepository()
        {
            // Open database (create new if file doesn't exist)
            _store = new DataStore("orders.json");

            // Get employee collection
            _collection = _store.GetCollection<Order>();
        }

        private static readonly Lazy<OrderRepository> lazy =
            new Lazy<OrderRepository>(() => new OrderRepository());

        public static OrderRepository Instance
        {
            get { return lazy.Value; }
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            return _collection.AsQueryable().SingleOrDefault(_ => _.Id == id);
        }

        public Order Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetByUserId(int userId)
        {
            return _collection.AsQueryable().Where(_ => _.UserId == userId).ToList();
        }
    }
}
