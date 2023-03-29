using ConsoleApp.Core.IRepositery;
using ConsoleApp.Core.IRepositery.Main;
using ConsoleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data.Repository
{
    public class Repositery<R> : Mainn<R>
    {
        static List<R> datas= new List<R>();   
        public void Create(R data1)
        {
            datas.Add(data1);
        }

        public void Delete(R data1)
        {
            datas.Remove(data1);
        }

        public R Get(Func<R, bool> expression)
        {
            R model=datas.FirstOrDefault(expression);
            return model;
        }

        

        public List<R> GetAll()
        {
            return datas;
        }

       public List<R> GetAll(Func<R, bool> expression)
        {
            List<R> FilteredList = datas.Where(expression).ToList();
            return FilteredList;
        }
    }
}
