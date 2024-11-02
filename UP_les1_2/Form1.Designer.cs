namespace UP_les1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            price = new TextBox();
            butSet = new Button();
            menuStrip1 = new MenuStrip();
            магазинToolStripMenuItem = new ToolStripMenuItem();
            неМагазинToolStripMenuItem = new ToolStripMenuItem();
            showShop = new ListBox();
            label3 = new Label();
            count = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            label9 = new Label();
            search = new TextBox();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Товар:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 116);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Цена:";
            // 
            // name
            // 
            name.Location = new Point(109, 55);
            name.Name = "name";
            name.Size = new Size(163, 27);
            name.TabIndex = 2;
            // 
            // price
            // 
            price.Location = new Point(109, 116);
            price.Name = "price";
            price.Size = new Size(163, 27);
            price.TabIndex = 3;
            // 
            // butSet
            // 
            butSet.Location = new Point(96, 225);
            butSet.Name = "butSet";
            butSet.Size = new Size(94, 29);
            butSet.TabIndex = 4;
            butSet.Text = "Добавить";
            butSet.UseVisualStyleBackColor = true;
            butSet.Click += butSet_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { магазинToolStripMenuItem, неМагазинToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(950, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // магазинToolStripMenuItem
            // 
            магазинToolStripMenuItem.Name = "магазинToolStripMenuItem";
            магазинToolStripMenuItem.Size = new Size(65, 24);
            магазинToolStripMenuItem.Text = "Товар";
            магазинToolStripMenuItem.Click += магазинToolStripMenuItem_Click;
            // 
            // неМагазинToolStripMenuItem
            // 
            неМагазинToolStripMenuItem.Name = "неМагазинToolStripMenuItem";
            неМагазинToolStripMenuItem.Size = new Size(83, 24);
            неМагазинToolStripMenuItem.Text = "Магазин";
            неМагазинToolStripMenuItem.Click += неМагазинToolStripMenuItem_Click;
            // 
            // showShop
            // 
            showShop.FormattingEnabled = true;
            showShop.Location = new Point(26, 50);
            showShop.Name = "showShop";
            showShop.Size = new Size(474, 204);
            showShop.TabIndex = 7;
            showShop.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 32);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 8;
            label3.Text = "Список продуктов:";
            label3.Visible = false;
            // 
            // count
            // 
            count.Location = new Point(109, 179);
            count.Name = "count";
            count.Size = new Size(163, 27);
            count.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 182);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 10;
            label4.Text = "Количество:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 313);
            label5.Name = "label5";
            label5.Size = new Size(395, 20);
            label5.TabIndex = 11;
            label5.Text = "Введите название товара который хотите приобрести :";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(198, 401);
            button1.Name = "button1";
            button1.Size = new Size(276, 29);
            button1.TabIndex = 13;
            button1.Text = "Добавить в корзину";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 350);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 14;
            label6.Text = "Количество:";
            label6.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 15;
            textBox1.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(518, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 124);
            listBox1.TabIndex = 16;
            listBox1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(569, 50);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 17;
            label7.Text = "Корзина:";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(768, 50);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 18;
            label8.Text = "Прибыль магазина:";
            label8.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(569, 212);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Купить";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(808, 103);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 20;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // search
            // 
            search.Location = new Point(428, 318);
            search.Name = "search";
            search.Size = new Size(125, 27);
            search.TabIndex = 21;
            search.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(528, 247);
            button3.Name = "button3";
            button3.Size = new Size(164, 29);
            button3.TabIndex = 22;
            button3.Text = "Очистить корзину";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(687, 401);
            button4.Name = "button4";
            button4.Size = new Size(189, 29);
            button4.TabIndex = 23;
            button4.Text = "Поменять количество";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(711, 350);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 24;
            textBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 470);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(search);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(count);
            Controls.Add(label3);
            Controls.Add(showShop);
            Controls.Add(butSet);
            Controls.Add(price);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox price;
        private Button butSet;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem магазинToolStripMenuItem;
        private ToolStripMenuItem неМагазинToolStripMenuItem;
        private ListBox showShop;
        private Label label3;
        private TextBox count;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private Button button2;
        private Label label9;
        private TextBox search;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
    }
}
