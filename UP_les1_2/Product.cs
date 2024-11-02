using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_les1_2
{
    internal class Product
    {
        //создаем поля класса
        public decimal Price { get; set; }
        public string Name { get; set; }

        //конструктор
        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        //вывод информации
        public string GetInfo()
        {
            return $"{Name}, \tцена: {Price} руб.,\t";
        }
    }
}
