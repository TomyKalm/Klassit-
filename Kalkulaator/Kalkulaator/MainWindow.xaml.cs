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

namespace Kalkulaator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t1.Text = "test";
            
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int pikkus = int.Parse(t2.Text);
            int laius = int.Parse(t3.Text);
            int kogus;
            if (r1.IsChecked == true)
            {
                kogus = pikkus * laius;
                t4.Text = kogus.ToString();
            }
            else
            {
                MessageBox.Show("Palun valige mida tahate arvutada");
            }    
        }        
    }
}
