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

namespace SandwichesRecipe
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
            MenuItem[] menuItems = new MenuItem[6];
            string guacomolePrice = string.Empty;

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Breads = new string[] { "Авиационный Бублик", "Луковый бублик", "Бублик пампушка", "Бублик" };
                }
                menuItems[i].Generate();
            }

            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;

            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;

            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;

            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;

            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            MenuItem specialMenuItem = new MenuItem() 
            {
                Proteins = new string[] { "Органическая ветчина", "Грибная котлета", "Мортаделла" },
                Breads = new string[] { "ролл без глютена", "пита", "лаваш" },
                Condiments = new string[] { "дижонская горчица", "соус мисо", "сок" }
            };
            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Description;
            price6.Text = specialMenuItem.Price;

            MenuItem guacomoleMenuItem = new MenuItem();
            guacomoleMenuItem.Generate();
            guacomolePrice = guacomoleMenuItem.Price;

            guacamole.Text = $"Add guacamole for {guacomoleMenuItem.Price}";

        }
    }
}
