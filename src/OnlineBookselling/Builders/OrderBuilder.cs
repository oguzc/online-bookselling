using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookselling.Models;

namespace OnlineBookselling.Builders
{
    public class OrderBuilder
    {
        private readonly Order order;

        public OrderBuilder()
        {
            order = new Order();
        }

        public Order Build()
        {
            return order;
        }


    }
}
