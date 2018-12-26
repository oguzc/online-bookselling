using System;
using System.Collections.Generic;
using System.Linq;
using JsonFlatFileDataStore;
using OnlineBookselling.Models;

namespace OnlineBookselling.Repositories
{
    public class ProductRepository : IRepository<Product, int>
    {
        private readonly DataStore _store;
        private readonly IDocumentCollection<Product> _collection;

        private ProductRepository()
        {
            // Open database (create new if file doesn't exist)
            _store = new DataStore("products.json");

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

        public Product GetById(int id)
        {
            //var list = new List<Product> {
            //        new Product
            //        {
            //            Name = "Değirmen",
            //            Author = new Product.AuthorInfo {
            //                Name = "Sabahattin",
            //                Surname = "Ali"
            //            },
            //            Description = "İşte adaşım, sana seven bir Çingene''nin hikayesi. Çiçeklerin açtığı bir mevsimde, senin kollarına yaslanan ve çiçekler kadar güzel kokan bir vücutla uzak su kenarlarında oturtmak ve öpüşmek, yoruluncaya kadar öpüşmek hoş şeydir... Fakat sevgili bir vücutta bulunmayan bir şeyi kendisinde taşımaya tahammül etmeyerek onu koparıp atabilmek, işte adaşım, yalnız bu sevmektir.",
            //            ProductType = ProductType.Book,
            //        },
            //        new Product
            //        {
            //            Name = "Kürk Mantolu Madonna",
            //            Author = new Product.AuthorInfo {
            //                Name = "Sabahattin",
            //                Surname = "Ali"
            //            },
            //            Description = "Her gün, daima öğleden sonra oraya gidiyor, koridorlardaki resimlere bakıyormuş gibi ağır ağır, fakat büyük bir sabırsızlıkla asıl hedefine varmak isteyen adımlarımı zorla zapt ederek geziniyor, rastgele gözüme çarpmış gibi önünde durduğum Kürk Mantolu Madonnayı seyre dalıyor, ta kapılar kapanıncaya kadar orada bekliyoKimi tutkular rehberimiz olur yaşam boyunca. Kollarıyla bizi sarar. Sorgulamadan peşlerinden gideriz ve hiç pişman olmayacağımızı biliriz. Yapıtlarında insanların görünmeyen yüzlerini ortaya çıkaran Sabahattin Ali, bu kitabında güçlü bir tutkunun resmini çiziyor. Düzenin sildiği kişiliklere, yaşamın uçuculuğuna ve aşkın olanaksızlığına (?) dair, yanıtlanması zor sorular soruyor.",
            //            ProductType = ProductType.Book
            //        },
            //        new Product
            //        {
            //            Name = "Sol Ayağım",
            //            Author = new Product.AuthorInfo {
            //                Name = "Christy",
            //                Surname = "Brown"
            //            },
            //            Description = "İrlandalı yazar Christy Brown’un 1954 yılında kaleme aldığı ve dünyanın en iyi otobiyografi kitaplarından biri olarak kabul edilen Sol Ayağım, aynı zamanda bir kişisel gelişim kitabı olma özelliği taşıyor. Christy Brown kendi otobiyografisini yazdığı bu kitapta, sol ayağıyla kalem tutmayı nasıl başardığını, anne ve babasının yardımıyla hayata nasıl tutunduğunu, karşısındaki tüm engelleri nasıl aştığını anlatıyor. Sunday Times’ın “Erdemli ve hiçbir şekilde yozlaştırılmamış bir cesaret hikâyesi” olarak vurguladığı kitap, çok satanlar listesinde uzun dönem kalmayı başarıyor.",
            //            ProductType = ProductType.Book
            //        },
            //        new Product
            //        {
            //            Name = "Kitap Ayracı Mavi",
            //            ProductType = ProductType.Bookmark
            //        },
            //        new Product
            //        {
            //            Name = "Kitap Ayracı Siyah",
            //            ProductType = ProductType.Bookmark
            //        }
            //    };
            //_collection.InsertMany(list);
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
            searchTerm = searchTerm.ToLower();
            return _collection
                .AsQueryable()
                .Where(_ =>  _.Name.ToLower().Contains(searchTerm) ||
                            (_.Author != null && _.Author.FullName.ToLower().Contains(searchTerm))
                ).ToList();
        }
    }
}
