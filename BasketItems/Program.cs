using BasketItems.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketItems
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), args.ToList());
				Console.WriteLine($"Subtotal: £{ basket.Subtotal }");
				var totalprice = basket.Total;
				if (basket.DiscountDiscription.Count() == 0)
				{
					Console.WriteLine("(no offers available)");
				}
				else
				{
					foreach (var item in basket.DiscountDiscription)
					{
						Console.WriteLine(item);
					}
				}
				Console.WriteLine($"Total: £{ totalprice }");
			}
		}
	}
}
