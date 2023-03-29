using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static int _counter2 = 0;

        public Category category { get; set; }
        public Product()
        {
            _counter2++;
            Id = _counter2;
        }
    }
}
