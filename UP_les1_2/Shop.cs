using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UP_les1_2
{
    internal class Shop
    {
        //объекты
        private Dictionary<Product, int> products;
        private decimal profit = 0;

        //конструктор
        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        //метод для создания товара и добавления его в список
        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        //метод вывода продуктов
        public void WriteAllProducts(ListBox showShop) //получаем нужным нам listBox
        {
            showShop.Items.Clear(); //очищаем значения до
            foreach (var product in products)
            {
               showShop.Items.Add(product.Key.GetInfo() + "кол-во: " + product.Value); //добавляем значения,используя метод из другого класса
            }
            
        }

        //метод для продажи товара
        public void Sell(Product product, int count, ListBox listBox1)
        {
            //проверка на то, что коллекция содержит введённый товар
            if (products.ContainsKey(product))
            {
                if (products[product] == 0) //проверка на то, что товара нет в наличии
                {
                    products.Remove(product); //удаляем его из коллекции
                    listBox1.Items.Clear(); //очищаем "Корзину"
                    MessageBox.Show($"{product.Name} нет в наличии!");  
                }
                else
                {
                    //при покупке вычитаем введнные единицы товара из общего количества
                    products[product] -= count;
                    profit += count * product.Price; //считаем прибыль
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }

        //поиск товара по имени
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        //метод для вывода прибыли
        public decimal ShowProfit()
        {
            return profit;
        }

        //проверка на наличие товара, чтобы нельзя было добавить два одинаковых
        public bool Availability(Product product)
        {
            //проверка на то, что словарь пустой
            if (product == null)
            {
                return true; //да, пустая, поэтому может добавлять первый товар смело
            }

            //Проверка на то, что словарь не пустой
            if (products.Count > 0)
            {
                //true - если такого элемента нет в словаре, false - если есть
                return !products.ContainsKey(product);
            }

            //если всё пусто (для того,чтобы метод не ругался на то,что не все пути имеют возврат)
            return true;
        }

        public void Update(int index, int count)
        {
            Product productToUpdate = null;
            int currIndex = 0;
            foreach (var product in products.Keys)
            {
                if (currIndex == index)
                {
                    productToUpdate = product;
                    break;
                }
                currIndex++;
            }

            if (productToUpdate != null) products[productToUpdate] = count;

        }
    }
}
