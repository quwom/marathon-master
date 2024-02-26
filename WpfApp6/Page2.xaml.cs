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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void novie_Click(object sender, RoutedEventArgs e)
        {
            Frame2.Navigate(new Page4());
        }

        private void ranee_Click(object sender, RoutedEventArgs e)
        {
            Frame2.Navigate(new Page3());
        }

        private void nasad_Click(object sender, RoutedEventArgs e)
        {
            Frame2.GoBack();
        }

        private void Loguot_Click(object sender, RoutedEventArgs e)
        {
            Frame2.Navigate(new Page1());
        }
    }
}
