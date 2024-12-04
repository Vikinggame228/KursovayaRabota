using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string? appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string imagePath = System.IO.Path.Combine(appPath!, "SPRK_default_preset_name_custom – 1.png");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var Transport = new Change_Transport();
            Transport.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Invent = new Inventory();
            Invent.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Realest = new Realest();
            Realest.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var Office = new Office_equip();
            Office.Show();
            Close();
        }

        private void Check_Price(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationContext();

            var inv_price = db.Inventory;
            var Transport = db.Transport;
            var Office_equipment = db.Office_Equipment;
            var Realest = db.Realestates;

            var total_inv = inv_price.Select(x => x.cost).Sum();
            var total_transport = Transport.Select(x => x.cost).Sum();
            var total_Office_equip = Office_equipment.Select(x => x.cost).Sum();
            var total_Realest = Realest.Select(x => x.cost).Sum();

            int? total = total_inv + total_transport + total_Office_equip + total_Realest;
            MessageBox.Show($"{total}", Title = "total price");
        }
    }
}