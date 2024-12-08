using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ObsCollection.xaml
    /// </summary>
    public partial class ObsCollection : Window
    {
        public ObsCollection(string t_name)
        {
            InitializeComponent();
            var db = new ApplicationContext();
            var my_table = db.Transport; 
            var my_table1 = db.Inventory; 
            var my_table2= db.Office_Equipment; 
            var my_table3 = db.Realestates;
            switch (t_name)
            {
                case "transport":
                    var my_table_List = my_table.Select(k =>new {k.ID, k.Type, k.place, k.cost}).ToList();
                    Obj_table.ItemsSource = my_table_List;
                    break;
                case "office_equip":
                    var my_table_List2 = my_table2.Select(k => new { k.Type, k.cost }).ToList();
                    Obj_table.ItemsSource = my_table_List2;
                    break;
                case "inventory":
                    var my_table_List1 = my_table1.Select(k => new { k.type, k.cost }).ToList();
                    Obj_table.ItemsSource = my_table_List1;
                    break;
                case "realest":
                    var my_table_List3 = my_table3.Select(k => new { k.type, k.area, k.address, k.cost }).ToList();
                    Obj_table.ItemsSource = my_table_List3;
                    break;
            }
        }
    }
}
