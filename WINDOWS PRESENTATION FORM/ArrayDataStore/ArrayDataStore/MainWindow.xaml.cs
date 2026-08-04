using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Xml.Linq;

namespace ArrayDataStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] name; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             int length=Convert.ToInt32(txtllenbth.Text);

            name= new string[length];
          
            for (int i = 0; i < length; i++)
            {
                name[i] = txtName.Text;
            }

           txtllenbth.Clear();
          txtName.Clear();

        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < name.Length; i++)
            {
                lblData.Content = name[i]+"\n";
            } 
        }
    }
}
