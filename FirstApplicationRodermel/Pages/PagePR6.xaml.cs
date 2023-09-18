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
using System.IO;
using System.Reflection;

namespace FirstApplicationRodermel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR6.xaml
    /// </summary>
    public partial class PagePR6 : Page
    {
        public PagePR6()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lstInput.SelectedIndex;
                string str = (string)lstInput.Items[index];
                string line = lstInput.SelectedItem.ToString();
                int len = str.Length;
                int count1 = 0;
                int count0 = 0;
                int i = 0;
                while (i < len)
                {
                    if (str[i] == '0')
                        count0++;
                    if (str[i] == '1')
                        count1++;
                    i++;
                }
                
                txbRwsult.Text = "Количество нулей = " + count0.ToString() + Environment.NewLine + "Количество единиц = " + count1.ToString();
                
                StreamWriter sw = new StreamWriter(@"Result.txt");
                sw.WriteLine($"Номер строки: {index}");
                sw.WriteLine($"Исходная строка: {line}");
                sw.WriteLine($"Новая строка: {txbRwsult.Text}");
                sw.Close();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        private void btnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
        }
    }
}

