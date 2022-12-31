using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Diagnostics;

namespace Student_Rental_App
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

        private void btnClear_All_Click(object sender, RoutedEventArgs e)
        {
            txtemail.Text = String.Empty;
            txtFirst_Name.Text = String.Empty;
            txtLast_Name.Text = String.Empty;
            txtLease_length.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtPrice_Start.Text = String.Empty;
            txtPrice_Stop.Text = String.Empty;
            pwdSSN.Password = String.Empty;
            txtRooms_Number.Text = String.Empty;
            txtProperty_Location.Text = String.Empty;
            txtOccupation.Text = String.Empty;
            cboPets.Items.Clear();
        }

        private void txtFirst_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtFirst_Name.MaxLength = 13;
            txtFirst_Name.MinLines = 1;

        }

        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            txtFirst_Name.MaxLength = 13;
            txtFirst_Name.MinLines = 1;

            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtLast_Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtLast_Name.MaxLength = 13;
            txtLast_Name.MinLines = 1;

            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtOccupation_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtOccupation.MaxLength = 13;
            txtOccupation.MinLines = 1;

            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtPhone.MaxLength = 10;
            txtPhone.MinLines = 1;

            Regex regex = new Regex("[^0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtProperty_Location_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtProperty_Location.MaxLength = 13;
            txtProperty_Location.MinLines = 1;

            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtRooms_Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtRooms_Number.MaxLength = 2;
            txtRooms_Number.MinLines = 1;

            Regex regex = new Regex("[^0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtLease_length_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+$");
            e.Handled = regex.IsMatch(e.Text); 
        }

        private void txtRooms_Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtRooms_Number.Text, out box_int);
            if(box_int < 1 && txtRooms_Number.Text != "")
            {
                txtRooms_Number.Text = "1";
                MessageBox.Show("Not less than 1");
            }
            else if (box_int > 10 && txtRooms_Number.Text != "") 
            {
                txtRooms_Number.Text = "10";
                MessageBox.Show("Not more than 10");
            }
        }

        private void txtLease_length_TextChanged(object sender, TextChangedEventArgs e)
        {
            int box_int = 6;
            Int32.TryParse(txtLease_length.Text, out box_int);
            if (box_int < 6 && txtLease_length.Text != "")
            {
                txtLease_length.Text = "6";
                MessageBox.Show("Not less than 6 months");
            }
            else if (box_int > 12 && txtLease_length.Text != "")
            {
                txtLease_length.Text = "12";
                MessageBox.Show("Not more than 12 months");
            }
        }

        private void txtPrice_Start_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtPrice_Start.MaxLength = 4;
            txtPrice_Start.MinLines = 1;

            Regex regex = new Regex("[^0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtPrice_Stop_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            txtPrice_Stop.MaxLength = 4;
            txtPrice_Stop.MinLines = 1;

            Regex regex = new Regex("[^0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void pwdSSN_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            pwdSSN.MaxLength = 9;
            pwdSSN.PasswordChar = '*';

            Regex regex = new Regex("[^0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/");
        }
    }
}
