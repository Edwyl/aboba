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

namespace FirstApplicationRodermel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR1.xaml
    /// </summary>
    public partial class PagePR1 : Page
    {
        public PagePR1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtX.Text);
            double y = Convert.ToDouble(TxtY.Text);
            double z = Convert.ToDouble(TxtZ.Text);
            double t = (2 * Math.Cos(x - Math.PI/6)) / (0.5 + Math.Sin(y) * Math.Sin(y)) * (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
            LstResult.Items.Add("Лаб. раб. №1 Ст. гр. исп.21.2а Каламфуров, Родермель");
            LstResult.Items.Add($"x={x}");
            LstResult.Items.Add($"y={y}");
            LstResult.Items.Add($"z={z}");
            LstResult.Items.Add($"Результат t={t}");
        }

        private void BtnNextPR6_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR6());
        }

        private void BtnNextPR2_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR2());
        }
    }
}
