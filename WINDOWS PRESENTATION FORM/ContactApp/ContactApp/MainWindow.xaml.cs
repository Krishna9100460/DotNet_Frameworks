using ContactApp.ContactHelper;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> list=new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();
            ReadData();
        }

        private void NewContact_clicked(object sender, RoutedEventArgs e)
        {
            ContactWindow wid= new ContactWindow();
            wid.ShowDialog();
            ReadData();
        }

        void ReadData()
        {
           
            using(SQLite.SQLiteConnection connection=new SQLite.SQLiteConnection(App.datbasepath))
            {
                connection.CreateTable<Contact>();
                list=(connection.Table<Contact>().ToList()).OrderBy(c=>c.First_Name).ToList();
            }
            if (list != null)
            {
                ContactDataView.ItemsSource = list;
            }
        }
        private void TextSearch_Value(object sender, TextChangedEventArgs e)
       {
            TextBox? textBoxSearch=sender as TextBox;
            if(textBoxSearch!=null)
            {
                var filterData = list.Where(c => c.First_Name.ToLower().Contains(textBoxSearch.Text.ToLower()) || 
                                            c.Email.ToLower().Contains(textBoxSearch.Text.ToLower()) ||
                                            c.PhoneNumber.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
                //var filterData = list.FindAll(l=>l.ToString().ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
                ContactDataView.ItemsSource = filterData;
            }
        }

        private void Constact_Selecte(object sender, SelectionChangedEventArgs e)
        {
           Contact selectedContact=(Contact) ContactDataView.SelectedItem;
            if(selectedContact!=null)
            {
                Update_Dalete_contact contactDetail = new Update_Dalete_contact(selectedContact);
                contactDetail.ShowDialog();
                ReadData();
            }
        }
    }
}
