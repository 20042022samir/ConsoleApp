using ConsoleApp.Core.Models;
using ConsoleApp.Data.Repository.ProductRepo;
using ConsoleApp.Data.Repository.ShopRepo.cs;
using ConsoleApp.Service.Services.Interfces.Productt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Service.Services.Implementations.ProductServicee
{
    public class ProductService : IProductService
    {
        ShopRepo<Shop> repoShop=new ShopRepo<Shop>();
        ProductRepo<Product> proRepo = new ProductRepo<Product>();
        public void Create()
        {
            Product product= new Product();
            Console.WriteLine("enter the name of the product that you wanna add");
            SELECTT:
            string PName=Console.ReadLine();
            if (Helper.Check(PName))
            {
                product.Name= PName;
            }
            else
            {
                goto SELECTT;
            }
            Console.WriteLine("Where do you wanna add this product?");


            foreach (var item in proRepo.GetAll())
            {
                Console.WriteLine($"name-->{item.Name} Id-->{item.Id}");
            }
            
            int.TryParse(Console.ReadLine(), out int select);
            Shop shop = repoShop.Get(z => z.Id == select);
            shop.Products.Add(product);
        }

        public void Delete()
        {
            Console.WriteLine("Where do you wanna delete the product?");
            foreach (var item in repoShop.GetAll())
            {
                Console.WriteLine($"name-->{item.Name} ID-->{item.Id}");
            }
            int.TryParse(Console.ReadLine(), out int select2);
            Shop shop2= repoShop.Get(z=>z.Id==select2);
            foreach (var item in shop2.Products)
            {
                Console.WriteLine($"name-->{item.Name} ID-->{item.Id}");
            }
            Console.WriteLine("Choose the product that you wanna delete");
            int.TryParse(Console.ReadLine(),out int select3);
            foreach (var item in shop2.Products)
            {
                if (item.Id == select3)
                {
                    shop2.Products.Remove(item);
                    Console.WriteLine("Deleted Succesfully!!");
                }
            }

        }

        public void GetAll()
        {
            Console.WriteLine("Which Market's products do you wanna see");
            foreach (var item in repoShop.GetAll())
            {
                Console.WriteLine($"name--<{item.Name} ID-->{item.Id}");
            }
            int.TryParse(Console.ReadLine(),out int select10);
            Shop shop10=repoShop.Get(k=>k.Id==select10);
            foreach (var item in shop10.Products)
            {
                Console.WriteLine($"name-->{item.Name}  id-->{item.Id}");
            }
        }

        public void Update()
        {
            Console.WriteLine("where dou wanna update?");
            for (int i = 0; i < repoShop.GetAll().Count; i++)
            {
                Console.WriteLine($"name--> {repoShop.GetAll()[i].Name} ID-->{repoShop.GetAll()[i].Id}");
            }
            int.TryParse (Console.ReadLine(), out int select4);
            Shop shop4=repoShop.Get(z=>z.Id==select4);
            foreach (var item in shop4.Products)
            {
                if (item.Id == select4)
                {
                    Console.WriteLine("enter new name of the product: ");
                    string name=Console.ReadLine();
                    if (Helper.Check(name))
                    {
                        item.Name = name;
                        Console.WriteLine("Updated Succesfully!!");
                    }
                }
            }
        }

        
    }
}
