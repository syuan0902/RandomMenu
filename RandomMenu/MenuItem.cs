using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMenu
{
    class MenuItem
    {
        public static Random m_randomMizer = new Random();

        public string[] Meat =
            { "牛肉", "豬肉", "羊肉", "雞肉", "鴨肉", "鵝肉"};

        public string[] Vegetable =
            { "高麗菜", "空心菜", "木耳", "小白菜", "玉米", "紅蘿蔔"};

        public string[] Rice =
            { "白米", "糙米", "糯米", "五穀米", "紫米"};

        public string Description = "";

        public string Price;

        public void Generate()
        {
            string randomMeat = Meat[m_randomMizer.Next(Meat.Length)];

            string randomVegetable = Vegetable[m_randomMizer.Next(Vegetable.Length)];

            string randomRice = Rice[m_randomMizer.Next(Rice.Length)];

            Description = randomMeat + "佐" + randomVegetable + "配" + randomRice;

            decimal m_dollars = m_randomMizer.Next(2, 5);
            decimal m_cents = m_randomMizer.Next(1, 98);
            decimal m_price = (m_dollars * 10) + (m_cents * 0.1m);

            Price = m_price.ToString("c");
        }
    }
}
