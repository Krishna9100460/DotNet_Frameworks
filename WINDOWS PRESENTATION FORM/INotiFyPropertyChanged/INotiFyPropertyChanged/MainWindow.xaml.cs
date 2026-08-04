using INotiFyPropertyChanged.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace INotiFyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p=new Person();
        private List<User> userData;    
        public MainWindow()
        {
            InitializeComponent();
            userData = new List<User>()
            {
                new User{UserName="user1" ,Password="password1"},
                new User{UserName="user2" ,Password="password2"},
                new User{UserName="user3" ,Password="password3"}

            };

        }

        private void TextBox_LayoutUpdated(object sender, EventArgs e)
        {
            TextBox_LayoutUpdated(sender, e);
            
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
           string username=txtUserName.Text.Trim();
            string password=txtPass.Text.Trim();

            if(string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter User name & Password");
                return;
            }
            if(userData.Any(u=>u.UserName==username))
            {
                MessageBox.Show("User alredy exist");
            }

            userData.Add(new User { UserName=username,Password=password});
            MessageBox.Show("Register SuccessFull");
            ClrearField();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username= txtUserName.Text.Trim();
            string password=txtPass.Text.Trim();

            if(string.IsNullOrEmpty(password)|| string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter UserName && Password");
                return;
            }
            User user=userData.FirstOrDefault(u=>u.UserName==username && u.Password==password);

            if(user!=null)
            {
                MessageBox.Show("Login SuccessFully");
                Visit();
                ClrearField();
            }
            else
            {
                MessageBox.Show("Error:Invalid Dettails");
            }
        }
        
        private void ClrearField()
        {
            txtUserName.Clear();
            txtPass.Clear();
        }

       

        private void Visit()
        {
            Process.Start(new ProcessStartInfo("https://www.c-sharpcorner.com/article/explaing-icommand-in-mvvm-wpf/") 
            {
                UseShellExecute = true 
            });
        }
    }
}
