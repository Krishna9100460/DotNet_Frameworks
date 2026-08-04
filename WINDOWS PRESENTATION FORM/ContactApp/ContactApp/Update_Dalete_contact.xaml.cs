using ContactApp.ContactHelper;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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
    /// Interaction logic for Update_Dalete_contact.xaml
    /// </summary>
    public partial class Update_Dalete_contact : Window
    {
        Contact contactSelected;
        public Update_Dalete_contact(Contact ContactDetail)
        {
            InitializeComponent();
            this.contactSelected = ContactDetail;
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            NameTxt.Text= ContactDetail.First_Name;
            EmialTxt.Text = ContactDetail.Email;
            numberTxt.Text =ContactDetail.PhoneNumber.ToString();
        }
        private void Update_Clicked(object sender, RoutedEventArgs e)
        {
            contactSelected.First_Name=NameTxt.Text;
            contactSelected.Email= EmialTxt.Text;
            contactSelected.PhoneNumber=numberTxt.Text;
            using (SQLiteConnection connection = new SQLiteConnection(App.datbasepath))
            {
                connection.CreateTable<Contact>();
                connection.Update(contactSelected);
            }
            Close();
        }
        
        private void Delete_Clicked(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.datbasepath))
            {
                connection.CreateTable<Contact>();
                connection.Delete(contactSelected);
            }
            Close();
        }
        private void pnlMouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("yourclicked " + e.GetPosition(this).ToString());
        }
    }
}
