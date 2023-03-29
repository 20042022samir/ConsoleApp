using ConsoleApp.Core.IRepositery;
using ConsoleApp.Core.IRepositery.ISopRepositery;
using ConsoleApp.Core.IRepositery.Main;
using ConsoleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data.Repository.ProductRepo
{
    public class ProductRepo<L> : Repositery<Product>,IProductt<Product>
    {
       
    }
}
