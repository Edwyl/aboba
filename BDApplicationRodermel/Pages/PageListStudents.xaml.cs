using BDApplicationRodermel.Classes;
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

namespace BDApplicationRodermel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageListStudents.xaml
    /// </summary>
    public partial class PageListStudents : Page
    {
        public PageListStudents()
        {
            InitializeComponent();
            dtgListStudents.ItemsSource = lesuser25Entities.GetContext().Ученики.ToList();

            var listDisc = lesuser25Entities.GetContext().Ученики.
                Select(x => x.Предмет).Distinct().ToList();
            CmbDiscipline.Items.Add("Все предметы");
            foreach (var item in listDisc)
            {
                CmbDiscipline.Items.Add(item);
            }

        }

        private void CmbDiscipline_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string discipline = CmbDiscipline.SelectedValue.ToString();

            if (discipline == "Все предметы")
                dtgListStudents.ItemsSource = lesuser25Entities.GetContext().Ученики.ToList();
            else
                dtgListStudents.ItemsSource = lesuser25Entities.GetContext().Ученики.Where(x => x.Предмет == discipline).ToList();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = TxtSearch.Text;

            dtgListStudents.ItemsSource = lesuser25Entities.GetContext().Ученики.Where(x => x.Фамилия.Contains(search)).ToList();
        }
    }
}
