using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace Аптека__торг_лекарствами__Шендецов_
{
    internal class Класс_истории_продаж
    {
        public class Sale
        {
            public Product Product { get; }
            public int quantity { get; }
            public Sale(Product product, int quantity)
            {
                Product = product;
                Quantity = quantity;
            }
            public decimal GetTotalSaleValue()
            {
                return Product.Price * Quantity;
            }
        }
    }
}
