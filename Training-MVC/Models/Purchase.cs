using System;

namespace Task_Web_Product.Models
{
    public class Purchase
    {
        public int id {get; set;}
        public string nama { get; set; }
        public string email {get; set;}
        public string phone_number {get; set;}
        public int totalPurchase {get; set;}
        public string payment_method {get; set;}
    }
}