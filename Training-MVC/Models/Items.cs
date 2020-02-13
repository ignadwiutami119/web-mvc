using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace Task_Web_Product.Models {
    public class Items {
        public int id { get; set; }
        public string title { get; set; }
        public int rate { get; set; }
        public int price { get; set; }
        public string desc { get; set; }
        public string image { get; set; }
        public int total { get; set; }

        [ForeignKey ("CartsID")]
        public int? CartsID { get; set; } = null;
        public Carts cart { get; set; }

        SqlConnection con = new SqlConnection ("Server=localhost\\SQLEXPRESS;Database=Store;Trusted_Connection=True;");
        SqlCommand cmd = new SqlCommand ();

        public string InsertItems (Items input) {
            cmd.CommandText = "Insert into [Items] values ('" + input.title + "','" + Convert.ToInt32(input.rate) + "','" + Convert.ToInt32(input.price) + "', '" + input.desc + "', '" + input.image +"')";
            cmd.Connection = con;
            try {
                con.Open ();
                cmd.ExecuteNonQuery ();
                con.Close ();
                return "Success";
            } catch (Exception e) {
                throw e;
            }
        }
    }
}