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
            MessageBox.Show("1. Valige kujund\n2. Sisestage mõõdud\n3. Vajutage ümbermõõt või pindala nuppu.\n   NB: Sisestage mõõdud ainult täisarvudes!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            valitud.Text = "Ristkülik";
            valitudKujund = 1;
            Kõrgus.IsEnabled = false;
            Diameeter.IsEnabled = false;
            Pikkus.IsEnabled = true;
            Laius.IsEnabled = true;
            Alus.IsEnabled = false;
            Kustuta();
            PeidaKolmnurgad();
            KolmnurkB.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Täisnurkne.Visibility = Visibility.Visible;
            Võrdkülgne.Visibility = Visibility.Visible;
            Võrdhaarne.Visibility = Visibility.Visible;
            valitud.Text = "Kolmnurk";
            valitudKujund = 2;
            Pikkus.IsEnabled = false;
            Diameeter.IsEnabled = false;
            Kõrgus.IsEnabled = true;
            Laius.IsEnabled = false;
            Alus.IsEnabled = true;
            Kustuta();
            if (Täisnurkne.IsChecked == true)
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                      
            valitud.Text = "Ring";
            valitudKujund = 3;
            Pikkus.IsEnabled = false;
            Laius.IsEnabled = false;
            Kõrgus.IsEnabled = false;
            Diameeter.IsEnabled = true;
            Alus.IsEnabled = false;
            Kustuta();
            PeidaKolmnurgad();
            KolmnurkB.IsEnabled = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {                       
            valitud.Text = "Ruut";
            valitudKujund = 4;
            Diameeter.IsEnabled = false;
            Laius.IsEnabled = false;
            Kõrgus.IsEnabled = false;
            Pikkus.IsEnabled = true;
            Alus.IsEnabled = false;
            Kustuta();
            PeidaKolmnurgad();
            KolmnurkB.IsEnabled = true;
            
        }        
        private void Ümbermõõt_Click(object sender, RoutedEventArgs e)
        {
            double pikkus = double.Parse(Pikkus.Text);

            double laius = double.Parse(Laius.Text);
            double kõrgus = double.Parse(Kõrgus.Text);
            double diameeter = double.Parse(Diameeter.Text);
            double alus = double.Parse(Alus.Text);
            double muutuv = double.Parse(MuutuvA.Text);
            if (valitudKujund == 1)
            {
                tulemusÜ = (pikkus + laius) * 2;
                ÜmbermõõtT.Text = tulemusÜ.ToString();
            }
            else if (valitudKujund == 2)
            {
                if (Täisnurkne.IsChecked == true)
                {
                    if (alus <= 0 || kõrgus <= 0 || muutuv <= 0 || (alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv || (muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus || (muutuv * muutuv) - (kõrgus * kõrgus) != alus * alus)
                    {
                        if (alus <= 0 || kõrgus <= 0 || muutuv <= 0)
                        {
                            MessageBox.Show("Pange mõõdud kõikitesse kastidesse");
                        }
                        else if ((alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades hüpotenuusi " + Math.Sqrt(((alus * alus) + (kõrgus * kõrgus))) +
                                 "\n või kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))) +
                                 "\n või alust " + Math.Sqrt(((muutuv * muutuv) - (kõrgus * kõrgus))));
                        }
                        else if ((muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))));
                        }
                        else if ((muutuv * muutuv) - (kõrgus * kõrgus) != alus * alus)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades alust " + Math.Sqrt(((muutuv * muutuv) - (kõrgus * kõrgus))));
                        }
                    }
                    else 
                    {
                        tulemusÜ = alus + kõrgus + muutuv;
                        ÜmbermõõtT.Text = tulemusÜ.ToString();
                    }
                    
                }
                else if (Võrdkülgne.IsChecked == true)
                {
                    if (alus <= 0)
                    {
                        MessageBox.Show("Pange mõõdud aluse kasti");
                    }
                    else
                    {
                        tulemusÜ = alus * 3;
                        ÜmbermõõtT.Text = tulemusÜ.ToString();
                    }
                    
                }
                else if (Võrdhaarne.IsChecked == true)
                {
                    if (alus <= 0 || kõrgus <= 0 || muutuv <= 0 || (alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv || (muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus)
                    {
                        if (alus <= 0 || muutuv <= 0)
                        {
                            MessageBox.Show("Pange mõõdud aluse ja haara kasti");
                        }
                        else if ((alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades hüpotenuusi " + Math.Sqrt(((alus * alus) + (kõrgus * kõrgus))) +
                                 "\n või kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))));                                                             
                        }
                        else if ((muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))));
                        }
                    }
                    else
                    {
                        tulemusÜ = alus + (muutuv * 2);
                        ÜmbermõõtT.Text = tulemusÜ.ToString();
                    }                    
                }

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

        private void Pindala_Click(object sender, RoutedEventArgs e)
        {
            double pikkus = double.Parse(Pikkus.Text);
            double laius = double.Parse(Laius.Text);
            double kõrgus = double.Parse(Kõrgus.Text);
            double alus = double.Parse(Alus.Text);
            double diameeter = double.Parse(Diameeter.Text);
            double muutuv = double.Parse(MuutuvA.Text);
            if (valitudKujund == 1)
            {
                tulemusP = pikkus * laius;
                PindalaT.Text = tulemusP.ToString();
            }
            else if (valitudKujund == 2)
            {
                if (Täisnurkne.IsChecked == true)
                {
                    if (alus <= 0 || kõrgus <= 0 || muutuv <= 0 || (alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv || (muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus || (muutuv * muutuv) - (kõrgus * kõrgus) != alus * alus)
                    {
                        if (alus <= 0 || kõrgus <= 0 || muutuv <= 0)
                        {
                            MessageBox.Show("Pange mõõdud kõikitesse kastidesse");
                        }
                        else if ((alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades hüpotenuusi " + Math.Sqrt(((alus * alus) + (kõrgus * kõrgus))) +
                                 "\n või kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))) +
                                 "\n või alust " + Math.Sqrt(((muutuv * muutuv) - (kõrgus * kõrgus))));
                        }
                        else if ((muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))));
                        }
                        else if ((muutuv * muutuv) - (kõrgus * kõrgus) != alus * alus)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades alust " + Math.Sqrt(((muutuv * muutuv) - (kõrgus * kõrgus))));
                        }
                    }
                    else 
                    {
                        tulemusP = (alus * kõrgus) / 2;
                        PindalaT.Text = tulemusP.ToString();
                    }                    
                }
                else if (Võrdkülgne.IsChecked == true)
                {
                    if (alus <= 0)
                    {
                        MessageBox.Show("Pange mõõdud aluse kasti");
                    }
                    else
                    {
                        tulemusP = (alus * kõrgus) / 2;
                        PindalaT.Text = tulemusP.ToString();
                    }
                    
                }
                else if (Võrdhaarne.IsChecked == true)
                {
                    if (alus <= 0 || kõrgus <= 0 || muutuv <= 0 || (alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv || (muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus)
                    {
                        if (alus <= 0 || muutuv <= 0)
                        {
                            MessageBox.Show("Pange mõõdud aluse ja haara kasti");
                        }
                        else if ((alus * alus) + (kõrgus * kõrgus) != muutuv * muutuv)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades hüpotenuusi " + Math.Sqrt(((alus * alus) + (kõrgus * kõrgus))) +
                                 "\n või kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))));                            
                        }
                        else if ((muutuv * muutuv) - (alus * alus) != kõrgus * kõrgus)
                        {
                            MessageBox.Show("Sellist kujundit ei ole võimalik teha\n Võimalik on kasutades kõrgust " + Math.Sqrt(((muutuv * muutuv) - (alus * alus))));
                        }
                    }
                    else
                    {
                        tulemusP = (alus * kõrgus) / 2;
                        PindalaT.Text = tulemusP.ToString();
                    } 
                    
                }
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
        private void Kustuta()
        {
            Pikkus.Text = "0";
            Laius.Text = "0";
            Kõrgus.Text = "0";
            Diameeter.Text = "0";
            Alus.Text = "0";
            MuutuvA.Text = "0";
            ÜmbermõõtT.Text = "0";
            PindalaT.Text = "0";
        }
        private void PeidaKolmnurgad()
        {            
            Täisnurkne.Visibility = Visibility.Hidden;
            Võrdkülgne.Visibility = Visibility.Hidden;
            Võrdhaarne.Visibility = Visibility.Hidden;
            Täisnurkne.IsChecked = false;
            Võrdkülgne.IsChecked = false;
            Võrdhaarne.IsChecked = false;
        }

        private void Täisnurkne_Checked(object sender, RoutedEventArgs e)
        {
            valitud.Text = "Täisnurkne kolmnurk";
            KolmnurkB.IsEnabled = false;
            Muutuv.Text = "Hüpotenuus:";
            Muutuv.Visibility = Visibility.Visible;
            MuutuvA.Visibility = Visibility.Visible;
            MuutuvA.IsEnabled = true;
        }

        private void Võrdkülgne_Checked(object sender, RoutedEventArgs e)
        {
            valitud.Text = "Võrdkülgne kolmnurk";
            KolmnurkB.IsEnabled = false;
            Muutuv.Visibility = Visibility.Hidden;
            MuutuvA.Visibility = Visibility.Hidden;
        }

        private void Võrdhaarne_Checked(object sender, RoutedEventArgs e)
        {
            valitud.Text = "Võrdhaarne kolmnurk";
            KolmnurkB.IsEnabled = false;
            Muutuv.Text = "Haar:";
            Muutuv.Visibility = Visibility.Visible;
            MuutuvA.Visibility = Visibility.Visible;
            MuutuvA.IsEnabled = true;
        }                              
    }
}
