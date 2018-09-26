using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Products _prod = new Products();

            foreach (var item in _prod.categories)
            {
              Console.WriteLine(string.Concat(item.catId," ", item.catDes));
            }
            foreach (var item in _prod.products)
            {
                Console.WriteLine(string.Concat(item.price," ", item.proDescription," ", item.quantity," ", item.productID));
            }

            foreach (var item in _prod.products)
            {
                if (item.quantity <= 100)
                    Console.WriteLine(string.Concat(item.proDescription));
            }

            foreach (var item in _prod.products)
            {
                Console.WriteLine(string.Concat(item.proDescription, " ", item.price));
            }

            var ProdHardware = (from p in _prod.products
                                join s in _prod.categories
                                on p.proCatId equals s.catId
                                where s.catDes == "Hardware"
                                select new {productDescription = p.proDescription,
                                catDescription = s.catDes});

            foreach (var item in ProdHardware)
            {
                Console.WriteLine("{0} {1}", item.productDescription, 
                                  item.catDescription);
            }

            var supParts = (from p in _prod.suppliers
                            join s in _prod.Supplierproducts
                            on p.suppID equals s.supID
                            join g in _prod.products
                            on s.supProID equals g.productID
                            select new { supname = p.suppName, proDes = g.proDescription});


            


            Console.ReadKey();
          
        }

    }

}
