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
    /// Логика взаимодействия для Login_Window.xaml
    /// </summary>
    public partial class Login_Window : Window
    {
        Users _userModel;

        public Login_Window()
        {
            _userModel = new Users();
            InitializeComponent();
            //string? appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string imagePath = System.IO.Path.Combine(appPath!, "Login_w.png");
            DataContext = _userModel;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using var db = new ApplicationContext();
            var userFound = db.Users.FirstOrDefault(u => u.Name == _userModel.Name && u.Password == _userModel.Password);
            if (userFound == null)
            {
                MessageBox.Show("пользователь не найден");
            }
            else
            {
                new MainWindow().Show();
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using var db = new ApplicationContext();

            var userEntity = new Users()
            {
                Name = _userModel.Name,
                Password = _userModel.Password,
            };

            db.Users.Add(userEntity);
            db.SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using var db = new ApplicationContext();

            var usersFound = db.Users;
                .Where(x => x.Name!.Contains(_userModel.Name!))
                .ToList();
            var usersFoundString = usersFound.Select(x => x.Name).ToList();
            var usersFounsMessage = string.Join("\n", usersFoundString);
            MessageBox.Show($"Users found:\n{usersFounsMessage}");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
