using Hospital.DataObjects;
using Hospital.Services;
using Hospital.Utils;
using Hospital.XAML.CreateWindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Hospital.XAML.Pages
{
    /// <summary>
    /// Interaction logic for AdmissionsPage.xaml
    /// </summary>
    public partial class AdmissionsPage : Page
    {
        private AdmissionsService AdmissionsService = new();

        public AdmissionsPage()
        {
            InitializeComponent();
            DataContext = this;
            this.Resources.MergedDictionaries.Add(LangHelper.GetResourceDictionary());

            UpdateTable();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new CreateAdmissionWindow().ShowDialog();

            UpdateTable();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Admissions admission = (Admissions)button.DataContext;

            if (admission != null)
            {
                new CreateAdmissionWindow(admission).ShowDialog();

                UpdateTable();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            Admissions admission = (Admissions)button.DataContext;

            if (admission != null)
            {
                if ((bool) new AreYouSureWindow().ShowDialog())
                {
                    AdmissionsService.Delete(admission.Id);
                    new SuccessWindow(LangHelper.GetString("SuccessDeleted")).Show();
                    UpdateTable();
                }
            }
        }

        private ObservableCollection<Admissions> UpdateTable()
        {
            ObservableCollection<Admissions> admissions = new(AdmissionsService.GetAll());

            DataGrid.ItemsSource = admissions;
            return admissions;
        }

        private void textBoxFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Admissions> newCollection = new List<Admissions>();
            IEnumerable<Admissions> objects = (IEnumerable<Admissions>)UpdateTable();
            foreach (var obj in objects)
            {
                string filter = textBoxFilter.Text.ToLower();
                if (obj.Patient.Name.ToLower().Contains(filter) || obj.Patient.Surname.ToLower().Contains(filter) || obj.Patient.Contact.Contains(filter)
                    || obj.EntryDate.ToString().ToLower().Contains(filter) || obj.ExitDate.ToString().ToLower().Contains(filter))
                    newCollection.Add(obj);
            }
            DataGrid.ItemsSource = newCollection;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
