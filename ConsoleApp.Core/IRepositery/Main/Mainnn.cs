using ConsoleApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core.IRepositery.Main
{
    public interface Mainn<W>
    {
        public void Create(W data1);

        public void Delete(W data1);
         
        public List<W> GetAll(Func<W,bool> expression);

        public W Get(Func<W,bool> func);

        public List<W> GetAll();
    }
}
