using ContactApp.ContactHelper;
using CsvHelper;
using CsvHelper.Configuration;
using SQLite;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
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
using System.Windows.Shapes;

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        public ContactWindow()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }

        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            if (firstNameTxt.Text != string.Empty && EmialTxt.Text != string.Empty && numberTxt.Text != string.Empty)
            {
                if (firstNameTxt.Text.Length > 3 && lastNameTxt.Text.Length > 3)
                {
                    if (numberTxt.Text.Length >= 10)
                    {
                        try
                        {
                            int number = Convert.ToInt32(numberTxt.Text);
                        }
                        catch (Exception ex)
                        {

                        }
                        //if (numberTxt.Text != numberTxt.Text)
                        {
                            if (EmialTxt.Text.Contains("@gmail.com") || EmialTxt.Text.Contains("@email.com"))
                            {
                                Contact contact = new()
                                {
                                    First_Name = firstNameTxt.Text,
                                    Last_Name = lastNameTxt.Text,
                                    Email = EmialTxt.Text,
                                    PhoneNumber = numberTxt.Text,
                                };
                                List<Contact> list = new List<Contact>();

                                if (contact != null)
                                {
                                    using (SQLiteConnection connection = new SQLiteConnection(App.datbasepath))
                                    {
                                        connection.CreateTable<Contact>();
                                        int data = connection.Insert(contact);
                                        list.Add(contact);
                                    }

                                    using (var write = new StreamWriter(@"D:\Data\WINDOWS PRESENTATION FORM\WPF NEW\ContactApp\DataBase\contactdata.csv"))
                                    using (var csv = new CsvWriter(write, new CsvConfiguration(CultureInfo.InvariantCulture)))
                                    {
                                        csv.WriteRecords(list);
                                        using (StreamWriter w = File.AppendText(csv.ToString()))
                                        {
                                            csv.WriteRecords(list);
                                        }
                                    }
                                }
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("'@gmail.com' symbal required", "Invalid email", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                        }
                        //else
                        //{
                        //    MessageBox.Show("'Enter the number'", "Invalid number", MessageBoxButton.OK, MessageBoxImage.Warning);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Phone number should 10", "Invalid phone number", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("First_Name & Last name should above 3 character", "Invalid name", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Fileds are not empty", "Fill the all data", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    }
}
