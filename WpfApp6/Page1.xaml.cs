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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void Loguot_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Page1());
        }

        private void nasad_Click(object sender, RoutedEventArgs e)
        {
            Frame1.GoBack();
        }

        private void bolse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sponsor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Beg_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(new Page2());
        }
    }
}
