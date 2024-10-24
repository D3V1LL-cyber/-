using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Аптека__торг_лекарствами__Шендецов_
{
    internal class Класс_продаж
    {
        public class SalersManager
        {
            private List<Sale>
                sales = new List<Sale>();
                public void AddSale(Sale sale)
            {
                sales.Add(sale);
            }
            public decimal GetTotalSalesByCategory(ProducktKategory category)
            {
                decimal total = 0;
                foreach(var sale in sales) 
                {
                    if(sale.Product.Category == category) 
                    {
                        total += sale.GetTotalSaleValue();
                    }
                }
                return total;
            }
            public void Printreport()
            {
                foreach(ProducktKategory category in Enum.GetValues(typeof(ProducktKategory)))
                {
                    decimal totalSales = GetTotalSalesByCategory(category);
                    Console.WriteLine($"TotalSales for{category}:{totalSales:C}");
                }
            }
        }
    }
}
