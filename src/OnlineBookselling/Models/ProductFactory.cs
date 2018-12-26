using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookselling.Models
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ProductFactory
    {
        public IProduct GetProduct(int productId)
        {
            IProduct product = null;
            switch (productId)
            {
                case "Rectangle":
                    product = new Book();
                    //products.Add("Rectangle", product);
                    break;
                case "Circle":
                    product = new Bookmark();
                    //products.Add("Circle", product);
                    break;
                default:
                    throw new Exception("Factory cannot create the object specified");
            }
            return product;
        }
    }
}
