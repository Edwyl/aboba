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
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);
            double u;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Кузьмина Е.Е.");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"Y={y}");
            lstResult.Items.Add($"Z={z}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if ((z - x) == 0) u = y * Math.Sin(x) * Math.Sin(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Sin(x)) - z;
                    else u = y * Math.Sin(Math.Sin(x)) + z;
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                case 1:
                    if ((z - x) == 0) u = y * Math.Cos(x) * Math.Cos(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Cos(x)) - z;
                    else u = y * Math.Sin(Math.Cos(x)) + z;
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                case 2:
                    if ((z - x) == 0) u = y * Math.Exp(x) * Math.Exp(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Exp(x)) - z;
                    else u = y * Math.Sin(Math.Exp(x)) + z;
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }
        }

            private void btnClear_Click(object sender, RoutedEventArgs e)
            {
                txtX.Clear();
                txtY.Clear();
                txtZ.Clear();
                lstResult.Items.Clear();
            }
        }
    }
