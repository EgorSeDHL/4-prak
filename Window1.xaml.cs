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

namespace _4_practicheskaia_C_Sharp
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void add_type_second_window_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void add_type_second_window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            add_type_second_window.Text = null;
        }

        private void add_type_Click(object sender, RoutedEventArgs e)
        {
            Window1 windows1 = new();
            windows1.Close();
            peremennie.types.Add(add_type_second_window.Text);
        }
    }
}
