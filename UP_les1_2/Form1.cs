using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UP_les1_2
{
    public partial class Form1 : Form
    {
        //создаём объекты классов
        Shop pyaterochka = new Shop();
        Product product;
        //переменная для хранения количества продукта
        int cou = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void butSet_Click(object sender, EventArgs e)
        {
            //проверка на пустоту
            if (name != null && price != null && count != null)
            {
                //проверка на то, что введённая пользователем информация о цене является корректной
                if (decimal.TryParse(price.Text, out decimal pri))
                {
                    //проверка на то, что введённая пользователем информация о количестве товара является корректной
                    if (int.TryParse(count.Text, out cou))
                    {
                        if (cou > 0)
                        {
                            if (pyaterochka.Availability(pyaterochka.FindByName(name.Text)))
                            {
                                //создаем объект класса Shop
                                pyaterochka.CreateProduct(name.Text, pri, cou);
                                pyaterochka.WriteAllProducts(showShop); //вызываеем метод для вывода получившейся в listBox

                                //очищаем значения в textBox
                                name.Text = string.Empty;
                                price.Text = string.Empty;
                                count.Text = string.Empty;
                            }
                            else MessageBox.Show("Такой товар уже есть!");
                        }
                        else MessageBox.Show("Некорректный ввод количества. Пожалуйста, введите число больше 0.");
                    }
                    else MessageBox.Show("Некорректный ввод количества. Пожалуйста, введите число.");
                }
                else MessageBox.Show("Некорректный ввод цены. Пожалуйста, введите число.");
            }
            else MessageBox.Show("Вы не ввели информацию в одно из полей! Проверьте свои данные!.");


        }

        private void магазинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открываем поля для ввода и отображения товара
            //label
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            //textBox
            name.Visible = true;
            price.Visible = true;
            count.Visible = true;
            //button
            butSet.Visible = true;

            //скрываем поле для отображения информации о магазине
            //label
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            //textBox
            textBox1.Visible = false;
            textBox2.Visible = false;
            search.Visible = false;
            //button
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            //listBox
            listBox1.Visible = false;
            showShop.Visible = false;
        }

        private void неМагазинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //скрываем поля для ввода и отображения товара
            //label
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            //textBox
            name.Visible = false;
            price.Visible = false;
            count.Visible = false;
            //button
            butSet.Visible = false;

            //открываем поле для отображения информации о магазине
            //label
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            //textBox
            textBox1.Visible = true;
            textBox2.Visible = true;
            search.Visible = true;
            //button
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            //listBox
            listBox1.Visible = true;
            showShop.Visible = true;
            
            //скрываем поля с прибылью, поскольку пока пользователь не совершит покупку она не нужна
            label8.Visible = false;
            label9.Visible = false;

            //очищаем значения в textBox
            search.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        //событие для добавления продуктов в корзину
        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text != null) //проверка на то, что поле заполнено
            {
                if (pyaterochka.FindByName(search.Text) != null) //проверка на то,что введёный товар есть в перечне
                {
                    if (textBox1.Text != null && int.TryParse(textBox1.Text, out int numb)) //проверка на то, что пользователь не оставил поле пустым и ввел коректную информацию
                    {
                        if (numb > 0) //проверка на то, что пользователь действительно собирается покупать некоторое количество продукта
                        {
                            if (numb <= cou) //проверка на то,что введённое число меньше/равно количеству в наличии
                            {
                                listBox1.Items.Add($"{search.Text}, {numb}"); //добавление желаемой покупки в корзину
                                //очищаем значения в textBox
                                search.Text = string.Empty;
                                textBox1.Text = string.Empty;
                            }
                            else MessageBox.Show("У нас нет столько желаемого вами товара!");
                        }
                        else MessageBox.Show("Вы не можете хотеть купить 0!");
                    }
                    else MessageBox.Show("Введите количество товара, который хотите купить");
                }
                else MessageBox.Show("Данного товара нет в списке");
            }
            else MessageBox.Show("Введите название товара, который хотите купить");
        }

        //событие для совершения покупки и подсчёта прибыли
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "";
            int count = 0;
            //создаем коллекцию для того,чтобы понимать какие товары пользователь добавил в корзину
            List<string> productPrices = new List<string>();
            foreach (var item in listBox1.Items)
            {
                productPrices.Add(item.ToString()); //заполняем
            }
            //совершаем покупку
            for (int i = 0; i < productPrices.Count; i++)
            {
                //достаём из словаря значение и разделяем его на состовляющие
                string elementToSplit = productPrices[i];
                string[] splitElements = elementToSplit.Split(',').Select(item => item.Trim()).ToArray();
                //присваиваем нужным переменным получившиеся значения
                name = splitElements[0];
                count = int.Parse(splitElements[1]);

                //вызываем метод для совершения покупки
                pyaterochka.Sell(pyaterochka.FindByName(name), count, listBox1);
                //и для обновления информации
                pyaterochka.WriteAllProducts(showShop);
            }
            //показываем поля в прибылью
            label8.Visible = true;
            label9.Visible = true;

            label9.Text = pyaterochka.ShowProfit().ToString() + " руб."; //вывод количсетва прибыли
        }

        //событие для очищения "Корзины"
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли выделенный элемент
            if (showShop.SelectedItem != null)
            {
                if (textBox2 != null)
                {
                    if (int.TryParse(textBox2.Text, out int count2))
                    {
                        if (count2 > 0)
                        {
                            // Находим индекс выделенного элемента и обновляем его
                            int index = showShop.SelectedIndex;
                            pyaterochka.Update(index, count2); // Обновляем значение в словаре
                            pyaterochka.WriteAllProducts(showShop); // Обновляем значение в ListBox
                            //очищаем значения в textBox
                            textBox2.Text = string.Empty;
                        }
                        else MessageBox.Show("Введите количество больше 0!");
                    }
                    else MessageBox.Show("Введите корректное значение!");
                }
                else MessageBox.Show("Введите количество");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент для изменения.");
            }
        }
    }
}
