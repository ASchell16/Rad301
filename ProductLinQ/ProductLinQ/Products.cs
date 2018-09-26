using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinQ
{
    public class Products
    {
        public List<Product> products = new List<Product>
        {
            new Product { productID = 1,
                         proDescription = "9'' nails",
                         price = 0.10f,
                         quantity = 200, proCatId = 1},
            new Product { productID = 2,
                          proDescription = "9'' Bolts",
                          price = 0.20f,
                          quantity = 120, proCatId = 1},
            new Product { productID = 3,
                          proDescription = "Chimney Hoover",
                          price = 100.50f,
                          quantity = 10, proCatId = 2},
            new Product { productID = 4,
                          proDescription = "Washing Machine",
                          price = 399.99f,
                          quantity = 7, proCatId = 2}

        };

        public List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier {suppID = 1,
                          suppName = "parts 1",
                          address1 = "Addr11",
                          address2 = "Addr21"
                         },
            new Supplier {suppID = 2,
                          suppName = "parts 2",
                          address1 = "Addr11",
                          address2 = "Addr21"
                        }
        };

        public List<Category> categories = new List<Category>
        {
            new Category {catId = 1,
                          catDes = "Hardware" },
            new Category {catId = 2,
                          catDes = "Electrical Appliences"}
        };

        public List<SupplierProduct> Supplierproducts = new List<SupplierProduct>
        {
            new SupplierProduct {supID = 1, supProID = 1, dateSupplied = DateTime.Parse("12/12/2012") },
            new SupplierProduct {supID = 1, supProID = 2, dateSupplied = DateTime.Parse("06/01/2013") },
            new SupplierProduct {supID = 2, supProID = 3, dateSupplied = DateTime.Parse("09/09/2017") },
            new SupplierProduct {supID = 2, supProID = 4, dateSupplied = DateTime.Parse("10/09/2017") }
        };
    }



   

    public class Product
        {
            public int productID { get; set; }
            public string proDescription { get; set; }
            public int quantity { get; set; }
            public float price { get; set; }
            
            public int proCatId { get; set; }

        }

        public class Supplier
        {
            public int suppID { get; set; }
            public string suppName { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
        }

        public class Category
        {
            public int catId { get; set; }
            public string catDes { get; set; }
        }

        public class SupplierProduct
        {
            public int supID { get; set; }
            public int supProID { get; set; }
            public DateTime dateSupplied { get; set; }

        }

       
}

