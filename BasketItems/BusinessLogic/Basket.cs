using BasketItems.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketItems.BusinessLogic
{
	public class Basket
	{
		private Goods _goods;
		private List<string> _SelectedItems;
		public List<string> DiscountDiscription { get; set; }

		private List<GoodsModel> ItemList { get; set; }
		public double DiscountPrice { get { return GetDiscountPrice(); } }
		public double Subtotal { get { return CalculateTotalItemPrice(); } }
		public double Total { get { return Subtotal - DiscountPrice; } }

		public Basket() { }
		public Basket(Goods goods, List<string> selectedItems)
		{
			_goods = goods;
			_SelectedItems = selectedItems;
			DiscountDiscription = new List<string>();
			ItemList = _goods.productList().Where(x => _SelectedItems.Contains(x.Name)).ToList();
		}


		private double GetDiscountPrice()
		{
			double totalDiscount = 0;
			bool flagSoap = false;
			foreach (var item in _SelectedItems)
			{
				double discount = 0;
				switch (item)
				{
					case "Apples":
						discount = CalculateAppleDiscount(ItemList.Where(x => x.Name == item).FirstOrDefault().Price);
						break;
					case "Soup":
						int count = 0;
						var isavailableBread = ItemList.Where(x => x.Name == "Bread").FirstOrDefault();
						foreach (var icount in _SelectedItems)
						{
							if (item.Equals(icount))
								count += 1;
						}
						if (count >= 2 && isavailableBread != null && flagSoap == false)
						{
							discount = Calculate50OffOnBread(ItemList.Where(x => x.Name == "Bread").FirstOrDefault().Price);
							flagSoap = true;
						}

						break;
					default:
						discount = 0;
						break;
				}
				totalDiscount += discount;
			}
			return totalDiscount;
		}

		private double CalculateTotalItemPrice()
		{
			double totalprice=0;
			foreach (var item in _SelectedItems)
			{
				totalprice+=ItemList.Where(x => x.Name == item).FirstOrDefault().Price;
			}
			return totalprice;
		}

		private double CalculateAppleDiscount(double price)
		{
			var discount = (price * 10) / 100;
			DiscountDiscription.Add($"Apples 10% off: {discount}p");
			return discount;
		}
		private double Calculate50OffOnBread(double price)
		{
			var discount = (price / 2);
			DiscountDiscription.Add($"Buy 2 tins of soup, get a loaf of bread half price");
			return discount;
		}
	}
}
