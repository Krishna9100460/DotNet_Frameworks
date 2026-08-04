using ContactApp.ContactHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
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

namespace ContactApp.Controllers
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
       // private List<Contact> contact=new List<Contact>();

        /*public List<Contact> Contact
        {
            get { return contact; }
            set 
            { 
                contact = value;
                ContactDataView.ItemsSource= contact;
            }
        }*/


        //public List<Contact> Contact
        //{
        //    get { return (List<Contact>)GetValue(ContactProperty); }
        //    set 
        //    { 
        //        SetValue(ContactProperty, value);
        //    }
        //}

        //// Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ContactProperty =
        //    DependencyProperty.Register("Contact", typeof(int), typeof(ContactControl), new PropertyMetadata(0,SetText));

        //private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    ContactControl? control = d as ContactControl;
        //    if (control !=null)
        //    {
        //        control.ContactDataView.ColumnHeaderStringFormat= (e.NewValue as Contact).PhoneNumber;
        //        /*control.nameTxt.HeaderStringFormat= (e.NewValue as Contact).First_Name;
        //        control.emailTxt.HeaderStringFormat = (e.NewValue as Contact).Email;
        //        control.numberTxt.HeaderStringFormat = (e.NewValue as Contact).PhoneNumber;*/
        //    }
        //}
      

        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
