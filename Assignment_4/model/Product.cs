using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4.model
{
    class Product
    {
        static List<Product> products = new List<Product>(); 
        public int Number { get; set; }
        public String Date { get; set; }
        public int InvNumber { get; set; }
        public String ObjName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public bool Availability { get; set; }

        public void Save()
        {
            //db connect if wanted 
            MessageBox.Show($"Product {ObjName} added ");
            products.Add(this);
        
        }
        public static List<Product> GetAllProducts()
        {
            return products;
        }


    }


}
