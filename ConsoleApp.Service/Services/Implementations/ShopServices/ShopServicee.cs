using ConsoleApp.Core.Models;
using ConsoleApp.Data.Repository;
using ConsoleApp.Data.Repository.ShopRepo.cs;
using ConsoleApp.Service.Services.Interfces.ShopServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Service.Services.Implementations.ShopServices
{
    public class ShopServicee : IShopService
    {
        private readonly ShopRepo<Shop> _ShopRepo=new ShopRepo<Shop>();
        public void Create()
        {
            Shop shop = new Shop();
            Console.WriteLine("enter the name of shop:  ");
        HERE:
            string name = Console.ReadLine();
            if (Helper.Check(name))
                shop.Name = name;
            else
                goto HERE;
            Console.WriteLine("enter ");
            _ShopRepo.Create(shop);
            Console.WriteLine("Added succesfully!!");
        }

        public void Delete()
        {
            Console.WriteLine("Please enter the ID of the shop that you wanna delete:  ");
            AGAIN:
            int.TryParse(Console.ReadLine(), out int id);

            while (id <= 0)
            {
                Console.WriteLine("enter the valid ID");
                goto AGAIN;
            }

            Shop shop = _ShopRepo.Get(x=>x.Id== id);

            if(shop == null)
            {
                Console.WriteLine("Thaere iss  no any Shop with such an ID");
                goto AGAIN;
            }
            else
            {
                _ShopRepo.Delete(shop);
                Console.WriteLine("Deleted succesfully!!");
            }

        }

        public void Get()
        {
            Console.WriteLine("Enter ID of the Product that yu wanna find: ");
            AGAIN2:
            int.TryParse(Console.ReadLine(), out int idd);
            while(idd<= 0)
            {
                Console.WriteLine("enter valid ID!!");
                goto AGAIN2;
            }

            Shop shop= _ShopRepo.Get(w=>w.Id== idd);

            if (shop == null)
            {
                Console.WriteLine("there is not any product with such an id");
            }

            Console.WriteLine($"name-->{shop.Name}  ID-->{shop.Id}");
        }

        public void GetAll()
        {
            foreach (var item in _ShopRepo.GetAll())
            {
                Console.WriteLine($"name-->{item.Name}  ID-->{item.Id}");
            }
        }

        public void Update()
        {
            Console.WriteLine("please enter the ID of the product that you wanna update");
        HEREEE:
            int.TryParse(Console.ReadLine(), out int iddd);
            Shop shop = new Shop();
            shop =_ShopRepo.Get(k => k.Id == iddd);


            while (iddd<= 0)
            {
                Console.WriteLine("enter the valid ID");
                goto HEREEE;
            }

            if (shop == null)
            {
                Console.WriteLine("there is not any shop with such an ID");
                goto HEREEE;
            }
            else
            {
                Console.WriteLine("What do you want new name of the shop to be?");
                THEREEE:
                string NewName=Console.ReadLine();
                if (Helper.Check(NewName))
                {
                    shop.Name= NewName;
                }
                else
                {
                    goto THEREEE;
                }
            }
        }
    }
}
