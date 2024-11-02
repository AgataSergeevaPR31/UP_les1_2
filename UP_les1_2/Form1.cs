using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UP_les1_2
{
    public partial class Form1 : Form
    {
        //������ ������� �������
        Shop pyaterochka = new Shop();
        Product product;
        //���������� ��� �������� ���������� ��������
        int cou = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void butSet_Click(object sender, EventArgs e)
        {
            //�������� �� �������
            if (name != null && price != null && count != null)
            {
                //�������� �� ��, ��� �������� ������������� ���������� � ���� �������� ����������
                if (decimal.TryParse(price.Text, out decimal pri))
                {
                    //�������� �� ��, ��� �������� ������������� ���������� � ���������� ������ �������� ����������
                    if (int.TryParse(count.Text, out cou))
                    {
                        if (cou > 0)
                        {
                            if (pyaterochka.Availability(pyaterochka.FindByName(name.Text)))
                            {
                                //������� ������ ������ Shop
                                pyaterochka.CreateProduct(name.Text, pri, cou);
                                pyaterochka.WriteAllProducts(showShop); //��������� ����� ��� ������ ������������ � listBox

                                //������� �������� � textBox
                                name.Text = string.Empty;
                                price.Text = string.Empty;
                                count.Text = string.Empty;
                            }
                            else MessageBox.Show("����� ����� ��� ����!");
                        }
                        else MessageBox.Show("������������ ���� ����������. ����������, ������� ����� ������ 0.");
                    }
                    else MessageBox.Show("������������ ���� ����������. ����������, ������� �����.");
                }
                else MessageBox.Show("������������ ���� ����. ����������, ������� �����.");
            }
            else MessageBox.Show("�� �� ����� ���������� � ���� �� �����! ��������� ���� ������!.");


        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��������� ���� ��� ����� � ����������� ������
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

            //�������� ���� ��� ����������� ���������� � ��������
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

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ���� ��� ����� � ����������� ������
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

            //��������� ���� ��� ����������� ���������� � ��������
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
            
            //�������� ���� � ��������, ��������� ���� ������������ �� �������� ������� ��� �� �����
            label8.Visible = false;
            label9.Visible = false;

            //������� �������� � textBox
            search.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        //������� ��� ���������� ��������� � �������
        private void button1_Click(object sender, EventArgs e)
        {
            if (search.Text != null) //�������� �� ��, ��� ���� ���������
            {
                if (pyaterochka.FindByName(search.Text) != null) //�������� �� ��,��� ������� ����� ���� � �������
                {
                    if (textBox1.Text != null && int.TryParse(textBox1.Text, out int numb)) //�������� �� ��, ��� ������������ �� ������� ���� ������ � ���� ��������� ����������
                    {
                        if (numb > 0) //�������� �� ��, ��� ������������ ������������� ���������� �������� ��������� ���������� ��������
                        {
                            if (numb <= cou) //�������� �� ��,��� �������� ����� ������/����� ���������� � �������
                            {
                                listBox1.Items.Add($"{search.Text}, {numb}"); //���������� �������� ������� � �������
                                //������� �������� � textBox
                                search.Text = string.Empty;
                                textBox1.Text = string.Empty;
                            }
                            else MessageBox.Show("� ��� ��� ������� ��������� ���� ������!");
                        }
                        else MessageBox.Show("�� �� ������ ������ ������ 0!");
                    }
                    else MessageBox.Show("������� ���������� ������, ������� ������ ������");
                }
                else MessageBox.Show("������� ������ ��� � ������");
            }
            else MessageBox.Show("������� �������� ������, ������� ������ ������");
        }

        //������� ��� ���������� ������� � �������� �������
        private void button2_Click(object sender, EventArgs e)
        {
            string name = "";
            int count = 0;
            //������� ��������� ��� ����,����� �������� ����� ������ ������������ ������� � �������
            List<string> productPrices = new List<string>();
            foreach (var item in listBox1.Items)
            {
                productPrices.Add(item.ToString()); //���������
            }
            //��������� �������
            for (int i = 0; i < productPrices.Count; i++)
            {
                //������ �� ������� �������� � ��������� ��� �� ������������
                string elementToSplit = productPrices[i];
                string[] splitElements = elementToSplit.Split(',').Select(item => item.Trim()).ToArray();
                //����������� ������ ���������� ������������ ��������
                name = splitElements[0];
                count = int.Parse(splitElements[1]);

                //�������� ����� ��� ���������� �������
                pyaterochka.Sell(pyaterochka.FindByName(name), count, listBox1);
                //� ��� ���������� ����������
                pyaterochka.WriteAllProducts(showShop);
            }
            //���������� ���� � ��������
            label8.Visible = true;
            label9.Visible = true;

            label9.Text = pyaterochka.ShowProfit().ToString() + " ���."; //����� ���������� �������
        }

        //������� ��� �������� "�������"
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ���������, ���� �� ���������� �������
            if (showShop.SelectedItem != null)
            {
                if (textBox2 != null)
                {
                    if (int.TryParse(textBox2.Text, out int count2))
                    {
                        if (count2 > 0)
                        {
                            // ������� ������ ����������� �������� � ��������� ���
                            int index = showShop.SelectedIndex;
                            pyaterochka.Update(index, count2); // ��������� �������� � �������
                            pyaterochka.WriteAllProducts(showShop); // ��������� �������� � ListBox
                            //������� �������� � textBox
                            textBox2.Text = string.Empty;
                        }
                        else MessageBox.Show("������� ���������� ������ 0!");
                    }
                    else MessageBox.Show("������� ���������� ��������!");
                }
                else MessageBox.Show("������� ����������");
            }
            else
            {
                MessageBox.Show("����������, �������� ������� ��� ���������.");
            }
        }
    }
}
