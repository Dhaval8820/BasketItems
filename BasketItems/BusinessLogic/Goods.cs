using BasketItems.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketItems.BusinessLogic
{
	public class Goods
	{
		public List<GoodsModel> productList()
		{
			List<GoodsModel> goodList = new List<GoodsModel>();
			goodList.Add(new GoodsModel { Name = "Soup", Price = 0.65 });
			goodList.Add(new GoodsModel { Name = "Bread", Price = 0.80 });
			goodList.Add(new GoodsModel { Name = "Milk", Price = 1.30 });
			goodList.Add(new GoodsModel { Name = "Apples", Price = 1.00 });

			return goodList;
		}
	}
}
