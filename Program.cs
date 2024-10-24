using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Аптека__торг_лекарствами__Шендецов_.ProducktKategory;
using static Аптека__торг_лекарствами__Шендецов_.Класс_истории_продаж;


namespace Аптека__торг_лекарствами__Шендецов_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var painkiller = new Product("Ибупрофен", ProducktKategory.Painkillers, 5.99m);
            var antibiotic = new Product("Амоксицилин", ProducktKategory.Antibiotics, 12.50m);
            var vitamin = new Product("Витамин С", ProducktKategory.Vitamins, 3.75m);
            var coughSyrp = new Product("Сироп Салодки", ProducktKategory.CoughSyrps, 7.20m);
            var salesManager = new SalesManager();
            salesManager.AddSale(new Sale(painkiller, 10));
            salesManager.AddSale(new Sale(antibiotic, 5));
            salesManager.AddSale(new Sale(vitamin, 20));
            salesManager.AddSale(new Sale(coughSyrp, 8));

            salesManager.Printreport()
        }
    }
}
