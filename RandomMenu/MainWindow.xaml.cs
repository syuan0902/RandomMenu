using System;
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

namespace RandomMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string bananaPrice;

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();

                if (i >= 3)
                {
                    menuItems[i].Rice = new string[]
                   {"原味貝果", "洋蔥貝果", "南瓜貝果", "綜合貝果"};

                }
                menuItems[i].Generate();
            }

            item1.Text = menuItems[0].Description;
            item2.Text = menuItems[1].Description;
            item3.Text = menuItems[2].Description;
            item4.Text = menuItems[3].Description;
            item5.Text = menuItems[4].Description;

            price1.Text = menuItems[0].Price;
            price2.Text = menuItems[1].Price;
            price3.Text = menuItems[2].Price;
            price4.Text = menuItems[3].Price;
            price5.Text = menuItems[4].Price;

            MenuItem specialMenuItem = new MenuItem()
            {
                Meat = new string[]
                    {"蚵仔", "豬腳", "雞腿" },
                Rice = new string[]
                    {"藜麥", "花椰米", "小米"},
                Vegetable = new string[]
                    {"結球萵苣", "老鷹紅豆", "毛豆" }
            };
            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            MenuItem bananaMenuItem = new MenuItem();
            bananaMenuItem.Generate();
            bananaPrice = bananaMenuItem.Price;

            banana.Text = "加一根香蕉只要再加" + bananaPrice + "元";
        }
    }
}
