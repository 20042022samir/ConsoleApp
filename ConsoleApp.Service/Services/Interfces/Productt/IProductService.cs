using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Service.Services.Interfces.Productt
{
    public interface IProductService
    {
        public void Create();

        public void Update();

        public void Delete();

        public void GetAll();
    }
}
