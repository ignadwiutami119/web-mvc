using System.Collections.Generic;

namespace Task_Web_Product.Models {
    public class Carts {
        public int id { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<Items> produk { get; set; }
    }
}