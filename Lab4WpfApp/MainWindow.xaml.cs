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

namespace Lab4WpfApp
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate2.Text);
            double sumGriv = Convert.ToDouble(sum2.Text);
            double resGriv = rateGriv * sumGriv;
            resSum2.Text = resGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDram = rateDram * sumDram;
            resSum3.Text = resDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateDuym = Convert.ToDouble(rate4.Text);
            double sumAll = Convert.ToDouble(0.0254);
            double resDuym = rateDuym * sumAll;
            resSum4.Text = resDuym.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFut = Convert.ToDouble(rate5.Text);
            double sumAll = Convert.ToDouble(0.3048);
            double resFut = rateFut * sumAll;
            resSum5.Text = resFut.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(rate6.Text);
            double sumAll = Convert.ToDouble(1609.34);
            double resMiles = rateMiles * sumAll;
            resSum6.Text = resMiles.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rate7.Text);
            double sumAll = Convert.ToDouble(1066.8);
            double resVerst = rateVerst * sumAll;
            resSum7.Text = resVerst.ToString();
        }
    }
}
