

using ConsoleApp.Service.Services.Implementations.ProductServicee;
using ConsoleApp.Service.Services.Implementations.ShopServices;
HERE:
Helper.Words();
int.TryParse(Console.ReadLine(), out int select);
ShopServicee serviceeSS = new ShopServicee();
ProductService sercicePP=new ProductService();
switch (select)
{
	case 1:
		serviceeSS.Create();
		goto HERE;
	case 2:
		serviceeSS.GetAll();
		goto HERE;
	case 3:
		serviceeSS.Delete();
        goto HERE;
	case 4:
		serviceeSS.Update();
		goto HERE;
	case 5:
		sercicePP.Create();
		goto HERE;
	case 6:
		sercicePP.Delete();
        goto HERE;
	case 7:
		sercicePP.Update();
        goto HERE;
	case 8:
		sercicePP.GetAll();
		goto HERE;
	default:
		break;
}


