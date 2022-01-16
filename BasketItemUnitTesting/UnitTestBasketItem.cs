using BasketItems.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasketItemUnitTesting
{
	[TestClass]
	public class UnitTestBasketItem
	{
		[TestMethod]
		public void Case1()
		{
			List<string> argments = new List<string>();
			argments.Add("Milk");
			argments.Add("Apples");
			argments.Add("Bread");

			if (argments == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), argments.ToList());
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
		[TestMethod]
		public void Case2()
		{
			List<string> argments = new List<string>();
			argments.Add("Soup");
			argments.Add("Soup");
			argments.Add("Bread");

			if (argments == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), argments.ToList());
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
		[TestMethod]
		public void Case3()
		{
			List<string> argments = new List<string>();
			argments.Add("Milk");

			if (argments == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), argments.ToList());
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
		[TestMethod]
		public void Case4()
		{
			List<string> argments = new List<string>();
			argments.Add("Apples");
			argments.Add("Bread");
			argments.Add("Soup");
			argments.Add("Soup");
			argments.Add("Milk");

			if (argments == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), argments.ToList());
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
		[TestMethod]
		public void Case5()
		{
			List<string> argments = new List<string>();
			argments.Add("Bread");
			argments.Add("Soup");

			if (argments == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), argments.ToList());
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
		[TestMethod]
		public void Case6()
		{
			List<string> argments = new List<string>();
			argments.Add("Soup");
			argments.Add("Soup");

			if (argments == null)
			{
				Console.WriteLine("Basket is empty");
			}
			else
			{
				var basket = new Basket(new Goods(), argments.ToList());
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
