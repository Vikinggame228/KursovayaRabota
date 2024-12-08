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
    /// Логика взаимодействия для Office_equip.xaml
    /// </summary>
    public partial class Office_equip : Window
    {
        Office_equipment _OfficeModel;

        public Office_equip()
        {
            _OfficeModel = new Office_equipment();
            InitializeComponent();
            DataContext = _OfficeModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationContext();
            var AddOff = new Office_equipment()
            {
                Type = _OfficeModel.Type,
                cost = _OfficeModel.cost,
            };
            db.Add(AddOff);
            db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var main_w = new MainWindow();
            Close();
            main_w.Show();
        }

        private void Check_base(object sender, RoutedEventArgs e)
        {
            var collection = new ObsCollection("office_equip");

            collection.Show();
        }
    }
}
