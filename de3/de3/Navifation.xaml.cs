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

namespace de3
{
    /// <summary>
    /// Логика взаимодействия для Navifation.xaml
    /// </summary>
    public partial class Navifation : Page
    {
        public Navifation()
        {
            InitializeComponent();
        }

        private void BtnBiba_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new biba());
        }

        private void BtnBoba_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new boba());
        }
    }
}
