using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Аптека__торг_лекарствами__Шендецов_.ProducktKategory;

namespace Аптека__торг_лекарствами__Шендецов_
{
    internal class Продукты
    {
        public class Product
        {
            public string Name { get; }
            public ProducktKategory Chategory { get; }
            public decimal Price { get; }
            public Product(string name, ProducktKategory Chategory, decimal price)
            {
                Name = name;
                Chategory = Chategory;
                Price = price;
            }
        }
    }
}

