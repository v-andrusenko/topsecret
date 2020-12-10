﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace topsecret_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateProducts();
            store = new Store(products);

        }
        private Article[] products;
        private Store store;

        public void CreateProducts()
        {
            products = new Article[16];
            products[1] = new Article("Ход королевы", "Буква", 300);
            products[2] = new Article("Великий Гэтсби", "Буква", 50);
            products[3] = new Article("Три товарища", "Буква", 150);
            products[4] = new Article("Триумфальная арка", "Розетка", 150);
            products[5] = new Article("Дон Кихот", "Розетка", 200);
            products[6] = new Article("11/22/63", "Розетка", 300);
            products[7] = new Article("Ночь в Лиссабоне", "Yakaboo", 100);
            products[8] = new Article("Двенадцать стульев", "Yakaboo", 50);
            products[9] = new Article("Тени в раю", "Yakaboo", 50);
            products[10] = new Article("Жизнь взаймы", "Yakaboo", 150);
            products[11] = new Article("Оно", "Буква", 350);
            products[12] = new Article("Остров сокровищ", "Розетка", 100);
            products[13] = new Article("Шантарам", "Yakaboo", 200);
            products[14] = new Article("Золотой телёнок", "Буква", 50);
            products[15] = new Article("На Западном фронте без перемен", "Yakaboo", 250);
        }
        public static Boolean IsNumeric(string index)
        {
            bool result;
            string value = index.Trim(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });

            if (value == "")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((IsNumeric(Convert.ToString(inputBox.Text)) == false))
            {
                productNameBox.Text = "";
                shopNameBox.Text = "";
                priceBox.Text = "";
                MessageBox.Show("Некорректное значение");

            }
            else if (Convert.ToInt32(inputBox.Text) > (store.products.Length - 1) || Convert.ToInt32(inputBox.Text) == 0)
            {
                productNameBox.Text = "";
                shopNameBox.Text = "";
                priceBox.Text = "";
                MessageBox.Show("К сожалению, товар не найден");
            }
            else
            {
                int index = Convert.ToInt32(inputBox.Text);
                productNameBox.Text = Convert.ToString(store[index].ProductName);
                shopNameBox.Text = "'" + Convert.ToString(store[index].ShopName) + "'";
                priceBox.Text = Convert.ToString(store[index].Price) + " грн";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string input = Convert.ToString(inputBox.Text.ToLower());

            for (int i = 1; i <= store.products.Length; i++)
            {
                if (input == store[i].ProductName.ToLower())
                {
                    productNameBox.Text = Convert.ToString(store[i].ProductName);
                    shopNameBox.Text = "'" + Convert.ToString(store[i].ShopName) + "'";
                    priceBox.Text = Convert.ToString(store[i].Price) + " грн";
                    break;
                }
                else if (i == store.products.Length - 1 && input != store[i].ProductName.ToLower())
                {
                    productNameBox.Text = "";
                    shopNameBox.Text = "";
                    priceBox.Text = "";
                    MessageBox.Show("К сожалению, товар не найден");
                    break;
                }
                else continue;
            }
        }

        string newItemName;
        string newItemShop;
        double newItemPrice = 0;

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (newItemNameBox.Text != "" && newItemShopBox.Text != "" && newItemPriceBox.Text != "")
            {
                newItemName = Convert.ToString(newItemNameBox.Text);
                newItemShop = Convert.ToString(newItemShopBox.Text);
                newItemPrice = Convert.ToDouble(newItemPriceBox.Text);

                Article newProduct = new Article(newItemName, newItemShop, newItemPrice);

                store.addProduct(newProduct);

                MessageBox.Show("Товар успешно добавлен");
                newItemNameBox.Text = "";
                newItemShopBox.Text = "";
                newItemPriceBox.Text = "";
            }
            else
            {
                MessageBox.Show("Товар не добавлен. Проверьте введенные данные");
            }


        }

    }
}

