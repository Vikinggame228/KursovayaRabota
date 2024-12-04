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
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для Inventory.xaml
    /// </summary>
    public partial class Inventory : Window
    {
        Inventory_price _invpriceModel;
        public Inventory()
        {
            _invpriceModel = new Inventory_price();
            InitializeComponent();
            DataContext = _invpriceModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationContext();
            var Inventory = new Inventory_price()
                {
                    type = _invpriceModel.type,
                    cost = _invpriceModel.cost,
                    count = _invpriceModel.count
                };
            db.Add(Inventory);
            db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            Close();
            main.Show();
        }
    }
}
