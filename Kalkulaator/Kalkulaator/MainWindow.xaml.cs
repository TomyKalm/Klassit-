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
        double tulemusÜ;
        double tulemusP;
        int valitudKujund;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            valitud.Text = "Ristkülik";
            valitudKujund = 1;
            Kõrgus.IsEnabled = false;
            Diameeter.IsEnabled = false;
            Pikkus.IsEnabled = true;
            Laius.IsEnabled = true; 
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                       
            valitud.Text = "Kolmnurk";
            valitudKujund = 2;
            Pikkus.IsEnabled = false;
            Diameeter.IsEnabled = false;
            Kõrgus.IsEnabled = true;
            Laius.IsEnabled = true; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                      
            valitud.Text = "Ring";
            valitudKujund = 3;
            Pikkus.IsEnabled = false;
            Laius.IsEnabled = false;
            Kõrgus.IsEnabled = false;
            Diameeter.IsEnabled = true;
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {                       
            valitud.Text = "Ruut";
            valitudKujund = 4;
            Diameeter.IsEnabled = false;
            Laius.IsEnabled = false;
            Kõrgus.IsEnabled = false;
            Pikkus.IsEnabled = true;
            
        }        
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {

            double pikkus = double.Parse(Pikkus.Text);
            double laius = double.Parse(Laius.Text);
            double kõrgus = double.Parse(Kõrgus.Text);
            double diameeter = double.Parse(Diameeter.Text);
            if (valitudKujund == 1)
            {
                tulemusÜ = (pikkus + laius) * 2;
                ÜmbermõõtT.Text = tulemusÜ.ToString(); 
            }
            else if (valitudKujund == 2)
            {

            }
            else if (valitudKujund == 3)
            {
                tulemusÜ = (3.14 * (diameeter / 2)) * 2;
                ÜmbermõõtT.Text = tulemusÜ.ToString();
            }
            else if (valitudKujund == 4)
            {
                tulemusÜ = pikkus * 4;
                ÜmbermõõtT.Text = tulemusÜ.ToString();
            }
            else
            {
                MessageBox.Show("Palun valige kujund");
            }
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            double pikkus = double.Parse(Pikkus.Text);
            double laius = double.Parse(Laius.Text);
            double kõrgus = double.Parse(Kõrgus.Text);
            double diameeter = double.Parse(Diameeter.Text);
            if (valitudKujund == 1)
            {
                tulemusP = pikkus * laius;
                PindalaT.Text = tulemusP.ToString();
            }
            else if (valitudKujund == 2)
            {

            }
            else if (valitudKujund == 3)
            {
                tulemusP = 3.14 * ((diameeter / 2) * (diameeter / 2));
                PindalaT.Text = tulemusP.ToString();
            }
            else if (valitudKujund == 4)
            {
                tulemusP = pikkus * pikkus;
                PindalaT.Text = tulemusP.ToString();
            }
            else
            {
                MessageBox.Show("Palun valige kujund");
            }
        }

        
    }
}
