using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab4
{
    internal class Brand
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
    class test
    {
        static void Main(string[] args)
        {
            var brands = new List<Brand>()
            {
                new Brand { ID = 1, Name = "Cong ty A" },
                new Brand { ID = 2,Name = "Cong ty B"},
                new Brand { ID = 3,Name = "Cong ty C"}
            };
            var products = new List<Product>()
            {
                new Product(1, "AcerNitro5", 1500, new string[] {"Den","Xam"}, 2),
                new Product(1, "Legion5", 2000, new string[] {"Trang","Xam"}, 1),
            };

            var rs = from product in products
                     join brand in brands on product.Brand equals brand.ID
                     select new
                     {
                         name = product.Name,
                         brand = product.Brand,
                         price = product.Price
                     };

            foreach (var item in rs)
            {
                Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            }

            /*  var rs1 = from product in products
                        join brand in brands on product.Name equals brand.ID into t
                        from brand in t.DefaultEmpty()
                        select new {
                          name = product.Name
                        }*/
        }
    }
}