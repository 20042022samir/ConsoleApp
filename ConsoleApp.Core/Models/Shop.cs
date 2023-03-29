using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int _counter3 = 0;

        public List<Product> Products;

        public Shop()
        {
            _counter3++;
            Id=_counter3    ;
            Products = new List<Product>();
        }
    }
}
