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

namespace _4_practicheskaia_C_Sharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            date_picker.SelectedDate = DateTime.Today;
            combo_box.ItemsSource = peremennie.types;

        }

     

        private void type_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }

      

        private void name_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            name.Text = null;
        }
        

        private void create_Click(object sender, RoutedEventArgs e)
        {
            peremennie.name_zametki.Add(name.Text);
            peremennie.money.Add(summa.Text);
            peremennie.strings.Add(combo_box.Text);
            peremennie.date.Add(date_picker.SelectedDate);
            spisok.
        }

     

        
        private void summa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            summa.Text = "";
        }
    }
}
