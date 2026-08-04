using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WPFDependencyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string fname = "null ";
        public string lname = " null";
        public string gmail = " null";
        public string loc = " null";
        public string country = "null";
        int count = 0;
        string  dateonly= "null";
        string dob= "null";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
              DateTime date = calendar.SelectedDate.Value;
               dateonly=date.ToShortDateString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<DataModel> list = new List<DataModel>();
            if (gmailtxt.Text == string.Empty || ftxt.Text == string.Empty || ltxt.Text == string.Empty || loctxt.Text == string.Empty||combox.Text==string.Empty||counttxt.Text==string.Empty)
            {
                MessageBox.Show("Enter valide data");
            }

            else
            {
                count = Convert.ToInt32(counttxt.Text);
                fname = ftxt.Text;
                lname = ltxt.Text;
                gmail = gmailtxt.Text;
                loc = loctxt.Text;
                country = combox.Text;
                dob = dateonly;
            }
           
            //  AddData s = new AddData();

            UserGrid.ItemsSource = list;
             for(int i=0;i <= count;i++)
            {
                DataModel d = new DataModel
                {
                    Fname = fname,
                    Lname = lname,
                    Gmail = gmail,
                    Location = loc,
                    Gender = country,
                    DateOfBirth = dob,
                };
                list.Add(d);
            }
         

            ftxt.Clear();
            ltxt.Clear();
            gmailtxt.Clear();
            loctxt.Clear();

        }

    }
}
