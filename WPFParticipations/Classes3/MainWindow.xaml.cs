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

namespace Classes3
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
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool isEverythingGood = true;
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Name!");
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Name!");
            }
            if (string.IsNullOrWhiteSpace(txtMajor.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Major!");
            }
            double gpa;
            if (double.TryParse(txtGPA.Text, out gpa) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid GPA!");
            }
            int streetnumber;
            if (int.TryParse(txtStreetNumber.Text, out streetnumber) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Street Number!");
            }
            if (string.IsNullOrWhiteSpace(txtStreetName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Street Name!");
            }
            if (string.IsNullOrWhiteSpace(txtCity.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid City!");
            }
            if (string.IsNullOrWhiteSpace(txtState.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid State!");
            }
            int zipcode;
            if (int.TryParse(txtZipCode.Text, out zipcode) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid ZipCode!");
            }
            if (isEverythingGood == false)
            {
                return;
            }

            Student student = new Student()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                GPA = gpa,
                Major = txtMajor.Text
            };
            student.SetAddress(streetnumber, txtStreetName.Text, txtState.Text, txtCity.Text, zipcode);

            lstGraduationHandout.Items.Add(student);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtMajor.Clear();
            txtGPA.Clear();
            txtStreetNumber.Clear();
            txtStreetName.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipCode.Clear();
        }

        private void lstGraduationHandout_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstGraduationHandout.SelectedItem != null)
            {
                MessageBox.Show(lstGraduationHandout.SelectedItem.ToString());
            }
        }
    }
}
