using ConsoleApp.Core.IRepositery.IcategoryRepositery;
using ConsoleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data.Repository.CategoryRepo
{
    public class CategoryRepoo:Repositery<Category>,ICategoryRepositery<Category>
    {
    }
}
