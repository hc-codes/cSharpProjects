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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool clicked = false;
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            clicked = true;
            btnSave.Content = "Clicked";
            btnSave.Background = Brushes.Green;
        }

        private void btnSave_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!clicked)
                btnSave.Background = Brushes.Yellow;
        }

        private void btnSave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //btnSave.Background = Brushes.Red;
        }

        private void btnSave_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!clicked)
                btnSave.Background = Brushes.Red;

        }
    }
}
