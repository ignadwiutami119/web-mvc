using System.Collections.Generic;

namespace Task_Web_Product.Models {
    public class Carts {
        public int id { get; set; }
        public int total { get; set; }
        public int price { get; set; }
        public ICollection<Items> Product { get; set; }
    }
}