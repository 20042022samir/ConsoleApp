using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public class Category
    {
        public string name { get; set; }

        private static int _counter = 0;

        public int ID { get; set; }

        List<Product> Products;

        public Category()
        {
            _counter++;
            ID += _counter;
            Products= new List<Product>();
        }
    }
}
